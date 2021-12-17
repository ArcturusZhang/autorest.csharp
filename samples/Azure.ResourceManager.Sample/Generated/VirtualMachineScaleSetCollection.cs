// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sample.Models;

namespace Azure.ResourceManager.Sample
{
    /// <summary> A class representing collection of VirtualMachineScaleSet and their operations over its parent. </summary>
    public partial class VirtualMachineScaleSetCollection : ArmCollection, IEnumerable<VirtualMachineScaleSet>, IAsyncEnumerable<VirtualMachineScaleSet>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualMachineScaleSetsRestOperations _virtualMachineScaleSetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetCollection"/> class for mocking. </summary>
        protected VirtualMachineScaleSetCollection()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualMachineScaleSetCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _virtualMachineScaleSetsRestClient = new VirtualMachineScaleSetsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_CreateOrUpdate
        /// <summary> Create or update a VM scale set. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set to create or update. </param>
        /// <param name="parameters"> The scale set object. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualMachineScaleSetCreateOrUpdateOperation CreateOrUpdate(string vmScaleSetName, VirtualMachineScaleSetData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, parameters, cancellationToken);
                var operation = new VirtualMachineScaleSetCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualMachineScaleSetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_CreateOrUpdate
        /// <summary> Create or update a VM scale set. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set to create or update. </param>
        /// <param name="parameters"> The scale set object. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualMachineScaleSetCreateOrUpdateOperation> CreateOrUpdateAsync(string vmScaleSetName, VirtualMachineScaleSetData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualMachineScaleSetCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualMachineScaleSetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_Get
        /// <summary> Display information about a virtual machine scale set. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSet> Get(string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSet(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_Get
        /// <summary> Display information about a virtual machine scale set. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSet>> GetAsync(string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineScaleSet(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSet> GetIfExists(string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualMachineScaleSet>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualMachineScaleSet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSet>> GetIfExistsAsync(string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vmScaleSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualMachineScaleSet>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualMachineScaleSet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(vmScaleSetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vmScaleSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_List
        /// <summary> Gets a list of all VM scale sets under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSet" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineScaleSet> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineScaleSet> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineScaleSet> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineScaleSets_List
        /// <summary> Gets a list of all VM scale sets under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSet" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineScaleSet> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineScaleSet>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineScaleSet>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualMachineScaleSet" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineScaleSet.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualMachineScaleSet" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineScaleSet.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineScaleSet> IEnumerable<VirtualMachineScaleSet>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineScaleSet> IAsyncEnumerable<VirtualMachineScaleSet>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, VirtualMachineScaleSet, VirtualMachineScaleSetData> Construct() { }
    }
}
