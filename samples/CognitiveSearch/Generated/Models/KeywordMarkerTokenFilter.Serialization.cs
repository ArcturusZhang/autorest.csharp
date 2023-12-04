// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class KeywordMarkerTokenFilter : IUtf8JsonSerializable, IJsonModel<KeywordMarkerTokenFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KeywordMarkerTokenFilter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KeywordMarkerTokenFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeywordMarkerTokenFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(KeywordMarkerTokenFilter)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keywords"u8);
            writer.WriteStartArray();
            foreach (var item in Keywords)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(IgnoreCase))
            {
                writer.WritePropertyName("ignoreCase"u8);
                writer.WriteBooleanValue(IgnoreCase.Value);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        KeywordMarkerTokenFilter IJsonModel<KeywordMarkerTokenFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeywordMarkerTokenFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(KeywordMarkerTokenFilter)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeywordMarkerTokenFilter(document.RootElement, options);
        }

        internal static KeywordMarkerTokenFilter DeserializeKeywordMarkerTokenFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> keywords = default;
            Optional<bool> ignoreCase = default;
            string odataType = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keywords"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    keywords = array;
                    continue;
                }
                if (property.NameEquals("ignoreCase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreCase = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KeywordMarkerTokenFilter(odataType, name, serializedAdditionalRawData, keywords, Optional.ToNullable(ignoreCase));
        }

        BinaryData IPersistableModel<KeywordMarkerTokenFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeywordMarkerTokenFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(KeywordMarkerTokenFilter)} does not support '{options.Format}' format.");
            }
        }

        KeywordMarkerTokenFilter IPersistableModel<KeywordMarkerTokenFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeywordMarkerTokenFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKeywordMarkerTokenFilter(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(KeywordMarkerTokenFilter)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KeywordMarkerTokenFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
