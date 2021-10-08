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
using MgmtOperations.Models;

namespace MgmtOperations
{
    /// <summary> A class representing collection of AvailabilitySetGrandChild and their operations over its parent. </summary>
    public partial class AvailabilitySetGrandChildContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AvailabilitySetGrandChildRestOperations _availabilitySetGrandChildRestClient;

        /// <summary> Initializes a new instance of the <see cref="AvailabilitySetGrandChildContainer"/> class for mocking. </summary>
        protected AvailabilitySetGrandChildContainer()
        {
        }

        /// <summary> Initializes a new instance of AvailabilitySetGrandChildContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AvailabilitySetGrandChildContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _availabilitySetGrandChildRestClient = new AvailabilitySetGrandChildRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => "Microsoft.Compute/availabilitySets/availabilitySetChild";

        // Container level operations.

        /// <summary> Create or update an availability set. </summary>
        /// <param name="availabilitySetGrandChildName"> The name of the availability set grand child. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetGrandChildName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual AvailabilitySetGrandChildCreateOrUpdateOperation CreateOrUpdate(string availabilitySetGrandChildName, AvailabilitySetGrandChildData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (availabilitySetGrandChildName == null)
            {
                throw new ArgumentNullException(nameof(availabilitySetGrandChildName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetGrandChildContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _availabilitySetGrandChildRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Parent.Name, Id.Name, availabilitySetGrandChildName, parameters, cancellationToken);
                var operation = new AvailabilitySetGrandChildCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Create or update an availability set. </summary>
        /// <param name="availabilitySetGrandChildName"> The name of the availability set grand child. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetGrandChildName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<AvailabilitySetGrandChildCreateOrUpdateOperation> CreateOrUpdateAsync(string availabilitySetGrandChildName, AvailabilitySetGrandChildData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (availabilitySetGrandChildName == null)
            {
                throw new ArgumentNullException(nameof(availabilitySetGrandChildName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetGrandChildContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _availabilitySetGrandChildRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, availabilitySetGrandChildName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new AvailabilitySetGrandChildCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Retrieves information about an availability set. </summary>
        /// <param name="availabilitySetGrandChildName"> The name of the availability set grand child. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetGrandChildName"/> is null. </exception>
        public virtual Response<AvailabilitySetGrandChild> Get(string availabilitySetGrandChildName, CancellationToken cancellationToken = default)
        {
            if (availabilitySetGrandChildName == null)
            {
                throw new ArgumentNullException(nameof(availabilitySetGrandChildName));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetGrandChildContainer.Get");
            scope.Start();
            try
            {
                var response = _availabilitySetGrandChildRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, availabilitySetGrandChildName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvailabilitySetGrandChild(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about an availability set. </summary>
        /// <param name="availabilitySetGrandChildName"> The name of the availability set grand child. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetGrandChildName"/> is null. </exception>
        public async virtual Task<Response<AvailabilitySetGrandChild>> GetAsync(string availabilitySetGrandChildName, CancellationToken cancellationToken = default)
        {
            if (availabilitySetGrandChildName == null)
            {
                throw new ArgumentNullException(nameof(availabilitySetGrandChildName));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetGrandChildContainer.Get");
            scope.Start();
            try
            {
                var response = await _availabilitySetGrandChildRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, availabilitySetGrandChildName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AvailabilitySetGrandChild(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="availabilitySetGrandChildName"> The name of the availability set grand child. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetGrandChildName"/> is null. </exception>
        public virtual Response<AvailabilitySetGrandChild> GetIfExists(string availabilitySetGrandChildName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetGrandChildContainer.GetIfExists");
            scope.Start();
            try
            {
                if (availabilitySetGrandChildName == null)
                {
                    throw new ArgumentNullException(nameof(availabilitySetGrandChildName));
                }

                var response = _availabilitySetGrandChildRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, availabilitySetGrandChildName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AvailabilitySetGrandChild>(null, response.GetRawResponse())
                    : Response.FromValue(new AvailabilitySetGrandChild(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="availabilitySetGrandChildName"> The name of the availability set grand child. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetGrandChildName"/> is null. </exception>
        public async virtual Task<Response<AvailabilitySetGrandChild>> GetIfExistsAsync(string availabilitySetGrandChildName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetGrandChildContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                if (availabilitySetGrandChildName == null)
                {
                    throw new ArgumentNullException(nameof(availabilitySetGrandChildName));
                }

                var response = await _availabilitySetGrandChildRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, availabilitySetGrandChildName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AvailabilitySetGrandChild>(null, response.GetRawResponse())
                    : Response.FromValue(new AvailabilitySetGrandChild(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="availabilitySetGrandChildName"> The name of the availability set grand child. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetGrandChildName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string availabilitySetGrandChildName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetGrandChildContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (availabilitySetGrandChildName == null)
                {
                    throw new ArgumentNullException(nameof(availabilitySetGrandChildName));
                }

                var response = GetIfExists(availabilitySetGrandChildName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="availabilitySetGrandChildName"> The name of the availability set grand child. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetGrandChildName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string availabilitySetGrandChildName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetGrandChildContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                if (availabilitySetGrandChildName == null)
                {
                    throw new ArgumentNullException(nameof(availabilitySetGrandChildName));
                }

                var response = await GetIfExistsAsync(availabilitySetGrandChildName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, AvailabilitySetGrandChild, AvailabilitySetGrandChildData> Construct() { }
    }
}
