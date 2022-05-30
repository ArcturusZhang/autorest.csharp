// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Api request input for LogAnalytics getThrottledRequests Api. </summary>
    public partial class ThrottledRequestsContent : LogAnalyticsInputBase
    {
        /// <summary> Initializes a new instance of ThrottledRequestsInput. </summary>
        /// <param name="blobContainerSasUri"> SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to. </param>
        /// <param name="fromOn"> From time of the query. </param>
        /// <param name="toOn"> To time of the query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blobContainerSasUri"/> is null. </exception>
        public ThrottledRequestsContent(Uri blobContainerSasUri, DateTimeOffset fromOn, DateTimeOffset toOn) : base(blobContainerSasUri, fromOn, toOn)
        {
            if (blobContainerSasUri == null)
            {
                throw new ArgumentNullException(nameof(blobContainerSasUri));
            }
        }
    }
}
