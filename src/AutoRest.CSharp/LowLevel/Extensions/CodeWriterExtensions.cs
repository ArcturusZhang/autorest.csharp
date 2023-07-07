﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Xml;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Common.Input.Examples;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Output.Samples.Models;
using AutoRest.CSharp.Utilities;
using Azure;
using Azure.Core;

namespace AutoRest.CSharp.LowLevel.Generation.Extensions
{
    internal static class CodeWriterExtensions
    {
        /// <summary>
        /// Write an ExampleValue, using the given type as a hint.
        /// If the type is not provided, a type will be created from TypeFactory instead
        /// In a case that a property's type is replaced, we will have to provide the actual type otherwise the type from TypeFactory will always be the one that is replaced.
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="exampleValue"></param>
        /// <param name="type"></param>
        /// <param name="includeCollectionInitialization"></param>
        /// <returns></returns>
        public static CodeWriter AppendExampleValue(this CodeWriter writer, InputExampleValue exampleValue, CSharpType type, bool includeCollectionInitialization = true)
        {
            return type.IsFrameworkType ?
                writer.AppendFrameworkTypeValue(type, exampleValue, includeCollectionInitialization) :
                writer.AppendTypeProviderValue(type, exampleValue);
        }

        public static CodeWriter AppendExampleParameterValue(this CodeWriter writer, Parameter parameter, ExampleParameterValue exampleParameterValue)
        {
            // for optional parameter, we write the parameter name here
            if (parameter.DefaultValue != null)
                writer.Append($"{parameter.Name}: ");

            return writer.AppendExampleParameterValue(exampleParameterValue);
        }

        public static CodeWriter AppendExampleParameterValue(this CodeWriter writer, ExampleParameterValue exampleParameterValue)
        {
            if (exampleParameterValue.Value != null)
                return writer.AppendExampleValue(exampleParameterValue.Value, exampleParameterValue.Type);
            else
                return writer.Append(exampleParameterValue.Expression!);
        }

        private static CodeWriter AppendFrameworkTypeValue(this CodeWriter writer, CSharpType type, InputExampleValue exampleValue, bool includeCollectionInitialization = true)
        {
            if (TypeFactory.IsList(type))
                return writer.AppendListValue(type.Arguments.Single(), exampleValue, includeCollectionInitialization);

            if (TypeFactory.IsDictionary(type))
                return writer.AppendDictionaryValue(type, exampleValue, includeCollectionInitialization);

            if (type.FrameworkType == typeof(BinaryData))
                return writer.AppendBinaryData(exampleValue);

            if (type.FrameworkType == typeof(RequestContent))
                return writer.AppendRequestContent(exampleValue);

            //if (exampleValue.Schema is ObjectSchema objectSchema)
            //    return writer.AppendComplexFrameworkTypeValue(objectSchema, type.FrameworkType, exampleValue);

            return writer.AppendRawValue(exampleValue.RawValue, type.FrameworkType, exampleValue.Type);
        }

        private static CodeWriter AppendRequestContent(this CodeWriter writer, InputExampleValue value)
        {
            return writer.Append($"{typeof(RequestContent)}.Create(")
                .AppendAnonymousObject(value)
                .AppendRaw(")");
        }

        private static CodeWriter AppendListValue(this CodeWriter writer, CSharpType elementType, InputExampleValue exampleValue, bool includeInitialization = true)
        {
            // the collections in our generated SDK could never be assigned to, therefore if we have null value here, we can only assign an empty collection
            var elements = exampleValue.Elements ?? Enumerable.Empty<InputExampleValue>();
            var initialization = includeInitialization ? (FormattableString)$"new {elementType}[]" : (FormattableString)$"";
            using (writer.Scope(initialization, newLine: false))
            {
                foreach (var itemValue in elements)
                {
                    // TODO -- bad formatting will happen in collection initializer because roslyn formatter ignores things in these places: https://github.com/dotnet/roslyn/issues/8269
                    writer.AppendExampleValue(itemValue, elementType);
                    if (elementType.IsFrameworkType)
                        writer.AppendRaw(",");
                    else
                        writer.LineRaw(",");
                }
                writer.RemoveTrailingComma();
                writer.Line();
            }
            return writer;
        }

