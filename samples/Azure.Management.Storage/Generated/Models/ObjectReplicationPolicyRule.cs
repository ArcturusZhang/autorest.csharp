// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Storage.Models
{
    /// <summary> The replication policy rule between two containers. </summary>
    public partial class ObjectReplicationPolicyRule
    {
        /// <summary> Initializes a new instance of <see cref="ObjectReplicationPolicyRule"/>. </summary>
        /// <param name="sourceContainer"> Required. Source container name. </param>
        /// <param name="destinationContainer"> Required. Destination container name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceContainer"/> or <paramref name="destinationContainer"/> is null. </exception>
        public ObjectReplicationPolicyRule(string sourceContainer, string destinationContainer)
        {
            if (sourceContainer == null)
            {
                throw new ArgumentNullException(nameof(sourceContainer));
            }
            if (destinationContainer == null)
            {
                throw new ArgumentNullException(nameof(destinationContainer));
            }

            SourceContainer = sourceContainer;
            DestinationContainer = destinationContainer;
        }

        /// <summary> Initializes a new instance of <see cref="ObjectReplicationPolicyRule"/>. </summary>
        /// <param name="ruleId"> Rule Id is auto-generated for each new rule on destination account. It is required for put policy on source account. </param>
        /// <param name="sourceContainer"> Required. Source container name. </param>
        /// <param name="destinationContainer"> Required. Destination container name. </param>
        /// <param name="filters"> Optional. An object that defines the filter set. </param>
        internal ObjectReplicationPolicyRule(string ruleId, string sourceContainer, string destinationContainer, ObjectReplicationPolicyFilter filters)
        {
            RuleId = ruleId;
            SourceContainer = sourceContainer;
            DestinationContainer = destinationContainer;
            Filters = filters;
        }

        /// <summary> Rule Id is auto-generated for each new rule on destination account. It is required for put policy on source account. </summary>
        public string RuleId { get; set; }
        /// <summary> Required. Source container name. </summary>
        public string SourceContainer { get; set; }
        /// <summary> Required. Destination container name. </summary>
        public string DestinationContainer { get; set; }
        /// <summary> Optional. An object that defines the filter set. </summary>
        public ObjectReplicationPolicyFilter Filters { get; set; }
    }
}
