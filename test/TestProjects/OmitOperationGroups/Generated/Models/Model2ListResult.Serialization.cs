// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using OmitOperationGroups;

namespace OmitOperationGroups.Models
{
    internal partial class Model2ListResult
    {
        internal static Model2ListResult DeserializeModel2ListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<Model2Data>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Model2Data> array = new List<Model2Data>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Model2Data.DeserializeModel2Data(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new Model2ListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
