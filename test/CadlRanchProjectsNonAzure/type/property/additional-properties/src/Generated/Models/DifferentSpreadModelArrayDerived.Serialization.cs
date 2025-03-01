// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Scm._Type.Property.AdditionalProperties.Models
{
    public partial class DifferentSpreadModelArrayDerived : IJsonModel<DifferentSpreadModelArrayDerived>
    {
        void IJsonModel<DifferentSpreadModelArrayDerived>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DifferentSpreadModelArrayDerived>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DifferentSpreadModelArrayDerived)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("derivedProp"u8);
            writer.WriteStartArray();
            foreach (var item in DerivedProp)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("knownProp"u8);
            writer.WriteStringValue(KnownProp);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStartArray();
                foreach (var item0 in item.Value)
                {
                    writer.WriteObjectValue(item0, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        DifferentSpreadModelArrayDerived IJsonModel<DifferentSpreadModelArrayDerived>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DifferentSpreadModelArrayDerived>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DifferentSpreadModelArrayDerived)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDifferentSpreadModelArrayDerived(document.RootElement, options);
        }

        internal static DifferentSpreadModelArrayDerived DeserializeDifferentSpreadModelArrayDerived(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ModelForRecord> derivedProp = default;
            string knownProp = default;
            IDictionary<string, IList<ModelForRecord>> additionalProperties = default;
            Dictionary<string, IList<ModelForRecord>> additionalPropertiesDictionary = new Dictionary<string, IList<ModelForRecord>>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("derivedProp"u8))
                {
                    List<ModelForRecord> array = new List<ModelForRecord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelForRecord.DeserializeModelForRecord(item, options));
                    }
                    derivedProp = array;
                    continue;
                }
                if (property.NameEquals("knownProp"u8))
                {
                    knownProp = property.Value.GetString();
                    continue;
                }
                List<ModelForRecord> array0 = new List<ModelForRecord>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    array0.Add(ModelForRecord.DeserializeModelForRecord(item, options));
                }
                additionalPropertiesDictionary.Add(property.Name, array0);
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DifferentSpreadModelArrayDerived(knownProp, additionalProperties, derivedProp);
        }

        BinaryData IPersistableModel<DifferentSpreadModelArrayDerived>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DifferentSpreadModelArrayDerived>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DifferentSpreadModelArrayDerived)} does not support writing '{options.Format}' format.");
            }
        }

        DifferentSpreadModelArrayDerived IPersistableModel<DifferentSpreadModelArrayDerived>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DifferentSpreadModelArrayDerived>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDifferentSpreadModelArrayDerived(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DifferentSpreadModelArrayDerived)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DifferentSpreadModelArrayDerived>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static new DifferentSpreadModelArrayDerived FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDifferentSpreadModelArrayDerived(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
