// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace MgmtPolymorphicResources
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualMachineScaleSetExtensionResource" /> and their operations.
    /// Each <see cref="VirtualMachineScaleSetExtensionResource" /> in the collection will belong to the same instance of <see cref="VirtualMachineScaleSetResource" />.
    /// To get a <see cref="VirtualMachineScaleSetExtensionCollection" /> instance call the GetVirtualMachineScaleSetExtensions method from an instance of <see cref="VirtualMachineScaleSetResource" />.
    /// </summary>
    public partial class VirtualMachineScaleSetExtensionCollection : ArmCollection, IEnumerable<VirtualMachineScaleSetExtensionResource>, IAsyncEnumerable<VirtualMachineScaleSetExtensionResource>
    {
        private readonly ClientDiagnostics _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics;
        private readonly VirtualMachineScaleSetVMExtensionsRestOperations _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetExtensionCollection"/> class for mocking. </summary>
        protected VirtualMachineScaleSetExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualMachineScaleSetExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics = new ClientDiagnostics("MgmtPolymorphicResources", VirtualMachineScaleSetExtensionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualMachineScaleSetExtensionResource.ResourceType, out string virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsApiVersion);
            _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsRestClient = new VirtualMachineScaleSetVMExtensionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachineScaleSetResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachineScaleSetResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update the VMSS VM extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="data"> Parameters supplied to the Create Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualMachineScaleSetExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vmExtensionName, VirtualMachineExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmExtensionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtPolymorphicResourcesArmOperation<VirtualMachineScaleSetExtensionResource>(new VirtualMachineScaleSetExtensionOperationSource(Client), _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics, Pipeline, _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmExtensionName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to create or update the VMSS VM extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="data"> Parameters supplied to the Create Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualMachineScaleSetExtensionResource> CreateOrUpdate(WaitUntil waitUntil, string vmExtensionName, VirtualMachineExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmExtensionName, data, cancellationToken);
                var operation = new MgmtPolymorphicResourcesArmOperation<VirtualMachineScaleSetExtensionResource>(new VirtualMachineScaleSetExtensionOperationSource(Client), _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics, Pipeline, _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmExtensionName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the VMSS VM extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_Get
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachineScaleSetExtensionResource>> GetAsync(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmExtensionName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the VMSS VM extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_Get
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetExtensionResource> Get(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmExtensionName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get all extensions of an instance in Virtual Machine Scaleset.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions
        /// Operation Id: VirtualMachineScaleSetVMExtensions_List
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSetExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineScaleSetExtensionResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineScaleSetExtensionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetExtensionResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// The operation to get all extensions of an instance in Virtual Machine Scaleset.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions
        /// Operation Id: VirtualMachineScaleSetVMExtensions_List
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSetExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineScaleSetExtensionResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineScaleSetExtensionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetExtensionResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_Get
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmExtensionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmExtensionName}
        /// Operation Id: VirtualMachineScaleSetVMExtensions_Get
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetExtensionVirtualMachineScaleSetVMExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmExtensionName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineScaleSetExtensionResource> IEnumerable<VirtualMachineScaleSetExtensionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineScaleSetExtensionResource> IAsyncEnumerable<VirtualMachineScaleSetExtensionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
