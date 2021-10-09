// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Management;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of MgmtGrpParentWithNonResCh and their operations over its parent. </summary>
    public partial class MgmtGrpParentWithNonResChContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly MgmtGrpParentWithNonResChesRestOperations _mgmtGrpParentWithNonResChesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MgmtGrpParentWithNonResChContainer"/> class for mocking. </summary>
        protected MgmtGrpParentWithNonResChContainer()
        {
        }

        /// <summary> Initializes a new instance of MgmtGrpParentWithNonResChContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal MgmtGrpParentWithNonResChContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _mgmtGrpParentWithNonResChesRestClient = new MgmtGrpParentWithNonResChesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ManagementGroup.ResourceType;

        // Container level operations.

        /// <summary> Create or update. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual MgmtGrpParentWithNonResChCreateOrUpdateOperation CreateOrUpdate(string mgmtGrpParentWithNonResChName, MgmtGrpParentWithNonResChData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithNonResChesRestClient.CreateOrUpdate(Id.Parent.Name, mgmtGrpParentWithNonResChName, parameters, cancellationToken);
                var operation = new MgmtGrpParentWithNonResChCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Create or update. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<MgmtGrpParentWithNonResChCreateOrUpdateOperation> CreateOrUpdateAsync(string mgmtGrpParentWithNonResChName, MgmtGrpParentWithNonResChData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithNonResChesRestClient.CreateOrUpdateAsync(Id.Parent.Name, mgmtGrpParentWithNonResChName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtGrpParentWithNonResChCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Retrieves information. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithNonResCh> Get(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.Get");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithNonResChesRestClient.Get(Id.Parent.Name, mgmtGrpParentWithNonResChName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MgmtGrpParentWithNonResCh(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> is null. </exception>
        public async virtual Task<Response<MgmtGrpParentWithNonResCh>> GetAsync(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.Get");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithNonResChesRestClient.GetAsync(Id.Parent.Name, mgmtGrpParentWithNonResChName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MgmtGrpParentWithNonResCh(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithNonResCh> GetIfExists(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithNonResChesRestClient.Get(Id.Parent.Name, mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<MgmtGrpParentWithNonResCh>(null, response.GetRawResponse())
                    : Response.FromValue(new MgmtGrpParentWithNonResCh(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> is null. </exception>
        public async virtual Task<Response<MgmtGrpParentWithNonResCh>> GetIfExistsAsync(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithNonResChesRestClient.GetAsync(Id.Parent.Name, mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<MgmtGrpParentWithNonResCh>(null, response.GetRawResponse())
                    : Response.FromValue(new MgmtGrpParentWithNonResCh(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string mgmtGrpParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(mgmtGrpParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MgmtGrpParentWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MgmtGrpParentWithNonResCh> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MgmtGrpParentWithNonResCh> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _mgmtGrpParentWithNonResChesRestClient.GetAll(Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MgmtGrpParentWithNonResCh> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _mgmtGrpParentWithNonResChesRestClient.GetAllNextPage(nextLink, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MgmtGrpParentWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MgmtGrpParentWithNonResCh> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MgmtGrpParentWithNonResCh>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _mgmtGrpParentWithNonResChesRestClient.GetAllAsync(Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MgmtGrpParentWithNonResCh>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _mgmtGrpParentWithNonResChesRestClient.GetAllNextPageAsync(nextLink, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, MgmtGrpParentWithNonResCh, MgmtGrpParentWithNonResChData> Construct() { }
    }
}
