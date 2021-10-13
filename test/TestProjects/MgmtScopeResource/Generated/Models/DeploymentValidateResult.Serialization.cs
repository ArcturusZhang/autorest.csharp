// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtScopeResource.Models
{
    public partial class DeploymentValidateResult
    {
        internal static DeploymentValidateResult DeserializeDeploymentValidateResult(JsonElement element)
        {
            Optional<ErrorResponse> error = default;
            Optional<DeploymentPropertiesExtended> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = ErrorResponse.DeserializeErrorResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = DeploymentPropertiesExtended.DeserializeDeploymentPropertiesExtended(property.Value);
                    continue;
                }
            }
            return new DeploymentValidateResult(error.Value, properties.Value);
        }
    }
}
