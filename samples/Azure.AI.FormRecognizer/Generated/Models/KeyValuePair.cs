// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Information about the extracted key-value pair. </summary>
    public partial class KeyValuePair
    {
        /// <summary> Initializes a new instance of KeyValuePair. </summary>
        /// <param name="key"> Information about the extracted key in a key-value pair. </param>
        /// <param name="value"> Information about the extracted value in a key-value pair. </param>
        /// <param name="confidence"> Confidence value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public KeyValuePair(KeyValueElement key, KeyValueElement value, float confidence)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            Key = key;
            Value = value;
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of KeyValuePair. </summary>
        /// <param name="label"> A user defined label for the key/value pair entry. </param>
        /// <param name="key"> Information about the extracted key in a key-value pair. </param>
        /// <param name="value"> Information about the extracted value in a key-value pair. </param>
        /// <param name="confidence"> Confidence value. </param>
        internal KeyValuePair(string label, KeyValueElement key, KeyValueElement value, float confidence)
        {
            Label = label;
            Key = key;
            Value = value;
            Confidence = confidence;
        }

        /// <summary> A user defined label for the key/value pair entry. </summary>
        public string Label { get; }
        /// <summary> Information about the extracted key in a key-value pair. </summary>
        public KeyValueElement Key { get; }
        /// <summary> Information about the extracted value in a key-value pair. </summary>
        public KeyValueElement Value { get; }
        /// <summary> Confidence value. </summary>
        public float Confidence { get; }
    }
}
