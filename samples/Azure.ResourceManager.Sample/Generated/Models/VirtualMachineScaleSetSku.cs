// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Describes an available virtual machine scale set sku. </summary>
    public partial class VirtualMachineScaleSetSku
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetSku"/>. </summary>
        internal VirtualMachineScaleSetSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetSku"/>. </summary>
        /// <param name="resourceType"> The type of resource the sku applies to. </param>
        /// <param name="sku"> The Sku. </param>
        /// <param name="capacity"> Specifies the number of virtual machines in the scale set. </param>
        internal VirtualMachineScaleSetSku(ResourceType? resourceType, SampleSku sku, VirtualMachineScaleSetSkuCapacity capacity)
        {
            ResourceType = resourceType;
            Sku = sku;
            Capacity = capacity;
        }

        /// <summary> The type of resource the sku applies to. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> The Sku. </summary>
        public SampleSku Sku { get; }
        /// <summary> Specifies the number of virtual machines in the scale set. </summary>
        public VirtualMachineScaleSetSkuCapacity Capacity { get; }
    }
}
