// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtDiscriminator.Models
{
    internal partial class UnknownDeliveryRuleCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownDeliveryRuleCondition DeserializeUnknownDeliveryRuleCondition(JsonElement element)
        {
            MatchVariable name = "Unknown";
            Optional<string> foo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = new MatchVariable(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("foo"))
                {
                    foo = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownDeliveryRuleCondition(name, foo.Value);
        }
    }
}
