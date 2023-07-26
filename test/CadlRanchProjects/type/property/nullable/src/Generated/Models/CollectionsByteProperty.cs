// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace _Type.Property.Nullable.Models
{
    /// <summary> Model with collection bytes properties. </summary>
    public partial class CollectionsByteProperty
    {
        /// <summary> Initializes a new instance of CollectionsByteProperty. </summary>
        /// <param name="requiredProperty"> Required property. </param>
        /// <param name="nullableProperty"> Property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredProperty"/> is null. </exception>
        public CollectionsByteProperty(string requiredProperty, IEnumerable<BinaryData> nullableProperty)
        {
            Argument.AssertNotNull(requiredProperty, nameof(requiredProperty));

            RequiredProperty = requiredProperty;
            NullableProperty = nullableProperty?.ToList();
        }

        /// <summary> Initializes a new instance of CollectionsByteProperty. </summary>
        /// <param name="requiredProperty"> Required property. </param>
        /// <param name="nullableProperty"> Property. </param>
        internal CollectionsByteProperty(string requiredProperty, IList<BinaryData> nullableProperty)
        {
            RequiredProperty = requiredProperty;
            NullableProperty = nullableProperty;
        }

        /// <summary> Required property. </summary>
        public string RequiredProperty { get; set; }
        /// <summary>
        /// Property
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public IList<BinaryData> NullableProperty { get; set; }
    }
}
