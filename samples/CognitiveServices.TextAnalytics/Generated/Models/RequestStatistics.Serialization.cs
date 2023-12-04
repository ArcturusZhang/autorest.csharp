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

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class RequestStatistics : IUtf8JsonSerializable, IJsonModel<RequestStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RequestStatistics>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RequestStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RequestStatistics)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("documentsCount"u8);
            writer.WriteNumberValue(DocumentsCount);
            writer.WritePropertyName("validDocumentsCount"u8);
            writer.WriteNumberValue(ValidDocumentsCount);
            writer.WritePropertyName("erroneousDocumentsCount"u8);
            writer.WriteNumberValue(ErroneousDocumentsCount);
            writer.WritePropertyName("transactionsCount"u8);
            writer.WriteNumberValue(TransactionsCount);
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

        RequestStatistics IJsonModel<RequestStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RequestStatistics)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRequestStatistics(document.RootElement, options);
        }

        internal static RequestStatistics DeserializeRequestStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int documentsCount = default;
            int validDocumentsCount = default;
            int erroneousDocumentsCount = default;
            long transactionsCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documentsCount"u8))
                {
                    documentsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("validDocumentsCount"u8))
                {
                    validDocumentsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("erroneousDocumentsCount"u8))
                {
                    erroneousDocumentsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("transactionsCount"u8))
                {
                    transactionsCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RequestStatistics(documentsCount, validDocumentsCount, erroneousDocumentsCount, transactionsCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RequestStatistics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RequestStatistics)} does not support '{options.Format}' format.");
            }
        }

        RequestStatistics IPersistableModel<RequestStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRequestStatistics(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RequestStatistics)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RequestStatistics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
