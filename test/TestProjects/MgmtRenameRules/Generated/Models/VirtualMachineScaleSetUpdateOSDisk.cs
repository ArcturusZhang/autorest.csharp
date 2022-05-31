// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace MgmtRenameRules.Models
{
    /// <summary> Describes virtual machine scale set operating system disk Update Object. This should be used for Updating VMSS OS Disk. </summary>
    public partial class VirtualMachineScaleSetUpdateOSDisk
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateOSDisk"/>. </summary>
        public VirtualMachineScaleSetUpdateOSDisk()
        {
            VhdContainers = new ChangeTrackingList<string>();
        }

        /// <summary> The caching type. </summary>
        public CachingTypes? Caching { get; set; }
        /// <summary> Specifies whether writeAccelerator should be enabled or disabled on the disk. </summary>
        public bool? WriteAcceleratorEnabled { get; set; }
        /// <summary> Specifies the size of the operating system disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. &lt;br&gt;&lt;br&gt; This value cannot be larger than 1023 GB. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> The Source User Image VirtualHardDisk. This VirtualHardDisk will be copied before using it to attach to the Virtual Machine. If SourceImage is provided, the destination VirtualHardDisk should not exist. </summary>
        internal VirtualHardDisk Image { get; set; }
        /// <summary> Specifies the virtual hard disk&apos;s uri. </summary>
        public Uri ImageUri
        {
            get => Image is null ? default : Image.Uri;
            set
            {
                if (Image is null)
                    Image = new VirtualHardDisk();
                Image.Uri = value;
            }
        }

        /// <summary> The list of virtual hard disk container uris. </summary>
        public IList<string> VhdContainers { get; }
        /// <summary> The managed disk parameters. </summary>
        public VirtualMachineScaleSetManagedDiskParameters ManagedDisk { get; set; }
    }
}
