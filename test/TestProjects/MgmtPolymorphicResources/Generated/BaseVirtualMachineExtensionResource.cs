// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using MgmtPolymorphicResources.Models;

namespace MgmtPolymorphicResources
{
    /// <summary> TODO. </summary>
    public abstract partial class BaseVirtualMachineExtensionResource : ArmResource
    {
        internal static BaseVirtualMachineExtensionResource GetResource(ArmClient client, VirtualMachineExtensionData data)
        {
            if (IsVirtualMachineExtensionResource(data.Id))
            {
                return new VirtualMachineExtensionResource(client, data);
            }
            if (IsVirtualMachineScaleSetExtensionResource(data.Id))
            {
                return new VirtualMachineScaleSetExtensionResource(client, data);
            }
            // TODO -- should we throw or return an UnknownResource?
            throw new InvalidOperationException();
        }

        internal static bool IsVirtualMachineExtensionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != VirtualMachineExtensionResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsVirtualMachineScaleSetExtensionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != VirtualMachineScaleSetExtensionResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
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

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Task<Response<BaseVirtualMachineExtensionResource>> GetCoreAsync(string expand = null, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<BaseVirtualMachineExtensionResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<BaseVirtualMachineExtensionResource> GetCore(string expand = null, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<BaseVirtualMachineExtensionResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            return GetCore(expand, cancellationToken);
        }

        /// <summary> The core implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            return await DeleteCoreAsync(waitUntil, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            return DeleteCore(waitUntil, cancellationToken);
        }

        /// <summary> The core implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Update Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionParameters"/> is null. </exception>
        protected abstract Task<ArmOperation<BaseVirtualMachineExtensionResource>> UpdateCoreAsync(WaitUntil waitUntil, VirtualMachineExtensionUpdate extensionParameters, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Update Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionParameters"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<ArmOperation<BaseVirtualMachineExtensionResource>> UpdateAsync(WaitUntil waitUntil, VirtualMachineExtensionUpdate extensionParameters, CancellationToken cancellationToken = default)
        {
            return await UpdateCoreAsync(waitUntil, extensionParameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Update Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionParameters"/> is null. </exception>
        protected abstract ArmOperation<BaseVirtualMachineExtensionResource> UpdateCore(WaitUntil waitUntil, VirtualMachineExtensionUpdate extensionParameters, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Update Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionParameters"/> is null. </exception>
        [ForwardsClientCalls]
        public ArmOperation<BaseVirtualMachineExtensionResource> Update(WaitUntil waitUntil, VirtualMachineExtensionUpdate extensionParameters, CancellationToken cancellationToken = default)
        {
            return UpdateCore(waitUntil, extensionParameters, cancellationToken);
        }

        /// <summary> The core implementation for operation AddTag. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        protected abstract Task<Response<BaseVirtualMachineExtensionResource>> AddTagCoreAsync(string key, string value, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation AddTag. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<Response<BaseVirtualMachineExtensionResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            return await AddTagCoreAsync(key, value, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation AddTag. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        protected abstract Response<BaseVirtualMachineExtensionResource> AddTagCore(string key, string value, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation AddTag. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        [ForwardsClientCalls]
        public Response<BaseVirtualMachineExtensionResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            return AddTagCore(key, value, cancellationToken);
        }

        /// <summary> The core implementation for operation SetTags. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        protected abstract Task<Response<BaseVirtualMachineExtensionResource>> SetTagsCoreAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation SetTags. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<Response<BaseVirtualMachineExtensionResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            return await SetTagsCoreAsync(tags, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation SetTags. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        protected abstract Response<BaseVirtualMachineExtensionResource> SetTagsCore(IDictionary<string, string> tags, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation SetTags. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        [ForwardsClientCalls]
        public Response<BaseVirtualMachineExtensionResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            return SetTagsCore(tags, cancellationToken);
        }

        /// <summary> The core implementation for operation RemoveTag. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        protected abstract Task<Response<BaseVirtualMachineExtensionResource>> RemoveTagCoreAsync(string key, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation RemoveTag. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<Response<BaseVirtualMachineExtensionResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            return await RemoveTagCoreAsync(key, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation RemoveTag. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        protected abstract Response<BaseVirtualMachineExtensionResource> RemoveTagCore(string key, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation RemoveTag. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        [ForwardsClientCalls]
        public Response<BaseVirtualMachineExtensionResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            return RemoveTagCore(key, cancellationToken);
        }
    }
}