        private static CodeWriter AppendDictionaryValue(this CodeWriter writer, CSharpType dictionaryType, InputExampleValue exampleValue, bool includeInitialization = true)
        {
            // the collections in our generated SDK could never be assigned to, therefore if we have null value here, we can only assign an empty collection
            var keyValues = exampleValue.Properties ?? new Dictionary<string, InputExampleValue>();
            // since this is a dictionary, we take the first generic argument as the key type
            // this is important because in our SDK, the key of a dictionary is not always a string. It could be a string-like type, for instance, a ResourceIdentifier
            var keyType = dictionaryType.Arguments[0];
            // the second as the value type
            var valueType = dictionaryType.Arguments[1];
            var initialization = includeInitialization ? (FormattableString)$"new {TypeFactory.GetImplementationType(dictionaryType)}()" : (FormattableString)$"";
            using (writer.Scope(initialization, newLine: false))
            {
                foreach ((var key, var value) in keyValues)
                {
                    // write key
                    writer.AppendRaw("[");
                    writer.AppendExampleValue(InputExampleValue.FromRawValue(((InputDictionaryType)exampleValue.Type).KeyType, key), keyType);
                    writer.AppendRaw("] = ");
                    writer.AppendExampleValue(value, valueType);
                    writer.LineRaw(", ");
                }
            }
            return writer;
        }

        private static CodeWriter AppendBinaryData(this CodeWriter writer, InputExampleValue exampleValue)
        {
            // determine which method on BinaryData we want to use to serialize this BinaryData
            string method = exampleValue.RawValue != null && exampleValue.RawValue is string ? "FromString" : "FromObjectAsJson";
            writer.Append($"{typeof(BinaryData)}.{method}(");
            writer.AppendAnonymousObject(exampleValue);
            return writer.AppendRaw(")");
        }

        private static CodeWriter AppendAnonymousObject(this CodeWriter writer, InputExampleValue exampleValue)
        {
            // check if this is simple type
            if (exampleValue.RawValue != null)
            {
                return writer.AppendRawValue(exampleValue.RawValue, exampleValue.RawValue.GetType(), exampleValue.Type);
            }
            // check if this is an array
            if (exampleValue.Elements != null && exampleValue.Elements.Any())
            {
                return writer.AppendListValue(typeof(object), exampleValue);
            }
            // fallback to complex object
            if (exampleValue.Properties == null)
            {
                writer.LineRaw("null");
            }
            else if (exampleValue.Properties.Any())
            {
                using (writer.Scope($"new {typeof(Dictionary<string, object>)}()", newLine: false))
                {
                    foreach ((var key, var value) in exampleValue.Properties)
                    {
                        writer.Append($"[{key:L}] = ")
                            .AppendAnonymousObject(value)
                            .AppendRaw(",");
                    }
                }
            }
            else
            {
                writer.Append($"new {typeof(Dictionary<string, object>)}()");
            }

            return writer;
        }

        private static CodeWriter AppendRawValue(this CodeWriter writer, object? rawValue, Type type, InputType? inputType = null) => rawValue switch
        {
            string str => writer.AppendStringValue(type, str, inputType),
            int or float or double or decimal or bool => writer.Literal(rawValue),
            null => writer.AppendRaw("null"),
            _ => writer.AppendRaw(rawValue.ToString()!)
        };

        private static CodeWriter AppendStringValue(this CodeWriter writer, Type type, string value, InputType? inputType = null) => type switch
        {
            _ when inputType is InputPrimitiveType { IsNumber: true } => writer.Literal(value),
            _ when inputType is InputPrimitiveType { Kind: InputTypeKind.String } => writer.Literal(value),
            _ when inputType is InputPrimitiveType { Kind: InputTypeKind.DurationISO8601 } => writer.Append($"{typeof(XmlConvert)}.ToTimeSpan({value:L})"),
            _ when _primitiveTypes.Contains(type) => writer.AppendRaw(value),
            _ when _newInstanceInitializedTypes.Contains(type) => writer.Append($"new {type}({value:L})"),
            _ when _parsableInitializedTypes.Contains(type) => writer.Append($"{type}.Parse({value:L})"),
            _ when type == typeof(byte[]) => writer.Append($"{typeof(Convert)}.FromBase64String({value:L})"),
            _ => writer.Literal(value),
        };

        private static bool IsStringLikeType(CSharpType type) => type.IsFrameworkType && (_newInstanceInitializedTypes.Contains(type.FrameworkType) || _parsableInitializedTypes.Contains(type.FrameworkType));

        private static readonly HashSet<Type> _primitiveTypes = new()
        {
            typeof(bool), typeof(bool?),
            typeof(int), typeof(int?),
            typeof(long), typeof(long?),
            typeof(float), typeof(float?),
            typeof(double), typeof(double?),
            typeof(decimal), typeof(decimal?)
        };

