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
using Azure.ResourceManager.Resources;
using MgmtMultipleParentResource.Models;

namespace MgmtMultipleParentResource
{
    /// <summary>
    /// A Class representing an UnknownChildBody along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="UnknownChildBodyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetUnknownChildBodyResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetUnknownChildBody method.
    /// </summary>
    internal partial class UnknownChildBodyResource : ChildBodyResource
    {
        /// <summary> Initializes a new instance of the <see cref="UnknownChildBodyResource"/> class for mocking. </summary>
        protected UnknownChildBodyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "UnknownChildBodyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal UnknownChildBodyResource(ArmClient client, ChildBodyData data) : base(client, data)
        {
        }

        /// <summary> Initializes a new instance of the <see cref="UnknownChildBodyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal UnknownChildBodyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary>
        /// The default implementation for operation Get
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ChildBodyResource>> GetCoreAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => _ = 1);
            throw new NotImplementedException();
        }

        /// <summary>
        /// The default implementation for operation Get
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ChildBodyResource> GetCore(string expand = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The default implementation for operation Delete
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => _ = 1);
            throw new NotImplementedException();
        }

        /// <summary>
        /// The default implementation for operation Delete
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The default implementation for operation Update
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="childBody"> Parameters supplied to the Update Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation<ChildBodyResource>> UpdateCoreAsync(WaitUntil waitUntil, ChildBodyUpdate childBody, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => _ = 1);
            throw new NotImplementedException();
        }

        /// <summary>
        /// The default implementation for operation Update
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="childBody"> Parameters supplied to the Update Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation<ChildBodyResource> UpdateCore(WaitUntil waitUntil, ChildBodyUpdate childBody, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The default implementation for operation AddTag
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ChildBodyResource>> AddTagCoreAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => _ = 1);
            throw new NotImplementedException();
        }

        /// <summary>
        /// The default implementation for operation AddTag
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ChildBodyResource> AddTagCore(string key, string value, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The default implementation for operation SetTags
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ChildBodyResource>> SetTagsCoreAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => _ = 1);
            throw new NotImplementedException();
        }

        /// <summary>
        /// The default implementation for operation SetTags
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ChildBodyResource> SetTagsCore(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The default implementation for operation RemoveTag
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ChildBodyResource>> RemoveTagCoreAsync(string key, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => _ = 1);
            throw new NotImplementedException();
        }

        /// <summary>
        /// The default implementation for operation RemoveTag
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// Operation Id: AnotherChildren_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ChildBodyResource> RemoveTagCore(string key, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
