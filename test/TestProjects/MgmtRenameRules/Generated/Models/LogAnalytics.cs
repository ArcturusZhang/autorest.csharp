// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtRenameRules.Models
{
    /// <summary> LogAnalytics operation status response. </summary>
    public partial class LogAnalytics
    {
        /// <summary> Initializes a new instance of <see cref="LogAnalytics"/>. </summary>
        internal LogAnalytics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogAnalytics"/>. </summary>
        /// <param name="properties"> LogAnalyticsOutput. </param>
        internal LogAnalytics(LogAnalyticsOutput properties)
        {
            Properties = properties;
        }

        /// <summary> LogAnalyticsOutput. </summary>
        internal LogAnalyticsOutput Properties { get; }
        /// <summary> Output file Uri path to blob container. </summary>
        public string LogAnalyticsOutput
        {
            get => Properties?.Output;
        }
    }
}