        private static readonly HashSet<Type> _newInstanceInitializedTypes = new()
        {
            typeof(ResourceIdentifier),
            typeof(ResourceType),
            typeof(Uri),
            typeof(AzureLocation), typeof(AzureLocation?),
            typeof(RequestMethod), typeof(RequestMethod?),
            typeof(ContentType), typeof(ContentType?),
            typeof(ETag), typeof(ETag?)
        };

        private static readonly HashSet<Type> _parsableInitializedTypes = new()
        {
            typeof(DateTimeOffset),
            typeof(Guid), typeof(Guid?),
            typeof(TimeSpan), typeof(TimeSpan?),
            typeof(IPAddress)
        };

        private static CodeWriter AppendTypeProviderValue(this CodeWriter writer, CSharpType type, InputExampleValue exampleValue)
        {
            switch (type.Implementation)
            {
                case ObjectType objectType:
                    return writer.AppendObjectTypeValue(objectType, exampleValue.Properties);
                case EnumType enumType:
                    return writer.AppendEnumTypeValue(enumType, exampleValue.RawValue!);
            }
            return writer.AppendRaw("default");
        }

        private static ObjectType GetActualImplementation(ObjectType objectType, IReadOnlyDictionary<string, InputExampleValue> valueDict)
        {
            var discriminator = objectType.Discriminator;
            // check if this has a discriminator
            if (discriminator == null || !discriminator.HasDescendants)
                return objectType;
            var discriminatorPropertyName = discriminator.SerializedName;
            // get value of this in the valueDict and we should always has a discriminator value in the example
            if (!valueDict.TryGetValue(discriminatorPropertyName, out var exampleValue) || exampleValue.RawValue == null)
            {
                throw new InvalidOperationException($"Attempting to get the discriminator value for property `{discriminatorPropertyName}` on object type {objectType.Type.Name} but got none or non-primitive type");
            }
            // the discriminator should always be a primitive type
            var actualDiscriminatorValue = exampleValue.RawValue;
            var implementation = discriminator.Implementations.FirstOrDefault(info => info.Key.Equals(actualDiscriminatorValue));
            if (implementation == null)
                throw new InvalidOperationException($"Cannot find an implementation corresponding to the discriminator value {actualDiscriminatorValue} for object model type {objectType.Type.Name}");

            return (ObjectType)implementation.Type.Implementation;
        }

        private static CodeWriter AppendObjectTypeValue(this CodeWriter writer, ObjectType objectType, IReadOnlyDictionary<string, InputExampleValue>? valueDict)
        {
            if (valueDict == null)
            {
                writer.AppendRaw("null");
                return writer;
            }
            // need to get the actual ObjectType if this type has a discrinimator
            objectType = GetActualImplementation(objectType, valueDict);
            // get all the properties on this type, including the properties from its base type
            var properties = new HashSet<ObjectTypeProperty>(objectType.EnumerateHierarchy().SelectMany(objectType => objectType.Properties));
            var constructor = objectType.InitializationConstructor;
            writer.Append($"new {objectType.Type}(");
            // build a map from parameter name to property
            var propertyDict = properties.ToDictionary(
                property => property.Declaration.Name.ToVariableName(), property => property);
            // find the corresponding properties in the parameters
            foreach (var parameter in constructor.Signature.Parameters)
            {
                // try every property, convert them to variable name and see if there are some of them matching
                var property = propertyDict[parameter.Name];
                InputExampleValue? exampleValue;
                if (!valueDict.TryGetValue(property.InputModelProperty!.SerializedName, out exampleValue))
                {
                    // we could only stand the case that the missing property here is a collection, in this case, we pass an empty collection
                    if (TypeFactory.IsCollectionType(property.Declaration.Type))
                    {
                        exampleValue = InputExampleValue.FromList(property.InputModelProperty!.Type, Array.Empty<InputExampleValue>());
                    }
                    else if (IsStringLikeType(property.Declaration.Type))
                    {
                        // this is a patch that some parameter is not marked as required, but in our generated code, it inherits from ResourceData, in which location is in the constructor and our code will recognize it as required
                        exampleValue = InputExampleValue.FromRawValue(InputPrimitiveType.String, "placeholder");
                    }
                    else
                        throw new InvalidOperationException($"Example value for required property {property.SchemaProperty!.SerializedName} in class {objectType.Type.Name} is not found");
                }
                properties.Remove(property);
                writer.AppendExampleValue(exampleValue, type: property.Declaration.Type).AppendRaw(",");
            }
            writer.RemoveTrailingComma();
            writer.AppendRaw(")");
            var propertiesToWrite = GetPropertiesToWrite(objectType, properties, valueDict);
            if (propertiesToWrite.Count > 0) // only write the property initializers when there are properties to write
            {
                using (writer.Scope($"", newLine: false))
                {
                    foreach ((var propertyName, (var propertyType, var exampleValue)) in propertiesToWrite)
                    {
                        writer.Append($"{propertyName} = ");
                        // we need to pass in the current type of this property to make sure its initialization is correct
                        writer.AppendExampleValue(exampleValue, type: propertyType, includeCollectionInitialization: false);
                        writer.LineRaw(",");
                    }
                }
            }
            return writer;
        }

