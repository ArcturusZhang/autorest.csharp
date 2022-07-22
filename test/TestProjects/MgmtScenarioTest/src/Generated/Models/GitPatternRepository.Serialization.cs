// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtScenarioTest.Models
{
    public partial class GitPatternRepository : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsCollectionDefined(Pattern))
            {
                writer.WritePropertyName("pattern");
                writer.WriteStartArray();
                foreach (var item in Pattern)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("uri");
            writer.WriteStringValue(Uri);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label");
                writer.WriteStringValue(Label);
            }
            if (Optional.IsCollectionDefined(SearchPaths))
            {
                writer.WritePropertyName("searchPaths");
                writer.WriteStartArray();
                foreach (var item in SearchPaths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username");
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(HostKey))
            {
                writer.WritePropertyName("hostKey");
                writer.WriteStringValue(HostKey);
            }
            if (Optional.IsDefined(HostKeyAlgorithm))
            {
                writer.WritePropertyName("hostKeyAlgorithm");
                writer.WriteStringValue(HostKeyAlgorithm);
            }
            if (Optional.IsDefined(PrivateKey))
            {
                writer.WritePropertyName("privateKey");
                writer.WriteStringValue(PrivateKey);
            }
            if (Optional.IsDefined(StrictHostKeyChecking))
            {
                writer.WritePropertyName("strictHostKeyChecking");
                writer.WriteBooleanValue(StrictHostKeyChecking.Value);
            }
            writer.WriteEndObject();
        }

        internal static GitPatternRepository DeserializeGitPatternRepository(JsonElement element)
        {
            string name = default;
            Optional<IList<string>> pattern = default;
            string uri = default;
            Optional<string> label = default;
            Optional<IList<string>> searchPaths = default;
            Optional<string> username = default;
            Optional<string> password = default;
            Optional<string> hostKey = default;
            Optional<string> hostKeyAlgorithm = default;
            Optional<string> privateKey = default;
            Optional<bool> strictHostKeyChecking = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pattern"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    pattern = array;
                    continue;
                }
                if (property.NameEquals("uri"))
                {
                    uri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchPaths"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    searchPaths = array;
                    continue;
                }
                if (property.NameEquals("username"))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostKey"))
                {
                    hostKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostKeyAlgorithm"))
                {
                    hostKeyAlgorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateKey"))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("strictHostKeyChecking"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    strictHostKeyChecking = property.Value.GetBoolean();
                    continue;
                }
            }
            return new GitPatternRepository(name, Optional.ToList(pattern), uri, label.Value, Optional.ToList(searchPaths), username.Value, password.Value, hostKey.Value, hostKeyAlgorithm.Value, privateKey.Value, Optional.ToNullable(strictHostKeyChecking));
        }
    }
}
