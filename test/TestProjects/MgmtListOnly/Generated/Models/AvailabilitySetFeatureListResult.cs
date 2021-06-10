// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MgmtListOnly.Models
{
    /// <summary> The List Availability Set Feature operation response. </summary>
    internal partial class AvailabilitySetFeatureListResult
    {
        /// <summary> Initializes a new instance of AvailabilitySetFeatureListResult. </summary>
        internal AvailabilitySetFeatureListResult()
        {
            Value = new ChangeTrackingList<AvailabilitySetFeature>();
        }

        /// <summary> Initializes a new instance of AvailabilitySetFeatureListResult. </summary>
        /// <param name="value"> The list of availability sets. </param>
        /// <param name="nextLink"> The URI to fetch the next page of AvailabilitySets. Call ListNext() with this URI to fetch the next page of AvailabilitySets. </param>
        internal AvailabilitySetFeatureListResult(IReadOnlyList<AvailabilitySetFeature> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of availability sets. </summary>
        public IReadOnlyList<AvailabilitySetFeature> Value { get; }
        /// <summary> The URI to fetch the next page of AvailabilitySets. Call ListNext() with this URI to fetch the next page of AvailabilitySets. </summary>
        public string NextLink { get; }
    }
}
