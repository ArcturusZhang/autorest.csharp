// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace AppConfiguration.Models
{
    /// <summary> The result of a list request. </summary>
    internal partial class KeyListResult
    {
        /// <summary> Initializes a new instance of KeyListResult. </summary>
        internal KeyListResult()
        {
            Items = new ChangeTrackingList<Key>();
        }

        /// <summary> Initializes a new instance of KeyListResult. </summary>
        /// <param name="items"> The collection value. </param>
        /// <param name="nextLink"> The URI that can be used to request the next set of paged results. </param>
        internal KeyListResult(IReadOnlyList<Key> items, string nextLink)
        {
            Items = items;
            NextLink = nextLink;
        }

        /// <summary> The collection value. </summary>
        public IReadOnlyList<Key> Items { get; }
        /// <summary> The URI that can be used to request the next set of paged results. </summary>
        public string NextLink { get; }
    }
}
