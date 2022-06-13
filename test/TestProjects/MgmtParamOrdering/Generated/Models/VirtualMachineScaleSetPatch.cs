// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtParamOrdering.Models
{
    /// <summary> Describes a Virtual Machine Scale Set. </summary>
    public partial class VirtualMachineScaleSetPatch : UpdateResource
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetUpdate. </summary>
        public VirtualMachineScaleSetPatch()
        {
        }

        /// <summary> The virtual machine scale set sku. </summary>
        public MgmtParamOrderingSku Sku { get; set; }
    }
}
