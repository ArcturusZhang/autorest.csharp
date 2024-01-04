// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace paging.Models
{
    /// <summary> Parameter group. </summary>
    public partial class CustomParameterGroup
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CustomParameterGroup"/>. </summary>
        /// <param name="apiVersion"> Sets the api version to use. </param>
        /// <param name="tenant"> Sets the tenant to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> or <paramref name="tenant"/> is null. </exception>
        public CustomParameterGroup(string apiVersion, string tenant)
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));
            Argument.AssertNotNull(tenant, nameof(tenant));

            ApiVersion = apiVersion;
            Tenant = tenant;
        }

        /// <summary> Initializes a new instance of <see cref="CustomParameterGroup"/>. </summary>
        /// <param name="apiVersion"> Sets the api version to use. </param>
        /// <param name="tenant"> Sets the tenant to use. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomParameterGroup(string apiVersion, string tenant, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApiVersion = apiVersion;
            Tenant = tenant;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CustomParameterGroup"/> for deserialization. </summary>
        internal CustomParameterGroup()
        {
        }

        /// <summary> Sets the api version to use. </summary>
        public string ApiVersion { get; }
        /// <summary> Sets the tenant to use. </summary>
        public string Tenant { get; }
    }
}
