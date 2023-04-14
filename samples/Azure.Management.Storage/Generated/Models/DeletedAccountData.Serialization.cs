// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.Management.Storage
{
    public partial class DeletedAccountData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DeletedAccountData DeserializeDeletedAccountData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> storageAccountResourceId = default;
            Optional<AzureLocation> location = default;
            Optional<string> restoreReference = default;
            Optional<string> creationTime = default;
            Optional<string> deletionTime = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("storageAccountResourceId"u8))
                        {
                            storageAccountResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("location"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            location = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("restoreReference"u8))
                        {
                            restoreReference = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            creationTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deletionTime"u8))
                        {
                            deletionTime = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DeletedAccountData(id, name, type, systemData.Value, storageAccountResourceId.Value, Optional.ToNullable(location), restoreReference.Value, creationTime.Value, deletionTime.Value);
        }
    }
}
