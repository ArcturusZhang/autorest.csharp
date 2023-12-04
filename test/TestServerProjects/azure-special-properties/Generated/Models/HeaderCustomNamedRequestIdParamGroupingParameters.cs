// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace azure_special_properties.Models
{
    /// <summary> Parameter group. </summary>
    public partial class HeaderCustomNamedRequestIdParamGroupingParameters
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

        /// <summary> Initializes a new instance of <see cref="HeaderCustomNamedRequestIdParamGroupingParameters"/>. </summary>
        /// <param name="fooClientRequestId"> The fooRequestId. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fooClientRequestId"/> is null. </exception>
        public HeaderCustomNamedRequestIdParamGroupingParameters(string fooClientRequestId)
        {
            Argument.AssertNotNull(fooClientRequestId, nameof(fooClientRequestId));

            FooClientRequestId = fooClientRequestId;
        }

        /// <summary> Initializes a new instance of <see cref="HeaderCustomNamedRequestIdParamGroupingParameters"/>. </summary>
        /// <param name="fooClientRequestId"> The fooRequestId. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HeaderCustomNamedRequestIdParamGroupingParameters(string fooClientRequestId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FooClientRequestId = fooClientRequestId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HeaderCustomNamedRequestIdParamGroupingParameters"/> for deserialization. </summary>
        internal HeaderCustomNamedRequestIdParamGroupingParameters()
        {
        }

        /// <summary> The fooRequestId. </summary>
        public string FooClientRequestId { get; }
    }
}
