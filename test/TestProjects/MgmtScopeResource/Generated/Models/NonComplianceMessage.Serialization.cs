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

namespace MgmtScopeResource.Models
{
    public partial class NonComplianceMessage : IUtf8JsonSerializable, IJsonModel<NonComplianceMessage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NonComplianceMessage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NonComplianceMessage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NonComplianceMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(NonComplianceMessage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("message"u8);
            writer.WriteStringValue(Message);
            if (Optional.IsDefined(PolicyDefinitionReferenceId))
            {
                writer.WritePropertyName("policyDefinitionReferenceId"u8);
                writer.WriteStringValue(PolicyDefinitionReferenceId);
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

        NonComplianceMessage IJsonModel<NonComplianceMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NonComplianceMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(NonComplianceMessage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNonComplianceMessage(document.RootElement, options);
        }

        internal static NonComplianceMessage DeserializeNonComplianceMessage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string message = default;
            Optional<string> policyDefinitionReferenceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionReferenceId"u8))
                {
                    policyDefinitionReferenceId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NonComplianceMessage(message, policyDefinitionReferenceId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NonComplianceMessage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NonComplianceMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(NonComplianceMessage)} does not support '{options.Format}' format.");
            }
        }

        NonComplianceMessage IPersistableModel<NonComplianceMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NonComplianceMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNonComplianceMessage(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(NonComplianceMessage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NonComplianceMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
