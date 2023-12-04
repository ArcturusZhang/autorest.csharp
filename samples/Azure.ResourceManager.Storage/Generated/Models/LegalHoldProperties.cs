// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The LegalHold property of a blob container. </summary>
    public partial class LegalHoldProperties
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

        /// <summary> Initializes a new instance of <see cref="LegalHoldProperties"/>. </summary>
        internal LegalHoldProperties()
        {
            Tags = new ChangeTrackingList<TagProperty>();
        }

        /// <summary> Initializes a new instance of <see cref="LegalHoldProperties"/>. </summary>
        /// <param name="hasLegalHold"> The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account. </param>
        /// <param name="tags"> The list of LegalHold tags of a blob container. </param>
        /// <param name="protectedAppendWritesHistory"> Protected append blob writes history. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LegalHoldProperties(bool? hasLegalHold, IReadOnlyList<TagProperty> tags, ProtectedAppendWritesHistory protectedAppendWritesHistory, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HasLegalHold = hasLegalHold;
            Tags = tags;
            ProtectedAppendWritesHistory = protectedAppendWritesHistory;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account. </summary>
        public bool? HasLegalHold { get; }
        /// <summary> The list of LegalHold tags of a blob container. </summary>
        public IReadOnlyList<TagProperty> Tags { get; }
        /// <summary> Protected append blob writes history. </summary>
        public ProtectedAppendWritesHistory ProtectedAppendWritesHistory { get; }
    }
}
