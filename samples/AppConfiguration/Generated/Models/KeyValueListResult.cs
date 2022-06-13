// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace AppConfiguration.Models
{
    /// <summary> The result of a list request. </summary>
    internal partial class KeyValueListResult
    {
        /// <summary> Initializes a new instance of KeyValueListResult. </summary>
        internal KeyValueListResult()
        {
            Items = new ChangeTrackingList<KeyValue>();
        }

        /// <summary> Initializes a new instance of KeyValueListResult. </summary>
        /// <param name="items"> The collection value. </param>
        /// <param name="nextLink"> The URI that can be used to request the next set of paged results. </param>
        internal KeyValueListResult(IReadOnlyList<KeyValue> items, string nextLink)
        {
            Items = items;
            NextLink = nextLink;
        }

        /// <summary> The collection value. </summary>
        public IReadOnlyList<KeyValue> Items { get; }
        /// <summary> The URI that can be used to request the next set of paged results. </summary>
        public string NextLink { get; }
    }
}
