// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace MgmtAcronymMapping.Models
{
    /// <summary>
    /// Describes a Virtual Machine Scale Set VM Reimage Parameters.
    /// Serialized Name: VirtualMachineScaleSetReimageParameters
    /// </summary>
    public partial class VirtualMachineScaleSetReimageContent : VirtualMachineScaleSetVmReimageContent
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetReimageContent"/>. </summary>
        public VirtualMachineScaleSetReimageContent()
        {
            InstanceIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetReimageContent"/>. </summary>
        /// <param name="tempDisk">
        /// Specifies whether to reimage temp disk. Default value: false. Note: This temp disk reimage parameter is only supported for VM/VMSS with Ephemeral OS disk.
        /// Serialized Name: VirtualMachineReimageParameters.tempDisk
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="instanceIds">
        /// The virtual machine scale set instance ids. Omitting the virtual machine scale set instance ids will result in the operation being performed on all virtual machines in the virtual machine scale set.
        /// Serialized Name: VirtualMachineScaleSetReimageParameters.instanceIds
        /// </param>
        internal VirtualMachineScaleSetReimageContent(bool? tempDisk, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<string> instanceIds) : base(tempDisk, serializedAdditionalRawData)
        {
            InstanceIds = instanceIds;
        }

        /// <summary>
        /// The virtual machine scale set instance ids. Omitting the virtual machine scale set instance ids will result in the operation being performed on all virtual machines in the virtual machine scale set.
        /// Serialized Name: VirtualMachineScaleSetReimageParameters.instanceIds
        /// </summary>
        public IList<string> InstanceIds { get; }
    }
}
