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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ProtectedAppendWritesHistory : IUtf8JsonSerializable, IJsonModel<ProtectedAppendWritesHistory>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProtectedAppendWritesHistory>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProtectedAppendWritesHistory>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectedAppendWritesHistory>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ProtectedAppendWritesHistory)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AllowProtectedAppendWritesAll))
            {
                writer.WritePropertyName("allowProtectedAppendWritesAll"u8);
                writer.WriteBooleanValue(AllowProtectedAppendWritesAll.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
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

        ProtectedAppendWritesHistory IJsonModel<ProtectedAppendWritesHistory>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectedAppendWritesHistory>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ProtectedAppendWritesHistory)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProtectedAppendWritesHistory(document.RootElement, options);
        }

        internal static ProtectedAppendWritesHistory DeserializeProtectedAppendWritesHistory(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> allowProtectedAppendWritesAll = default;
            Optional<DateTimeOffset> timestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowProtectedAppendWritesAll"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowProtectedAppendWritesAll = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProtectedAppendWritesHistory(Optional.ToNullable(allowProtectedAppendWritesAll), Optional.ToNullable(timestamp), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProtectedAppendWritesHistory>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectedAppendWritesHistory>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ProtectedAppendWritesHistory)} does not support '{options.Format}' format.");
            }
        }

        ProtectedAppendWritesHistory IPersistableModel<ProtectedAppendWritesHistory>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectedAppendWritesHistory>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProtectedAppendWritesHistory(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ProtectedAppendWritesHistory)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProtectedAppendWritesHistory>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
