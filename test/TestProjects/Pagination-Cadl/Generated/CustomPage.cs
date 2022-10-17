// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Pagination;

namespace Azure.Core.Foundations
{
    /// <summary> Paged collection of LedgerEntry items. </summary>
    public partial class CustomPage
    {
        /// <summary> Initializes a new instance of CustomPage. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CustomPage(IEnumerable<LedgerEntry> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }
        /// <summary> Initializes a new instance of CustomPage. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal CustomPage(IList<LedgerEntry> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        public IList<LedgerEntry> Value { get; }

        public string NextLink { get; set; }
    }
}
