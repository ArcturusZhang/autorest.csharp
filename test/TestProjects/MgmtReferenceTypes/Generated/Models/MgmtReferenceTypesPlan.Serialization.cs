// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.ResourceManager.Fake.Models
{
    [JsonConverter(typeof(MgmtReferenceTypesPlanConverter))]
    public partial class MgmtReferenceTypesPlan : IUtf8JsonSerializable, IJsonModel<MgmtReferenceTypesPlan>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MgmtReferenceTypesPlan>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MgmtReferenceTypesPlan>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MgmtReferenceTypesPlan>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MgmtReferenceTypesPlan)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("publisher"u8);
            writer.WriteStringValue(Publisher);
            writer.WritePropertyName("product"u8);
            writer.WriteStringValue(Product);
            if (Optional.IsDefined(PromotionCode))
            {
                writer.WritePropertyName("promotionCode"u8);
                writer.WriteStringValue(PromotionCode);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            writer.WriteEndObject();
        }

        MgmtReferenceTypesPlan IJsonModel<MgmtReferenceTypesPlan>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MgmtReferenceTypesPlan>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MgmtReferenceTypesPlan)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMgmtReferenceTypesPlan(document.RootElement, options);
        }

        internal static MgmtReferenceTypesPlan DeserializeMgmtReferenceTypesPlan(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string publisher = default;
            string product = default;
            Optional<string> promotionCode = default;
            Optional<string> version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisher"u8))
                {
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("product"u8))
                {
                    product = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("promotionCode"u8))
                {
                    promotionCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
            }
            return new MgmtReferenceTypesPlan(name, publisher, product, promotionCode.Value, version.Value);
        }

        BinaryData IPersistableModel<MgmtReferenceTypesPlan>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MgmtReferenceTypesPlan>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(MgmtReferenceTypesPlan)} does not support '{options.Format}' format.");
            }
        }

        MgmtReferenceTypesPlan IPersistableModel<MgmtReferenceTypesPlan>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MgmtReferenceTypesPlan>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMgmtReferenceTypesPlan(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(MgmtReferenceTypesPlan)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MgmtReferenceTypesPlan>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class MgmtReferenceTypesPlanConverter : JsonConverter<MgmtReferenceTypesPlan>
        {
            public override void Write(Utf8JsonWriter writer, MgmtReferenceTypesPlan model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MgmtReferenceTypesPlan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMgmtReferenceTypesPlan(document.RootElement);
            }
        }
    }
}
