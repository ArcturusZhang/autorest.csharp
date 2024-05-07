// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Scm._Type.Property.AdditionalProperties.Models
{
    public partial class SpreadModelRecord : IJsonModel<SpreadModelRecord>
    {
        void IJsonModel<SpreadModelRecord>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpreadModelRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpreadModelRecord)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("knownProp"u8);
            writer.WriteObjectValue(KnownProp, options);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value, options);
            }
            writer.WriteEndObject();
        }

        SpreadModelRecord IJsonModel<SpreadModelRecord>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpreadModelRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpreadModelRecord)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSpreadModelRecord(document.RootElement, options);
        }

        internal static SpreadModelRecord DeserializeSpreadModelRecord(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ModelForRecord knownProp = default;
            IDictionary<string, ModelForRecord> additionalProperties = default;
            Dictionary<string, ModelForRecord> additionalPropertiesDictionary = new Dictionary<string, ModelForRecord>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("knownProp"u8))
                {
                    knownProp = ModelForRecord.DeserializeModelForRecord(property.Value, options);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, ModelForRecord.DeserializeModelForRecord(property.Value, options));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SpreadModelRecord(knownProp, additionalProperties);
        }

        BinaryData IPersistableModel<SpreadModelRecord>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpreadModelRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SpreadModelRecord)} does not support writing '{options.Format}' format.");
            }
        }

        SpreadModelRecord IPersistableModel<SpreadModelRecord>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpreadModelRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSpreadModelRecord(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SpreadModelRecord)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SpreadModelRecord>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static SpreadModelRecord FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSpreadModelRecord(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
