// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using TenantOnly;

namespace TenantOnly.Models
{
    /// <summary> The response from the List Storage Accounts operation. </summary>
    internal partial class AgreementListResult
    {
        /// <summary> Initializes a new instance of <see cref="AgreementListResult"/>. </summary>
        internal AgreementListResult()
        {
            Value = new ChangeTrackingList<AgreementData>();
        }

        /// <summary> Initializes a new instance of <see cref="AgreementListResult"/>. </summary>
        /// <param name="value"> Gets the list of storage accounts and their properties. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </param>
        internal AgreementListResult(IReadOnlyList<AgreementData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the list of storage accounts and their properties. </summary>
        public IReadOnlyList<AgreementData> Value { get; }
        /// <summary> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
