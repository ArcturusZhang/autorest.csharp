// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtPolymorphicResources
{
    /// <summary> A class representing the VirtualMachineExtension data model. </summary>
    public partial class VirtualMachineExtensionData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualMachineExtensionData. </summary>
        /// <param name="location"> The location. </param>
        public VirtualMachineExtensionData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineExtensionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="forceUpdateTag"> How the extension handler should be forced to update even if the extension configuration has not changed. </param>
        /// <param name="publisher"> The name of the extension handler publisher. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        internal VirtualMachineExtensionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string forceUpdateTag, string publisher, string provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            ForceUpdateTag = forceUpdateTag;
            Publisher = publisher;
            ProvisioningState = provisioningState;
        }

        /// <summary> How the extension handler should be forced to update even if the extension configuration has not changed. </summary>
        public string ForceUpdateTag { get; set; }
        /// <summary> The name of the extension handler publisher. </summary>
        public string Publisher { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
    }
}
