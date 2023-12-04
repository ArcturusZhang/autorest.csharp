// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
    public partial class DocumentStatistics
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

        /// <summary> Initializes a new instance of <see cref="DocumentStatistics"/>. </summary>
        /// <param name="charactersCount"> Number of text elements recognized in the document. </param>
        /// <param name="transactionsCount"> Number of transactions for the document. </param>
        internal DocumentStatistics(int charactersCount, int transactionsCount)
        {
            CharactersCount = charactersCount;
            TransactionsCount = transactionsCount;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentStatistics"/>. </summary>
        /// <param name="charactersCount"> Number of text elements recognized in the document. </param>
        /// <param name="transactionsCount"> Number of transactions for the document. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentStatistics(int charactersCount, int transactionsCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CharactersCount = charactersCount;
            TransactionsCount = transactionsCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentStatistics"/> for deserialization. </summary>
        internal DocumentStatistics()
        {
        }

        /// <summary> Number of text elements recognized in the document. </summary>
        public int CharactersCount { get; }
        /// <summary> Number of transactions for the document. </summary>
        public int TransactionsCount { get; }
    }
}
