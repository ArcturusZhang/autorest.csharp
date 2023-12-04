// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace _Specs_.Azure.ClientGenerator.Core.Access.Models
{
    /// <summary>
    /// Used in internal operations, should be generated but not exported.
    /// Please note <see cref="AbstractModel"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="RealModel"/>.
    /// </summary>
    internal abstract partial class AbstractModel
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AbstractModel"/>. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        protected AbstractModel(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            _serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="AbstractModel"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="name"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AbstractModel(string kind, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AbstractModel"/> for deserialization. </summary>
        internal AbstractModel()
        {
        }

        /// <summary> Discriminator. </summary>
        internal string Kind { get; set; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
    }
}