        private static Dictionary<string, (CSharpType PropertyType, InputExampleValue ExampleValue)> GetPropertiesToWrite(ObjectType objectType, IEnumerable<ObjectTypeProperty> properties, IReadOnlyDictionary<string, InputExampleValue> valueDict)
        {
            var propertiesToWrite = new Dictionary<string, (CSharpType PropertyType, InputExampleValue ExampleValue)>();
            foreach (var property in properties)
            {
                var propertyToDeal = property;
                var inputModelProperty = propertyToDeal.InputModelProperty;
                if (inputModelProperty == null)
                    continue; // now we explicitly ignore all the AdditionalProperties

                if (!valueDict.TryGetValue(inputModelProperty.SerializedName, out var exampleValue))
                    continue; // skip the property that does not have a value

                // check if this property is safe-flattened
                var flattenedProperty = propertyToDeal.FlattenedProperty;
                if (flattenedProperty != null)
                {
                    // unwrap the single property object
                    exampleValue = UnwrapExampleValueFromSinglePropertySchema(exampleValue, flattenedProperty);
                    if (exampleValue == null)
                        continue;
                    propertyToDeal = flattenedProperty;
                }

                if (!IsPropertyAssignable(propertyToDeal))
                    continue; // now we explicitly ignore all the AdditionalProperties

                propertiesToWrite.Add(propertyToDeal.Declaration.Name, (propertyToDeal.Declaration.Type, exampleValue));
            }

            return propertiesToWrite;
        }

        private static InputExampleValue? UnwrapExampleValueFromSinglePropertySchema(InputExampleValue exampleValue, FlattenedObjectTypeProperty flattenedProperty)
        {
            var hierarchyStack = flattenedProperty.BuildHierarchyStack();
            // reverse the stack because it is a stack, iterating it will start from the innerest property
            // skip the first because this stack include the property we are handling here right now
            foreach (var property in hierarchyStack.Reverse().Skip(1))
            {
                var schemaProperty = property.SchemaProperty;
                if (schemaProperty == null || exampleValue.Properties == null || !exampleValue.Properties.TryGetValue(schemaProperty.SerializedName, out var inner))
                    return null;
                // get the value of this layer
                exampleValue = inner;
            }
            return exampleValue;
        }

        private static bool IsPropertyAssignable(ObjectTypeProperty property)
            => property.Declaration.Accessibility == "public" && (TypeFactory.IsReadWriteDictionary(property.Declaration.Type) || TypeFactory.IsReadWriteList(property.Declaration.Type) || !property.IsReadOnly);

        private static CodeWriter AppendEnumTypeValue(this CodeWriter writer, EnumType enumType, object value)
        {
            // find value in one of the choices.
            // Here we convert the values to string then compare, because the raw value has the "primitive types are deserialized into strings" issue
            var choice = enumType.Values.FirstOrDefault(c => StringComparer.Ordinal.Equals(value.ToString(), c.Value.Value?.ToString()));
            writer.UseNamespace(enumType.Type.Namespace);
            if (choice != null)
                return writer.Append($"{enumType.Type.Name}.{choice.Declaration.Name}");
            // if we did not find a match, check if this is a SealedChoice, if so, we throw exceptions
            if (!enumType.IsExtensible)
                throw new InvalidOperationException($"Enum value `{value}` in example does not find in type {enumType.Type.Name}");
            var underlyingType = enumType.ValueType.FrameworkType; // the underlying type of an extensible enum should always be a primitive type which is a framework type
            return writer.Append($"new {enumType.Type}(")
                .AppendRawValue(value, underlyingType)
                .AppendRaw(")");
        }
        public static void ConsoleWriteLine(this CodeWriter writer, FormattableString content)
        {
            writer.Line($"{typeof(Console)}.{nameof(Console.WriteLine)}({content});");
        }
    }
}
