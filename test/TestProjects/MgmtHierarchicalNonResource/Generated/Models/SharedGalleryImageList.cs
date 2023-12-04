// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace MgmtHierarchicalNonResource.Models
{
    /// <summary> The List Shared Gallery Images operation response. </summary>
    internal partial class SharedGalleryImageList
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

        /// <summary> Initializes a new instance of <see cref="SharedGalleryImageList"/>. </summary>
        /// <param name="value"> A list of shared gallery images. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SharedGalleryImageList(IEnumerable<SharedGalleryImage> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SharedGalleryImageList"/>. </summary>
        /// <param name="value"> A list of shared gallery images. </param>
        /// <param name="nextLink"> The uri to fetch the next page of shared gallery images. Call ListNext() with this to fetch the next page of shared gallery images. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedGalleryImageList(IReadOnlyList<SharedGalleryImage> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SharedGalleryImageList"/> for deserialization. </summary>
        internal SharedGalleryImageList()
        {
        }

        /// <summary> A list of shared gallery images. </summary>
        public IReadOnlyList<SharedGalleryImage> Value { get; }
        /// <summary> The uri to fetch the next page of shared gallery images. Call ListNext() with this to fetch the next page of shared gallery images. </summary>
        public string NextLink { get; }
    }
}
