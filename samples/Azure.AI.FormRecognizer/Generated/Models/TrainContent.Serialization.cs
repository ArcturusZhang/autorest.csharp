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

namespace Azure.AI.FormRecognizer.Models
{
    public partial class TrainContent : IUtf8JsonSerializable, IJsonModel<TrainContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrainContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrainContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrainContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(TrainContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source);
            if (Optional.IsDefined(SourceFilter))
            {
                writer.WritePropertyName("sourceFilter"u8);
                writer.WriteObjectValue(SourceFilter);
            }
            if (Optional.IsDefined(UseLabelFile))
            {
                writer.WritePropertyName("useLabelFile"u8);
                writer.WriteBooleanValue(UseLabelFile.Value);
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

        TrainContent IJsonModel<TrainContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrainContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(TrainContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrainContent(document.RootElement, options);
        }

        internal static TrainContent DeserializeTrainContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string source = default;
            Optional<TrainSourceFilter> sourceFilter = default;
            Optional<bool> useLabelFile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceFilter = TrainSourceFilter.DeserializeTrainSourceFilter(property.Value);
                    continue;
                }
                if (property.NameEquals("useLabelFile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useLabelFile = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TrainContent(source, sourceFilter.Value, Optional.ToNullable(useLabelFile), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrainContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrainContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(TrainContent)} does not support '{options.Format}' format.");
            }
        }

        TrainContent IPersistableModel<TrainContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrainContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrainContent(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(TrainContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrainContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
