// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sample
{
    /// <summary> This is the base client representation of the following resources <see cref="VirtualMachineExtensionResource" /> or <see cref="VirtualMachineScaleSetVirtualMachineExtensionResource" />. </summary>
    public abstract partial class BaseVirtualMachineExtensionResource : ArmResource
    {
        internal static BaseVirtualMachineExtensionResource GetResource(ArmClient client, VirtualMachineExtensionData data)
        {
            if (IsVirtualMachineExtensionResource(data.Id))
            {
                return new VirtualMachineExtensionResource(client, data);
            }
            if (IsVirtualMachineScaleSetVirtualMachineExtensionResource(data.Id))
            {
                return new VirtualMachineScaleSetVirtualMachineExtensionResource(client, data);
            }
            throw new InvalidOperationException($"The resource identifier {data.Id} cannot be recognized as one of the following resource candidates: VirtualMachineExtensionResource or VirtualMachineScaleSetVirtualMachineExtensionResource");
        }

        private static bool IsVirtualMachineExtensionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != VirtualMachineExtensionResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            return true;
        }

        private static bool IsVirtualMachineScaleSetVirtualMachineExtensionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != VirtualMachineScaleSetVirtualMachineExtensionResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            return true;
        }

        private readonly VirtualMachineExtensionData _data;

        /// <summary> Initializes a new instance of the <see cref="BaseVirtualMachineExtensionResource"/> class for mocking. </summary>
        protected BaseVirtualMachineExtensionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BaseVirtualMachineExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BaseVirtualMachineExtensionResource(ArmClient client, VirtualMachineExtensionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BaseVirtualMachineExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BaseVirtualMachineExtensionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VirtualMachineExtensionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }
    }
}
