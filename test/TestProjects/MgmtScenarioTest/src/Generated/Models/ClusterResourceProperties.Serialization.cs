// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtScenarioTest.Models
{
    public partial class ClusterResourceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile");
                writer.WriteObjectValue(NetworkProfile);
            }
            writer.WriteEndObject();
        }

        internal static ClusterResourceProperties DeserializeClusterResourceProperties(JsonElement element)
        {
            Optional<ProvisioningState> provisioningState = default;
            Optional<NetworkProfile> networkProfile = default;
            Optional<int> version = default;
            Optional<string> serviceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkProfile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    networkProfile = NetworkProfile.DeserializeNetworkProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("serviceId"))
                {
                    serviceId = property.Value.GetString();
                    continue;
                }
            }
            return new ClusterResourceProperties(Optional.ToNullable(provisioningState), networkProfile.Value, Optional.ToNullable(version), serviceId.Value);
        }
    }
}
