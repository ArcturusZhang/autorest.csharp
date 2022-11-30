// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoRest.CSharp.Common.Output.Builders;
using AutoRest.CSharp.Common.Output.Models.Types;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Input.Source;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Utilities;
using Azure.ResourceManager.Resources.Models;
using static AutoRest.CSharp.Output.Models.MethodSignatureModifiers;

namespace AutoRest.CSharp.Output.Models.Types
{
    internal sealed class ModelFactoryTypeProvider : TypeProvider
    {
        protected override string DefaultName { get; }
        protected override string DefaultAccessibility { get; }

        private IEnumerable<MethodSignature>? _methods;
        public IEnumerable<MethodSignature> Methods => _methods ??= Models.Select(CreateMethod);

        public IEnumerable<SerializableObjectType> Models { get; }

        internal string FullName => $"{Type.Namespace}.{Type.Name}";

        private ModelFactoryTypeProvider(IEnumerable<SerializableObjectType> objectTypes, string defaultClientName, string defaultNamespace, SourceInputModel? sourceInputModel) : base(defaultNamespace, sourceInputModel)
        {
            Models = objectTypes;

            DefaultName = $"{defaultClientName}ModelFactory".ToCleanName();
            DefaultAccessibility = "public";
        }

        public static ModelFactoryTypeProvider? TryCreate(string rootNamespaceName, IEnumerable<TypeProvider> models, SourceInputModel? sourceInputModel)
        {
            var objectTypes = models.OfType<SerializableObjectType>()
                .Where(RequiresModelFactory)
                .ToArray();

            if (!objectTypes.Any())
            {
                return null;
            }

            var defaultClientName = ClientBuilder.GetClientPrefix(Configuration.LibraryName, rootNamespaceName);
            var defaultNamespace = GetDefaultModelNamespace(null, rootNamespaceName);

            return new ModelFactoryTypeProvider(objectTypes, defaultClientName, defaultNamespace, sourceInputModel);
        }

        private HashSet<MethodInfo>? _existingModelFactoryMethods;
        public HashSet<MethodInfo> ExistingModelFactoryMethods => _existingModelFactoryMethods ??= typeof(ResourceManagerModelFactory).GetMethods(BindingFlags.Static | BindingFlags.Public).ToHashSet();

        public (ObjectTypeProperty Property, FormattableString Assignment) GetPropertyAssignment(CodeWriter writer, SerializableObjectType model, Parameter parameter)
        {
            var propertyStack = _parameterPropertyCache[model][parameter];
            var assignmentProperty = propertyStack.Last();
            ObjectTypeProperty property, immediateParentProperty;
            property = propertyStack.Pop();
            FormattableString result = $"{parameter.Name:I}";
            CSharpType from = parameter.Type;
            while (propertyStack.Count > 0)
            {
                immediateParentProperty = propertyStack.Pop();
                var parentPropertyType = immediateParentProperty.Declaration.Type;
                switch (parentPropertyType)
                {
                    case { IsFrameworkType: false, Implementation: SerializableObjectType serializableObjectType }:
                        // get the type of the first parameter of its ctor
                        var to = serializableObjectType.SerializationConstructor.Signature.Parameters.First().Type;
                        result = $"new {parentPropertyType}({result}{GetConversion(writer, from, to)})";
                        break;
                    case { IsFrameworkType: false, Implementation: SystemObjectType systemObjectType }:
                        // for the case of SystemObjectType, the serialization constructor is internal and the definition of this class might be outside of this assembly, we need to use its corresponding model factory to construct it
                        // find the method in the list
                        var method = ExistingModelFactoryMethods.First(m => m.Name == systemObjectType.Type.Name);
                        result = $"{method.DeclaringType!}.{method.Name}({result})";
                        break;
                    default:
                        throw new InvalidOperationException($"The propertyType {parentPropertyType} (implementation type: {parentPropertyType.Implementation.GetType()}) is unhandled here, this should never happen");
                }

                // change the from type to the current type
                property = immediateParentProperty;
                from = parentPropertyType; // since this is the property type of the immediate parent property, we should never get another valid conversion
            }

            return (assignmentProperty, result);
        }

        private static string GetConversion(CodeWriter writer, CSharpType from, CSharpType to)
        {
            if (TypeFactory.RequiresToList(from, to))
            {
                writer.UseNamespace(typeof(Enumerable).Namespace!);
                return from.IsNullable ? "?.ToList()" : ".ToList()";
            }

            return string.Empty;
        }

        private readonly Dictionary<SerializableObjectType, Dictionary<Parameter, Stack<ObjectTypeProperty>>> _parameterPropertyCache = new();

