// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtExpandResourceTypes.Models
{
    public partial class DnsResourceReferenceResult
    {
        internal static DnsResourceReferenceResult DeserializeDnsResourceReferenceResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DnsResourceReference>> dnsResourceReferences = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("dnsResourceReferences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DnsResourceReference> array = new List<DnsResourceReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DnsResourceReference.DeserializeDnsResourceReference(item));
                            }
                            dnsResourceReferences = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DnsResourceReferenceResult(Optional.ToList(dnsResourceReferences));
        }
    }
}
