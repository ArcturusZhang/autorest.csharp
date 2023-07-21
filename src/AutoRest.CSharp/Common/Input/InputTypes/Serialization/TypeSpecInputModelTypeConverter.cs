﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using NUnit.Framework.Internal;

namespace AutoRest.CSharp.Common.Input
{
    internal sealed class TypeSpecInputModelTypeConverter : JsonConverter<InputModelType>
    {
        private readonly TypeSpecReferenceHandler _referenceHandler;

        public TypeSpecInputModelTypeConverter(TypeSpecReferenceHandler referenceHandler)
        {
            _referenceHandler = referenceHandler;
        }

        public override InputModelType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => ReadModelType(ref reader, options, _referenceHandler.CurrentResolver);

        public override void Write(Utf8JsonWriter writer, InputModelType value, JsonSerializerOptions options)
            => throw new NotSupportedException("Writing not supported");

        private static InputModelType? ReadModelType(ref Utf8JsonReader reader, JsonSerializerOptions options, ReferenceResolver resolver)
            => reader.ReadReferenceAndResolve<InputModelType>(resolver) ?? CreateModelType(ref reader, null, null, options, resolver);

        public static InputModelType CreateModelType(ref Utf8JsonReader reader, string? id, string? name, JsonSerializerOptions options, ReferenceResolver resolver)
        {
            var isFirstProperty = id == null && name == null;
            var properties = new List<InputModelProperty>();
            bool isNullable = false;
            string? ns = null;
            string? accessibility = null;
            string? deprecated = null;
            string? description = null;
            string? usageString = null;
            string? discriminatorPropertyName = null;
            string? discriminatorValue = null;
            bool isConfident = false;
            InputModelType? baseModel = null;
            InputModelType? model = null;
            while (reader.TokenType != JsonTokenType.EndObject)
            {
                var isKnownProperty = reader.TryReadReferenceId(ref isFirstProperty, ref id)
                    || reader.TryReadString(nameof(InputType.Name), ref name)
                    || reader.TryReadBoolean(nameof(InputModelType.IsNullable), ref isNullable)
                    || reader.TryReadString(nameof(InputModelType.Namespace), ref ns)
                    || reader.TryReadString(nameof(InputModelType.Accessibility), ref accessibility)
                    || reader.TryReadString(nameof(InputModelType.Deprecated), ref deprecated)
                    || reader.TryReadString(nameof(InputModelType.Description), ref description)
                    || reader.TryReadString(nameof(InputModelType.Usage), ref usageString)
                    || reader.TryReadString(nameof(InputModelType.DiscriminatorPropertyName), ref discriminatorPropertyName)
                    || reader.TryReadString(nameof(InputModelType.DiscriminatorValue), ref discriminatorValue)
                    || reader.TryReadWithConverter(nameof(InputModelType.BaseModel), options, ref baseModel)
                    || reader.TryReadBoolean(nameof(InputModelType.IsNullable), ref isNullable)
                    || reader.TryReadBoolean(nameof(InputModelType.IsConfident), ref isConfident);

                if (isKnownProperty)
                {
                    continue;
                }

                if (reader.GetString() == nameof(InputModelType.Properties))
                {
                    model = CreateInputModelTypeInstance(id, name, ns, accessibility, deprecated, description, usageString, discriminatorValue, discriminatorPropertyName, baseModel, properties, isConfident, isNullable, resolver);
                    reader.Read();
                    CreateProperties(ref reader, properties, options);
                    if (reader.TokenType != JsonTokenType.EndObject)
                    {
                        throw new JsonException($"{nameof(InputModelType)}.{nameof(InputModelType.Properties)} must be the last defined property.");
                    }
                }
                else
                {
                    reader.SkipProperty();
                }
            }

            return model ?? CreateInputModelTypeInstance(id, name, ns, accessibility, deprecated, description, usageString, discriminatorValue, discriminatorPropertyName, baseModel, properties, isConfident, isNullable, resolver);
        }

        private static InputModelType CreateInputModelTypeInstance(string? id, string? name, string? ns, string? accessibility, string? deprecated, string? description, string? usageString, string? discriminatorValue, string? discriminatorPropertyName, InputModelType? baseModel, List<InputModelProperty> properties, bool isConfident, bool isNullable, ReferenceResolver resolver)
        {
            name = name ?? throw new JsonException("Model must have name");
            InputModelTypeUsage usage = InputModelTypeUsage.None;
            if (usageString != null)
            {
                Enum.TryParse<InputModelTypeUsage>(usageString, ignoreCase: true, out usage);
            }
            var model = new InputModelType(name, ns, accessibility, deprecated, description, usage, properties, baseModel, new List<InputModelType>(), discriminatorValue, discriminatorPropertyName, isConfident, isNullable);
            if (id != null)
            {
                resolver.AddReference(id, model);
            }
            return model;
        }

        private static bool TryReadArrayWithConverter<T>(ref Utf8JsonReader reader, string propertyName, JsonSerializerOptions options, ref ICollection<T> array)
        {
            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            if (reader.GetString() != propertyName)
            {
                return false;
            }

            reader.Read();

            // read the array
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }
            reader.Read(); // get next token

            while (reader.TokenType != JsonTokenType.EndArray)
            {
                var item = reader.ReadWithConverter<T>(options);
                array.Add(item ?? throw new JsonException($"null {nameof(T)} isn't allowed"));
            }

            reader.Read();
            return true;
        }

        private static void CreateProperties(ref Utf8JsonReader reader, ICollection<InputModelProperty> properties, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }
            reader.Read();

            while (reader.TokenType != JsonTokenType.EndArray)
            {
                var property = reader.ReadWithConverter<InputModelProperty>(options);
                properties.Add(property ?? throw new JsonException($"null {nameof(InputModelProperty)} isn't allowed"));
            }
            reader.Read();
        }
    }
}
