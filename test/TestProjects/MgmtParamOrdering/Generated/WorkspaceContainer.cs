// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using MgmtParamOrdering.Models;

namespace MgmtParamOrdering
{
    /// <summary> A class representing collection of Workspace and their operations over its parent. </summary>
    public partial class WorkspaceContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WorkspacesRestOperations _workspacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkspaceContainer"/> class for mocking. </summary>
        protected WorkspaceContainer()
        {
        }

        /// <summary> Initializes a new instance of WorkspaceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal WorkspaceContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _workspacesRestClient = new WorkspacesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a workspace with the specified parameters. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="parameters"> The parameters for creating or updating a machine learning workspace. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual WorkspaceCreateOrUpdateOperation CreateOrUpdate(string workspaceName, WorkspaceData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workspacesRestClient.CreateOrUpdate(Id.ResourceGroupName, workspaceName, parameters, cancellationToken);
                var operation = new WorkspaceCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _workspacesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, workspaceName, parameters).Request, response);
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

        /// <summary> Creates or updates a workspace with the specified parameters. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="parameters"> The parameters for creating or updating a machine learning workspace. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<WorkspaceCreateOrUpdateOperation> CreateOrUpdateAsync(string workspaceName, WorkspaceData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workspacesRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, workspaceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new WorkspaceCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _workspacesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, workspaceName, parameters).Request, response);
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

        /// <summary> Gets the properties of the specified machine learning workspace. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<Workspace> Get(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceContainer.Get");
            scope.Start();
            try
            {
                var response = _workspacesRestClient.Get(Id.ResourceGroupName, workspaceName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Workspace(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the properties of the specified machine learning workspace. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public async virtual Task<Response<Workspace>> GetAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceContainer.Get");
            scope.Start();
            try
            {
                var response = await _workspacesRestClient.GetAsync(Id.ResourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Workspace(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<Workspace> GetIfExists(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _workspacesRestClient.Get(Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Workspace>(null, response.GetRawResponse())
                    : Response.FromValue(new Workspace(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public async virtual Task<Response<Workspace>> GetIfExistsAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _workspacesRestClient.GetAsync(Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Workspace>(null, response.GetRawResponse())
                    : Response.FromValue(new Workspace(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(workspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkspaceContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Workspace" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Workspace.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Workspace" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Workspace.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, Workspace, WorkspaceData> Construct() { }
    }
}
