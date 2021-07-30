// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
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
using MgmtScopeResource.Models;

namespace MgmtScopeResource
{
    /// <summary> A class representing collection of PolicyAssignment and their operations over a Tenant. </summary>
    public partial class PolicyAssignmentContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="PolicyAssignmentContainer"/> class for mocking. </summary>
        protected PolicyAssignmentContainer()
        {
        }

        /// <summary> Initializes a new instance of PolicyAssignmentContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PolicyAssignmentContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        /// <summary> Verify that the input resource Id is a valid container for this type. </summary>
        /// <param name="identifier"> The input resource Id to check. </param>
        protected override void ValidateResourceType(ResourceIdentifier identifier)
        {
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private PolicyAssignmentsRestOperations _restClient => new PolicyAssignmentsRestOperations(_clientDiagnostics, Pipeline, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.RootResourceIdentifier.ResourceType;

        // Container level operations.

        /// <summary> This operation creates or updates a policy assignment with the given scope and name. Policy assignments apply to all resources contained within their scope. For example, when you assign a policy at resource group scope, that policy applies to all resources in the group. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<PolicyAssignment> CreateOrUpdate(string policyAssignmentName, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            if (policyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(policyAssignmentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(policyAssignmentName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation creates or updates a policy assignment with the given scope and name. Policy assignments apply to all resources contained within their scope. For example, when you assign a policy at resource group scope, that policy applies to all resources in the group. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<PolicyAssignment>> CreateOrUpdateAsync(string policyAssignmentName, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            if (policyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(policyAssignmentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(policyAssignmentName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation creates or updates a policy assignment with the given scope and name. Policy assignments apply to all resources contained within their scope. For example, when you assign a policy at resource group scope, that policy applies to all resources in the group. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PolicyAssignmentsCreateOperation StartCreateOrUpdate(string policyAssignmentName, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            if (policyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(policyAssignmentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Create(Id, policyAssignmentName, parameters, cancellationToken);
                return new PolicyAssignmentsCreateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation creates or updates a policy assignment with the given scope and name. Policy assignments apply to all resources contained within their scope. For example, when you assign a policy at resource group scope, that policy applies to all resources in the group. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PolicyAssignmentsCreateOperation> StartCreateOrUpdateAsync(string policyAssignmentName, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            if (policyAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(policyAssignmentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateAsync(Id, policyAssignmentName, parameters, cancellationToken).ConfigureAwait(false);
                return new PolicyAssignmentsCreateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PolicyAssignment> Get(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.Get");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }

                var response = _restClient.Get(Id, policyAssignmentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyAssignment(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PolicyAssignment>> GetAsync(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.Get");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }

                var response = await _restClient.GetAsync(Id, policyAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PolicyAssignment(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PolicyAssignment> GetIfExists(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.GetIfExists");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }

                var response = _restClient.Get(Id, policyAssignmentName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<PolicyAssignment>(null, response.GetRawResponse())
                    : Response.FromValue(new PolicyAssignment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PolicyAssignment>> GetIfExistsAsync(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.GetIfExists");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }

                var response = await _restClient.GetAsync(Id, policyAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<PolicyAssignment>(null, response.GetRawResponse())
                    : Response.FromValue(new PolicyAssignment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }

                var response = GetIfExists(policyAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }

                var response = await GetIfExistsAsync(policyAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the list of all policy assignments associated with the given subscription that match the optional given $filter. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy assignments associated with the subscription, including those that apply directly or from management groups that contain the given subscription, as well as any applied to objects contained within the subscription. If $filter=atScope() is provided, the returned list includes all policy assignments that apply to the subscription, which is everything in the unfiltered list except those applied to objects contained within the subscription. If $filter=atExactScope() is provided, the returned list only includes all policy assignments that at the subscription. If $filter=policyDefinitionId eq &apos;{value}&apos; is provided, the returned list includes all policy assignments of the policy definition whose id is {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atScope() is provided, the returned list only includes all policy assignments that apply to the scope, which is everything in the unfiltered list except those applied to sub scopes contained within the given scope. If $filter=atExactScope() is provided, the returned list only includes all policy assignments that at the given scope. If $filter=policyDefinitionId eq &apos;{value}&apos; is provided, the returned list includes all policy assignments of the policy definition whose id is {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyAssignment" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<PolicyAssignment> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<PolicyAssignment> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.GetAll");
                scope.Start();
                try
                {
                    if (Id.TryGetResourceGroupName(out var resourceGroupName))
                    {
                        if (Id.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                        {
                            var response = _restClient.GetForResourceGroup(Id.Parent.Name, Id.Name, filter, top, cancellationToken: cancellationToken);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                        else
                        {
                            var parent = Id.Parent;
                            var parentParts = new List<string>();
                            while (!parent.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                            {
                                parentParts.Insert(0, $"{parent.ResourceType.Types[parent.ResourceType.Types.Count - 1]}/{parent.Name}");
                                parent = parent.Parent;
                            }
                            var parentResourcePath = parentParts.Count > 0 ? string.Join("/", parentParts) : "";
                            Id.TryGetSubscriptionId(out var subscriptionId);
                            var response = _restClient.GetForResource(subscriptionId, resourceGroupName, Id.ResourceType.Namespace, parentResourcePath, Id.ResourceType.Types[Id.ResourceType.Types.Count - 1], Id.Name, filter, top, cancellationToken: cancellationToken);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                    }
                    else if (Id.TryGetSubscriptionId(out _))
                    {
                        var response = _restClient.GetAll(Id.Name, filter, top, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    else
                    {
                        var response = _restClient.GetForManagementGroup(Id.Name, filter, top, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyAssignment> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.GetAll");
                scope.Start();
                try
                {
                    if (Id.TryGetResourceGroupName(out var resourceGroupName))
                    {
                        if (Id.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                        {
                            var response = _restClient.GetForResourceGroupNextPage(nextLink, Id.Parent.Name, Id.Name, filter, top, cancellationToken: cancellationToken);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                        else
                        {
                            var parent = Id.Parent;
                            var parentParts = new List<string>();
                            while (!parent.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                            {
                                parentParts.Insert(0, $"{parent.ResourceType.Types[parent.ResourceType.Types.Count - 1]}/{parent.Name}");
                                parent = parent.Parent;
                            }
                            var parentResourcePath = parentParts.Count > 0 ? string.Join("/", parentParts) : "";
                            Id.TryGetSubscriptionId(out var subscriptionId);
                            var response = _restClient.GetForResourceNextPage(nextLink, subscriptionId, resourceGroupName, Id.ResourceType.Namespace, parentResourcePath, Id.ResourceType.Types[Id.ResourceType.Types.Count - 1], Id.Name, filter, top, cancellationToken: cancellationToken);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                    }
                    else if (Id.TryGetSubscriptionId(out _))
                    {
                        var response = _restClient.GetAllNextPage(nextLink, Id.Name, filter, top, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    else
                    {
                        var response = _restClient.GetForManagementGroupNextPage(nextLink, Id.Name, filter, top, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation retrieves the list of all policy assignments associated with the given subscription that match the optional given $filter. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy assignments associated with the subscription, including those that apply directly or from management groups that contain the given subscription, as well as any applied to objects contained within the subscription. If $filter=atScope() is provided, the returned list includes all policy assignments that apply to the subscription, which is everything in the unfiltered list except those applied to objects contained within the subscription. If $filter=atExactScope() is provided, the returned list only includes all policy assignments that at the subscription. If $filter=policyDefinitionId eq &apos;{value}&apos; is provided, the returned list includes all policy assignments of the policy definition whose id is {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atScope() is provided, the returned list only includes all policy assignments that apply to the scope, which is everything in the unfiltered list except those applied to sub scopes contained within the given scope. If $filter=atExactScope() is provided, the returned list only includes all policy assignments that at the given scope. If $filter=policyDefinitionId eq &apos;{value}&apos; is provided, the returned list includes all policy assignments of the policy definition whose id is {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyAssignment" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<PolicyAssignment> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyAssignment>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.GetAll");
                scope.Start();
                try
                {
                    if (Id.TryGetResourceGroupName(out var resourceGroupName))
                    {
                        if (Id.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                        {
                            var response = await _restClient.GetForResourceGroupAsync(Id.Parent.Name, Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                        else
                        {
                            var parent = Id.Parent;
                            var parentParts = new List<string>();
                            while (!parent.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                            {
                                parentParts.Insert(0, $"{parent.ResourceType.Types[parent.ResourceType.Types.Count - 1]}/{parent.Name}");
                                parent = parent.Parent;
                            }
                            var parentResourcePath = parentParts.Count > 0 ? string.Join("/", parentParts) : "";
                            Id.TryGetSubscriptionId(out var subscriptionId);
                            var response = await _restClient.GetForResourceAsync(subscriptionId, resourceGroupName, Id.ResourceType.Namespace, parentResourcePath, Id.ResourceType.Types[Id.ResourceType.Types.Count - 1], Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                    }
                    else if (Id.TryGetSubscriptionId(out _))
                    {
                        var response = await _restClient.GetAllAsync(Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    else
                    {
                        var response = await _restClient.GetForManagementGroupAsync(Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyAssignment>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.GetAll");
                scope.Start();
                try
                {
                    if (Id.TryGetResourceGroupName(out var resourceGroupName))
                    {
                        if (Id.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                        {
                            var response = await _restClient.GetForResourceGroupNextPageAsync(nextLink, Id.Parent.Name, Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                        else
                        {
                            var parent = Id.Parent;
                            var parentParts = new List<string>();
                            while (!parent.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                            {
                                parentParts.Insert(0, $"{parent.ResourceType.Types[parent.ResourceType.Types.Count - 1]}/{parent.Name}");
                                parent = parent.Parent;
                            }
                            var parentResourcePath = parentParts.Count > 0 ? string.Join("/", parentParts) : "";
                            Id.TryGetSubscriptionId(out var subscriptionId);
                            var response = await _restClient.GetForResourceNextPageAsync(nextLink, subscriptionId, resourceGroupName, Id.ResourceType.Namespace, parentResourcePath, Id.ResourceType.Types[Id.ResourceType.Types.Count - 1], Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                    }
                    else if (Id.TryGetSubscriptionId(out _))
                    {
                        var response = await _restClient.GetAllNextPageAsync(nextLink, Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    else
                    {
                        var response = await _restClient.GetForManagementGroupNextPageAsync(nextLink, Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="PolicyAssignment" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PolicyAssignmentOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="PolicyAssignment" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PolicyAssignmentOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, PolicyAssignment, PolicyAssignmentData> Construct() { }
    }
}
