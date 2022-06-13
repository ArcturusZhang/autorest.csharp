// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MgmtParent.Models
{
    /// <summary> Specifies information about the dedicated host group that the dedicated host should be assigned to. Only tags may be updated. </summary>
    public partial class DedicatedHostGroupPatch : UpdateResource
    {
        /// <summary> Initializes a new instance of DedicatedHostGroupUpdate. </summary>
        public DedicatedHostGroupPatch()
        {
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Availability Zone to use for this host group. Only single zone is supported. The zone can be assigned only during creation. If not provided, the group supports all zones in the region. If provided, enforces each host in the group to be in the same zone. </summary>
        public IList<string> Zones { get; }
        /// <summary> Number of fault domains that the host group can span. </summary>
        public int? PlatformFaultDomainCount { get; set; }
        /// <summary> Specifies whether virtual machines or virtual machine scale sets can be placed automatically on the dedicated host group. Automatic placement means resources are allocated on dedicated hosts, that are chosen by Azure, under the dedicated host group. The value is defaulted to &apos;true&apos; when not provided. &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-06-01. </summary>
        public bool? SupportAutomaticPlacement { get; set; }
    }
}
