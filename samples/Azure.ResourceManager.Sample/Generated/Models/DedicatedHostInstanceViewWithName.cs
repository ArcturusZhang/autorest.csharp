// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary>
    /// The instance view of a dedicated host that includes the name of the dedicated host. It is used for the response to the instance view of a dedicated host group.
    /// Serialized Name: DedicatedHostInstanceViewWithName
    /// </summary>
    public partial class DedicatedHostInstanceViewWithName : DedicatedHostInstanceView
    {
        /// <summary> Initializes a new instance of DedicatedHostInstanceViewWithName. </summary>
        public DedicatedHostInstanceViewWithName()
        {
        }

        /// <summary> Initializes a new instance of DedicatedHostInstanceViewWithName. </summary>
        /// <param name="assetId">
        /// Specifies the unique id of the dedicated physical machine on which the dedicated host resides.
        /// Serialized Name: DedicatedHostInstanceView.assetId
        /// </param>
        /// <param name="availableCapacity">
        /// Unutilized capacity of the dedicated host.
        /// Serialized Name: DedicatedHostInstanceView.availableCapacity
        /// </param>
        /// <param name="statuses">
        /// The resource status information.
        /// Serialized Name: DedicatedHostInstanceView.statuses
        /// </param>
        /// <param name="name">
        /// The name of the dedicated host.
        /// Serialized Name: DedicatedHostInstanceViewWithName.name
        /// </param>
        internal DedicatedHostInstanceViewWithName(string assetId, DedicatedHostAvailableCapacity availableCapacity, IReadOnlyList<InstanceViewStatus> statuses, string name) : base(assetId, availableCapacity, statuses)
        {
            Name = name;
        }

        /// <summary>
        /// The name of the dedicated host.
        /// Serialized Name: DedicatedHostInstanceViewWithName.name
        /// </summary>
        public string Name { get; }
    }
}
