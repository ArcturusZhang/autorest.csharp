// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtListOnly.Models
{
    /// <summary> Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). &lt;br&gt;&lt;br&gt; For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set. </summary>
    public partial class PublishedKey
    {
        /// <summary> Initializes a new instance of PublishedKey. </summary>
        internal PublishedKey()
        {
        }

        /// <summary> Initializes a new instance of PublishedKey. </summary>
        /// <param name="foo"> specifies the bar. </param>
        internal PublishedKey(string foo)
        {
            Foo = foo;
        }

        /// <summary> specifies the bar. </summary>
        public string Foo { get; }
    }
}
