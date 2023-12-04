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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    public partial class BlobServiceData : IUtf8JsonSerializable, IJsonModel<BlobServiceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlobServiceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BlobServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BlobServiceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Cors))
            {
                writer.WritePropertyName("cors"u8);
                writer.WriteObjectValue(Cors);
            }
            if (Optional.IsDefined(DefaultServiceVersion))
            {
                writer.WritePropertyName("defaultServiceVersion"u8);
                writer.WriteStringValue(DefaultServiceVersion);
            }
            if (Optional.IsDefined(DeleteRetentionPolicy))
            {
                writer.WritePropertyName("deleteRetentionPolicy"u8);
                writer.WriteObjectValue(DeleteRetentionPolicy);
            }
            if (Optional.IsDefined(IsVersioningEnabled))
            {
                writer.WritePropertyName("isVersioningEnabled"u8);
                writer.WriteBooleanValue(IsVersioningEnabled.Value);
            }
            if (Optional.IsDefined(AutomaticSnapshotPolicyEnabled))
            {
                writer.WritePropertyName("automaticSnapshotPolicyEnabled"u8);
                writer.WriteBooleanValue(AutomaticSnapshotPolicyEnabled.Value);
            }
            if (Optional.IsDefined(ChangeFeed))
            {
                writer.WritePropertyName("changeFeed"u8);
                writer.WriteObjectValue(ChangeFeed);
            }
            if (Optional.IsDefined(RestorePolicy))
            {
                writer.WritePropertyName("restorePolicy"u8);
                writer.WriteObjectValue(RestorePolicy);
            }
            if (Optional.IsDefined(ContainerDeleteRetentionPolicy))
            {
                writer.WritePropertyName("containerDeleteRetentionPolicy"u8);
                writer.WriteObjectValue(ContainerDeleteRetentionPolicy);
            }
            if (Optional.IsDefined(LastAccessTimeTrackingPolicy))
            {
                writer.WritePropertyName("lastAccessTimeTrackingPolicy"u8);
                writer.WriteObjectValue(LastAccessTimeTrackingPolicy);
            }
            writer.WriteEndObject();
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

        BlobServiceData IJsonModel<BlobServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BlobServiceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobServiceData(document.RootElement, options);
        }

        internal static BlobServiceData DeserializeBlobServiceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageSku> sku = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<CorsRules> cors = default;
            Optional<string> defaultServiceVersion = default;
            Optional<DeleteRetentionPolicy> deleteRetentionPolicy = default;
            Optional<bool> isVersioningEnabled = default;
            Optional<bool> automaticSnapshotPolicyEnabled = default;
            Optional<ChangeFeed> changeFeed = default;
            Optional<RestorePolicyProperties> restorePolicy = default;
            Optional<DeleteRetentionPolicy> containerDeleteRetentionPolicy = default;
            Optional<LastAccessTimeTrackingPolicy> lastAccessTimeTrackingPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = StorageSku.DeserializeStorageSku(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("cors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cors = CorsRules.DeserializeCorsRules(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultServiceVersion"u8))
                        {
                            defaultServiceVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deleteRetentionPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleteRetentionPolicy = DeleteRetentionPolicy.DeserializeDeleteRetentionPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isVersioningEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isVersioningEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("automaticSnapshotPolicyEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            automaticSnapshotPolicyEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("changeFeed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            changeFeed = ChangeFeed.DeserializeChangeFeed(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("restorePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restorePolicy = RestorePolicyProperties.DeserializeRestorePolicyProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("containerDeleteRetentionPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            containerDeleteRetentionPolicy = DeleteRetentionPolicy.DeserializeDeleteRetentionPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("lastAccessTimeTrackingPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastAccessTimeTrackingPolicy = LastAccessTimeTrackingPolicy.DeserializeLastAccessTimeTrackingPolicy(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BlobServiceData(id, name, type, systemData.Value, sku.Value, cors.Value, defaultServiceVersion.Value, deleteRetentionPolicy.Value, Optional.ToNullable(isVersioningEnabled), Optional.ToNullable(automaticSnapshotPolicyEnabled), changeFeed.Value, restorePolicy.Value, containerDeleteRetentionPolicy.Value, lastAccessTimeTrackingPolicy.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BlobServiceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(BlobServiceData)} does not support '{options.Format}' format.");
            }
        }

        BlobServiceData IPersistableModel<BlobServiceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBlobServiceData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(BlobServiceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BlobServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
