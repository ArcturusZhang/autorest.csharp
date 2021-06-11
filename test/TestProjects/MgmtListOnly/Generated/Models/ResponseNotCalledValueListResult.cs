// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace MgmtListOnly.Models
{
    /// <summary> The List Availability Set Child operation response. </summary>
    internal partial class ResponseNotCalledValueListResult
    {
        /// <summary> Initializes a new instance of ResponseNotCalledValueListResult. </summary>
        /// <param name="notValue"> The list of availability sets child. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notValue"/> is null. </exception>
        internal ResponseNotCalledValueListResult(IEnumerable<AvailabilitySetChild> notValue)
        {
            if (notValue == null)
            {
                throw new ArgumentNullException(nameof(notValue));
            }

            NotValue = notValue.ToList();
        }

        /// <summary> Initializes a new instance of ResponseNotCalledValueListResult. </summary>
        /// <param name="notValue"> The list of availability sets child. </param>
        /// <param name="nextLink"> The URI to fetch the next page of AvailabilitySetsChild. Call ListNext() with this URI to fetch the next page of AvailabilitySets. </param>
        internal ResponseNotCalledValueListResult(IReadOnlyList<AvailabilitySetChild> notValue, string nextLink)
        {
            NotValue = notValue;
            NextLink = nextLink;
        }

        /// <summary> The list of availability sets child. </summary>
        public IReadOnlyList<AvailabilitySetChild> NotValue { get; }
        /// <summary> The URI to fetch the next page of AvailabilitySetsChild. Call ListNext() with this URI to fetch the next page of AvailabilitySets. </summary>
        public string NextLink { get; }
    }
}
