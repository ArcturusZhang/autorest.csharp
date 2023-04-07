// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Input.Source;
using AutoRest.CSharp.Output.Builders;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Utilities;
using Microsoft.CodeAnalysis;
using static AutoRest.CSharp.Output.Models.FieldModifiers;

namespace AutoRest.CSharp.Output.Models.Types
{
    internal class SchemaObjectTypeFields : IObjectTypeFields<Property>
    {
        private readonly IReadOnlyList<FieldDeclaration> _fields;
        private readonly IReadOnlyDictionary<FieldDeclaration, Property> _fieldsToInputs;
        // parameter name should be unique since it's bound to field property
        private readonly IReadOnlyDictionary<string, FieldDeclaration> _parameterNamesToFields;

        public IReadOnlyList<Parameter> PublicConstructorParameters { get; }
        public IReadOnlyList<Parameter> SerializationParameters { get; }
        public int Count => _fields.Count;

        public SchemaObjectTypeFields(SchemaObjectType enclosingType, ObjectSchema inputModel, SchemaTypeUsage usage, TypeFactory typeFactory, ModelTypeMapping? sourceTypeMapping)
        {
            var fields = new List<FieldDeclaration>();
            var fieldsToInputs = new Dictionary<FieldDeclaration, Property>();
            var publicParameters = new List<Parameter>();
            var serializationParameters = new List<Parameter>();
            var parametersToFields = new Dictionary<string, FieldDeclaration>();

            //string? discriminator = inputModel.DiscriminatorPropertyName;
            //if (discriminator is not null)
            //{
            //    var originalFieldName = discriminator.ToCleanName();
            //    var inputModelProperty = new InputModelProperty(discriminator, discriminator, "Discriminator", InputPrimitiveType.String, true, false, true);
            //    var field = CreateField(originalFieldName, typeof(string), inputModel, inputModelProperty);
            //    fields.Add(field);
            //    fieldsToInputs[field] = inputModelProperty;
            //    var parameter = Parameter.FromModelProperty(inputModelProperty, field.Name.FirstCharToLowerCase(), field.Type);
            //    parametersToFields[parameter.Name] = field;
            //    serializationParameters.Add(parameter);
            //}

            foreach (var property in inputModel.Properties)
            {
                var originalFieldName = BuilderHelpers.DisambiguateName(enclosingType.Type, property.CSharpName());
                var originalFieldType = GetPropertyDefaultType(usage, property, typeFactory);

                var existingMember = sourceTypeMapping?.GetForMember(originalFieldName)?.ExistingMember;
                var field = existingMember is not null
                    ? CreateFieldFromExisting(existingMember, originalFieldType, property, typeFactory)
                    : CreateField(originalFieldName, originalFieldType, inputModel, property, usage);

                fields.Add(field);
                fieldsToInputs[field] = property;

                if (property.Schema is ConstantSchema)
                {
                    continue; // literal property does not show up in the constructor parameter list // TODO -- fix this because this is wrong
                }
                var parameter = Parameter.FromSchemaProperty(property, existingMember is IFieldSymbol ? originalFieldName.ToVariableName() : field.Name.ToVariableName(), field.Type);
                parametersToFields[parameter.Name] = field;
                serializationParameters.Add(parameter);
                if (property.IsRequired && !property.IsReadOnly)
                {
                    publicParameters.Add(parameter);
                }
            }

            _fields = fields;
            _fieldsToInputs = fieldsToInputs;
            _parameterNamesToFields = parametersToFields;

            PublicConstructorParameters = publicParameters;
            SerializationParameters = serializationParameters;
        }

        public FieldDeclaration GetFieldByParameter(Parameter parameter) => _parameterNamesToFields[parameter.Name];
        public bool TryGetFieldByParameter(Parameter parameter, [MaybeNullWhen(false)] out FieldDeclaration fieldDeclaration) => _parameterNamesToFields.TryGetValue(parameter.Name, out fieldDeclaration);
        public Property GetInputByField(FieldDeclaration field) => _fieldsToInputs[field];

