// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> A set of extracted fields corresponding to the input document. </summary>
    public partial class DocumentResult
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

        /// <summary> Initializes a new instance of <see cref="DocumentResult"/>. </summary>
        /// <param name="docType"> Document type. </param>
        /// <param name="pageRange"> First and last page number where the document is found. </param>
        /// <param name="fields"> Dictionary of named field values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="docType"/>, <paramref name="pageRange"/> or <paramref name="fields"/> is null. </exception>
        internal DocumentResult(string docType, IEnumerable<int> pageRange, IReadOnlyDictionary<string, FieldValue> fields)
        {
            Argument.AssertNotNull(docType, nameof(docType));
            Argument.AssertNotNull(pageRange, nameof(pageRange));
            Argument.AssertNotNull(fields, nameof(fields));

            DocType = docType;
            PageRange = pageRange.ToList();
            Fields = fields;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentResult"/>. </summary>
        /// <param name="docType"> Document type. </param>
        /// <param name="pageRange"> First and last page number where the document is found. </param>
        /// <param name="fields"> Dictionary of named field values. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentResult(string docType, IReadOnlyList<int> pageRange, IReadOnlyDictionary<string, FieldValue> fields, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DocType = docType;
            PageRange = pageRange;
            Fields = fields;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentResult"/> for deserialization. </summary>
        internal DocumentResult()
        {
        }

        /// <summary> Document type. </summary>
        public string DocType { get; }
        /// <summary> First and last page number where the document is found. </summary>
        public IReadOnlyList<int> PageRange { get; }
        /// <summary> Dictionary of named field values. </summary>
        public IReadOnlyDictionary<string, FieldValue> Fields { get; }
    }
}
