// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    /// <summary> A class representing collection of SubRes2Resource and their operations over a Tenant. </summary>
    public partial class SubRes2ResourceContainer : ResourceContainerBase<TenantResourceIdentifier, SubRes2Resource, SubRes2ResourceData>
    {
        /// <summary> Initializes a new instance of the <see cref="SubRes2ResourceContainer"/> class for mocking. </summary>
        protected SubRes2ResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of SubRes2ResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SubRes2ResourceContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private SubRes2ResourcesRestOperations _restClient => new SubRes2ResourcesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.RootResourceIdentifier.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a SubRes2Resource. Please note some properties can be set only during creation. </summary>
        /// <param name="subRes2ResourcesName"> The String to use. </param>
        /// <param name="parameters"> The SubRes2Resource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<SubRes2Resource> CreateOrUpdate(string subRes2ResourcesName, SubRes2ResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes2ResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (subRes2ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subRes2ResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(subRes2ResourcesName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a SubRes2Resource. Please note some properties can be set only during creation. </summary>
        /// <param name="subRes2ResourcesName"> The String to use. </param>
        /// <param name="parameters"> The SubRes2Resource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<SubRes2Resource>> CreateOrUpdateAsync(string subRes2ResourcesName, SubRes2ResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes2ResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (subRes2ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subRes2ResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(subRes2ResourcesName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a SubRes2Resource. Please note some properties can be set only during creation. </summary>
        /// <param name="subRes2ResourcesName"> The String to use. </param>
        /// <param name="parameters"> The SubRes2Resource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public SubRes2ResourcesPutOperation StartCreateOrUpdate(string subRes2ResourcesName, SubRes2ResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes2ResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (subRes2ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subRes2ResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Put(subRes2ResourcesName, parameters, cancellationToken: cancellationToken);
                return new SubRes2ResourcesPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a SubRes2Resource. Please note some properties can be set only during creation. </summary>
        /// <param name="subRes2ResourcesName"> The String to use. </param>
        /// <param name="parameters"> The SubRes2Resource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<SubRes2ResourcesPutOperation> StartCreateOrUpdateAsync(string subRes2ResourcesName, SubRes2ResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes2ResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (subRes2ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subRes2ResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.PutAsync(subRes2ResourcesName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new SubRes2ResourcesPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="subRes2ResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<SubRes2Resource> Get(string subRes2ResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes2ResourceContainer.Get");
            scope.Start();
            try
            {
                if (subRes2ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subRes2ResourcesName));
                }

                var response = _restClient.Get(subRes2ResourcesName, cancellationToken: cancellationToken);
                return Response.FromValue(new SubRes2Resource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="subRes2ResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<SubRes2Resource>> GetAsync(string subRes2ResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes2ResourceContainer.Get");
            scope.Start();
            try
            {
                if (subRes2ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subRes2ResourcesName));
                }

                var response = await _restClient.GetAsync(subRes2ResourcesName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SubRes2Resource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of SubRes2Resource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes2ResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubRes2ResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of SubRes2Resource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes2ResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubRes2ResourceOperations.ResourceType);
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
        // public ArmBuilder<TenantResourceIdentifier, SubRes2Resource, SubRes2ResourceData> Construct() { }
    }
}