        private MethodSignature CreateMethod(SerializableObjectType modelType)
        {
            var ctor = modelType.SerializationConstructor;
            var ctorSignature = ctor.Signature;
            var methodParameters = new List<Parameter>(ctorSignature.Parameters.Count);
            var cache = new Dictionary<Parameter, Stack<ObjectTypeProperty>>();

            var discriminator = modelType.Discriminator;

            foreach (var ctorParameter in ctorSignature.Parameters)
            {
                var property = ctor.FindPropertyInitializedByParameter(ctorParameter);
                if (property == null)
                    continue;

                (var parameterName, var propertyStack) = GetPropertyStack(property);
                property = propertyStack.Peek();

                var inputType = property.Declaration.Type;
                // check if the property is the discriminator
                if (discriminator != null && discriminator.Property == property)
                {
                    var value = discriminator.Value;
                    if (value != null)
                    {
                        // this is a derived class
                        continue;
                    }
                    else
                    {
                        // this is the base
                        if (inputType.TryCast<EnumType>(out var enumType))
                        {
                            inputType = enumType.ValueType;
                        }
                    }
                }

                inputType = TypeFactory.GetInputType(inputType);
                if (!inputType.IsValueType)
                {
                    inputType = inputType.WithNullable(true);
                }

                var modelFactoryMethodParameter = ctorParameter with
                {
                    Name = parameterName,
                    Type = inputType,
                    DefaultValue = Constant.Default(inputType),
                    Initializer = inputType.GetParameterInitializer(ctorParameter.DefaultValue)
                };

                methodParameters.Add(modelFactoryMethodParameter);
                cache.Add(modelFactoryMethodParameter, propertyStack);
            }

            _parameterPropertyCache.Add(modelType, cache);

            FormattableString returnDescription = $"A new <see cref=\"{modelType.Declaration.Namespace}.{modelType.Declaration.Name}\"/> instance for mocking.";

            return new MethodSignature(ctorSignature.Name, ctorSignature.Summary, ctorSignature.Description, Public | Static, modelType.Type, returnDescription, methodParameters);
        }

        private (string ParameterName, Stack<ObjectTypeProperty> HierarchyStack) GetPropertyStack(ObjectTypeProperty property)
        {
            if (Configuration.AzureArm)
            {
                var hierarchyStack = property.GetHierarchyStack();

                return (GetPropertyName(hierarchyStack), hierarchyStack);
            }

            var stack = new Stack<ObjectTypeProperty>();
            stack.Push(property);
            return (property.Declaration.Name.ToVariableName(), stack);
        }

        private string GetPropertyName(Stack<ObjectTypeProperty> hierarchyStack)
        {
            if (hierarchyStack.Count > 1)
            {
                var innerProperty = hierarchyStack.Pop();
                var immediateParent = hierarchyStack.Pop();
                var parameterName = innerProperty.GetCombinedPropertyName(immediateParent).ToVariableName();
                hierarchyStack.Push(immediateParent);
                hierarchyStack.Push(innerProperty);

                return parameterName;
            }

            return hierarchyStack.Peek().Declaration.Name.ToVariableName();
        }

        private static bool RequiresModelFactory(SerializableObjectType model)
        {
            // TODO -- we might need to remove the `IsAbstract` check
            if (model.Declaration.Accessibility != "public" || !model.IncludeDeserializer || model.Declaration.IsAbstract)
            {
                return false;
            }

            if (model.Properties.Any(p => p.Declaration.Accessibility != "public" && p.SchemaProperty?.IsDiscriminator != true))
            {
                return false;
            }

            var readOnlyProperties = GetAllProperties(model)
                .Where(p => p.IsReadOnly && !TypeFactory.IsReadWriteDictionary(p.ValueType) && !TypeFactory.IsReadWriteList(p.ValueType))
                .ToList();

            if (!readOnlyProperties.Any())
            {
                return false;
            }

            if (model.SerializationConstructor.Signature.Parameters.Any(p => !p.Type.IsPublic))
            {
                return false;
            }

            return model.Constructors
                .Where(c => c.Signature.Modifiers.HasFlag(Public))
                .All(c => readOnlyProperties.Any(property => c.FindParameterByInitializedProperty(property) == default));
        }

        private static IEnumerable<ObjectTypeProperty> GetAllProperties(SerializableObjectType model)
        {
            foreach (var hierarchy in model.EnumerateHierarchy())
            {
                foreach (var property in hierarchy.Properties)
                    yield return property;
            }
        }
    }
}
