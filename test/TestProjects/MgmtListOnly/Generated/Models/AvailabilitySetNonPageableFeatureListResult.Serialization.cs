// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtListOnly.Models
{
    public partial class AvailabilitySetNonPageableFeatureListResult
    {
        internal static AvailabilitySetNonPageableFeatureListResult DeserializeAvailabilitySetNonPageableFeatureListResult(JsonElement element)
        {
            Optional<IReadOnlyList<AvailabilitySetNonPageableFeature>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AvailabilitySetNonPageableFeature> array = new List<AvailabilitySetNonPageableFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailabilitySetNonPageableFeature.DeserializeAvailabilitySetNonPageableFeature(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AvailabilitySetNonPageableFeatureListResult(Optional.ToList(value));
        }
    }
}
