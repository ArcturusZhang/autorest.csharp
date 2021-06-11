// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing collection of TrackedResourceModel1 and their operations over a ResourceGroup. </summary>
    public partial class TrackedResourceModel1Container : ResourceContainerBase<ResourceGroupResourceIdentifier, TrackedResourceModel1, TrackedResourceModel1Data>
    {
        /// <summary> Initializes a new instance of the <see cref="TrackedResourceModel1Container"/> class for mocking. </summary>
        protected TrackedResourceModel1Container()
        {
        }

        /// <summary> Initializes a new instance of TrackedResourceModel1Container class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal TrackedResourceModel1Container(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private TrackedResourceModel1SRestOperations _restClient => new TrackedResourceModel1SRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a TrackedResourceModel1. Please note some properties can be set only during creation. </summary>
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="parameters"> The TrackedResourceModel1 to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<TrackedResourceModel1> CreateOrUpdate(string trackedResourceModel1SName, TrackedResourceModel1Data parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.CreateOrUpdate");
            scope.Start();
            try
            {
                if (trackedResourceModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(trackedResourceModel1SName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(trackedResourceModel1SName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a TrackedResourceModel1. Please note some properties can be set only during creation. </summary>
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="parameters"> The TrackedResourceModel1 to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<TrackedResourceModel1>> CreateOrUpdateAsync(string trackedResourceModel1SName, TrackedResourceModel1Data parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.CreateOrUpdate");
            scope.Start();
            try
            {
                if (trackedResourceModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(trackedResourceModel1SName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(trackedResourceModel1SName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a TrackedResourceModel1. Please note some properties can be set only during creation. </summary>
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="parameters"> The TrackedResourceModel1 to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public TrackedResourceModel1SPutOperation StartCreateOrUpdate(string trackedResourceModel1SName, TrackedResourceModel1Data parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (trackedResourceModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(trackedResourceModel1SName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Put(Id.ResourceGroupName, trackedResourceModel1SName, parameters, cancellationToken: cancellationToken);
                return new TrackedResourceModel1SPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a TrackedResourceModel1. Please note some properties can be set only during creation. </summary>
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="parameters"> The TrackedResourceModel1 to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<TrackedResourceModel1SPutOperation> StartCreateOrUpdateAsync(string trackedResourceModel1SName, TrackedResourceModel1Data parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (trackedResourceModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(trackedResourceModel1SName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.PutAsync(Id.ResourceGroupName, trackedResourceModel1SName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new TrackedResourceModel1SPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public override Response<TrackedResourceModel1> Get(string trackedResourceModel1SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.Get");
            scope.Start();
            try
            {
                if (trackedResourceModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(trackedResourceModel1SName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, trackedResourceModel1SName, cancellationToken: cancellationToken);
                return Response.FromValue(new TrackedResourceModel1(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async override Task<Response<TrackedResourceModel1>> GetAsync(string trackedResourceModel1SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.Get");
            scope.Start();
            try
            {
                if (trackedResourceModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(trackedResourceModel1SName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, trackedResourceModel1SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TrackedResourceModel1(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of TrackedResourceModel1 for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(TrackedResourceModel1Operations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of TrackedResourceModel1 for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(TrackedResourceModel1Operations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, TrackedResourceModel1, TrackedResourceModel1Data> Construct() { }
    }
}
