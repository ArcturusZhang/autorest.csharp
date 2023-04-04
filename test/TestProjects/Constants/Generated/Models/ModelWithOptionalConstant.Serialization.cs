// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Constants.Models
{
    public partial class ModelWithOptionalConstant : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OptionalStringConstant))
            {
                writer.WritePropertyName("optionalStringConstant"u8);
                writer.WriteStringValue(OptionalStringConstant.Value.ToString());
            }
            if (Optional.IsDefined(OptionalIntConstant))
            {
                writer.WritePropertyName("optionalIntConstant"u8);
                writer.WriteNumberValue(OptionalIntConstant.Value.ToSerialInt32());
            }
            if (Optional.IsDefined(OptionalBooleanConstant))
            {
                writer.WritePropertyName("optionalBooleanConstant"u8);
                writer.WriteBooleanValue(OptionalBooleanConstant.Value);
            }
            if (Optional.IsDefined(OptionalFloatConstant))
            {
                writer.WritePropertyName("optionalFloatConstant"u8);
                writer.WriteNumberValue(OptionalFloatConstant.Value.ToSerialSingle());
            }
            writer.WriteEndObject();
        }

        internal static ModelWithOptionalConstant DeserializeModelWithOptionalConstant(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StringConstant> optionalStringConstant = default;
            Optional<IntConstant> optionalIntConstant = default;
            Optional<bool> optionalBooleanConstant = default;
            Optional<FloatConstant> optionalFloatConstant = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("optionalStringConstant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    optionalStringConstant = new StringConstant(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("optionalIntConstant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    optionalIntConstant = new IntConstant(property.Value.GetInt32());
                    continue;
                }
                if (property.NameEquals("optionalBooleanConstant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    optionalBooleanConstant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("optionalFloatConstant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    optionalFloatConstant = new FloatConstant(property.Value.GetSingle());
                    continue;
                }
            }
            return new ModelWithOptionalConstant(Optional.ToNullable(optionalStringConstant), Optional.ToNullable(optionalIntConstant), Optional.ToNullable(optionalBooleanConstant), Optional.ToNullable(optionalFloatConstant));
        }
    }
}