        public IEnumerator<FieldDeclaration> GetEnumerator() => _fields.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private static FieldDeclaration CreateField(string fieldName, CSharpType fieldType, ObjectSchema inputModel, Property inputModelProperty, SchemaTypeUsage usage)
        {
            var propertyIsCollection = inputModelProperty.Schema is ArraySchema or DictionarySchema;
            var propertyIsRequiredInNonRoundTripModel = !(usage.HasFlag(SchemaTypeUsage.Input) && usage.HasFlag(SchemaTypeUsage.Output)) && inputModelProperty.IsRequired;
            var propertyIsOptionalInOutputModel = !usage.HasFlag(InputModelTypeUsage.Input) && !inputModelProperty.IsRequired;
            var propertyIsLiteralType = inputModelProperty.Schema is ConstantSchema;
            var propertyIsReadOnly = inputModelProperty.IsReadOnly || propertyIsLiteralType || propertyIsCollection || propertyIsRequiredInNonRoundTripModel || propertyIsOptionalInOutputModel;
            var propertyIsDiscriminator = inputModelProperty.IsDiscriminator ?? false;

            FieldModifiers fieldModifiers;
            FieldModifiers? setterModifiers = null;
            if (propertyIsDiscriminator)
            {
                fieldModifiers = Configuration.PublicDiscriminatorProperty ? Public : Internal;
                setterModifiers = Configuration.PublicDiscriminatorProperty ? Internal | Protected : null;
            }
            else
            {
                fieldModifiers = propertyIsLiteralType ? Internal : Public;
            }
            if (propertyIsReadOnly)
                fieldModifiers |= ReadOnly;

            CodeWriterDeclaration declaration = new CodeWriterDeclaration(fieldName);
            declaration.SetActualName(fieldName);
            return new FieldDeclaration(
                $"{inputModelProperty.Language.Default.Description}",
                fieldModifiers,
                fieldType,
                declaration,
                GetPropertyDefaultValue(fieldType, inputModelProperty),
                inputModelProperty.IsRequired,
                IsField: false,
                WriteAsProperty: true,
                SetterModifiers: setterModifiers);
        }

        private static FieldDeclaration CreateFieldFromExisting(ISymbol existingMember, CSharpType originalType, Property inputModelProperty, TypeFactory typeFactory)
        {
            var existingMemberTypeSymbol = existingMember switch
            {
                IPropertySymbol propertySymbol => (INamedTypeSymbol)propertySymbol.Type,
                IFieldSymbol propertySymbol => (INamedTypeSymbol)propertySymbol.Type,
                _ => throw new NotSupportedException($"'{existingMember.ContainingType.Name}.{existingMember.Name}' must be either field or property.")
            };

            // Changing of model types is not supported
            var fieldType = originalType.IsFrameworkType ? existingMemberTypeSymbol.GetCSharpType() : originalType;

            var fieldModifiers = existingMember.DeclaredAccessibility switch
            {
                Accessibility.Public => Public,
                Accessibility.Internal => Internal,
                Accessibility.Private => Private,
                _ => throw new ArgumentOutOfRangeException()
            };

            var writeAsProperty = existingMember is IPropertySymbol;
            CodeWriterDeclaration declaration = new CodeWriterDeclaration(existingMember.Name);
            declaration.SetActualName(existingMember.Name);

            return new FieldDeclaration($"Must be removed by post-generation processing,", fieldModifiers, fieldType, declaration, GetPropertyDefaultValue(originalType, inputModelProperty), inputModelProperty.IsRequired, existingMember is IFieldSymbol, writeAsProperty);
        }

        private static CSharpType GetPropertyDefaultType(SchemaTypeUsage usage, Property property, TypeFactory typeFactory)
        {
            var valueType = typeFactory.CreateType(property.Schema, property.IsNullable, property.Schema is AnyObjectSchema ? property.Extensions?.Format : property.Schema.Extensions?.Format, property: property);

            if (!usage.HasFlag(SchemaTypeUsage.Input) ||
                property.IsReadOnly)
            {
                valueType = TypeFactory.GetOutputType(valueType);
            }

            if (valueType.IsValueType && !property.IsRequired)
            {
                valueType = valueType.WithNullable(true);
            }

            return valueType;
        }

        private static FormattableString? GetPropertyDefaultValue(CSharpType propertyType, Property inputModelProperty)
        {
            if (TypeFactory.IsCollectionType(propertyType))
            {
                if (TypeFactory.IsReadOnlyList(propertyType))
                {
                    return $"{typeof(Array)}.Empty<{propertyType.Arguments[0]}>()";
                }
                if (TypeFactory.IsReadOnlyDictionary(propertyType))
                {
                    return $"new {new CSharpType(typeof(ReadOnlyDictionary<,>), propertyType.Arguments)}(new {new CSharpType(typeof(Dictionary<,>), propertyType.Arguments)}(0))";
                }
                if (!inputModelProperty.IsRequired)
                {
                    return Constant.NewInstanceOf(TypeFactory.GetPropertyImplementationType(propertyType)).GetConstantFormattable();
                }
            }
            return null;
        }
    }
}
