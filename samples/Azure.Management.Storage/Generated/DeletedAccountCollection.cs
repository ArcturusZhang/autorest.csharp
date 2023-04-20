// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.Management.Storage
{
    /// <summary>
    /// A class representing a collection of <see cref="DeletedAccountResource" /> and their operations.
    /// Each <see cref="DeletedAccountResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="DeletedAccountCollection" /> instance call the GetDeletedAccounts method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class DeletedAccountCollection : ArmCollection, IEnumerable<DeletedAccountResource>, IAsyncEnumerable<DeletedAccountResource>
    {
        private readonly ClientDiagnostics _deletedAccountClientDiagnostics;
        private readonly DeletedAccountsRestOperations _deletedAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeletedAccountCollection"/> class for mocking. </summary>
        protected DeletedAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeletedAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deletedAccountClientDiagnostics = new ClientDiagnostics("Azure.Management.Storage", DeletedAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeletedAccountResource.ResourceType, out string deletedAccountApiVersion);
            _deletedAccountRestClient = new DeletedAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deletedAccountApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get properties of specified deleted account resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedAccountName"/> is null. </exception>
        public virtual async Task<Response<DeletedAccountResource>> GetAsync(AzureLocation location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedAccountName, nameof(deletedAccountName));

            using var scope = _deletedAccountClientDiagnostics.CreateScope("DeletedAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _deletedAccountRestClient.GetAsync(Id.SubscriptionId, location, deletedAccountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedAccountResource(Client, response.Value, response.Value.Id), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of specified deleted account resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedAccountName"/> is null. </exception>
        public virtual Response<DeletedAccountResource> Get(AzureLocation location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedAccountName, nameof(deletedAccountName));

            using var scope = _deletedAccountClientDiagnostics.CreateScope("DeletedAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _deletedAccountRestClient.Get(Id.SubscriptionId, location, deletedAccountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedAccountResource(Client, response.Value, response.Value.Id), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists deleted accounts under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/deletedAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedAccountResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deletedAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deletedAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => { var data = DeletedAccountData.DeserializeDeletedAccountData(e); return new DeletedAccountResource(Client, data, data.Id); }, _deletedAccountClientDiagnostics, Pipeline, "DeletedAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists deleted accounts under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/deletedAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedAccountResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deletedAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deletedAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => { var data = DeletedAccountData.DeserializeDeletedAccountData(e); return new DeletedAccountResource(Client, data, data.Id); }, _deletedAccountClientDiagnostics, Pipeline, "DeletedAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedAccountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(AzureLocation location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedAccountName, nameof(deletedAccountName));

            using var scope = _deletedAccountClientDiagnostics.CreateScope("DeletedAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deletedAccountRestClient.GetAsync(Id.SubscriptionId, location, deletedAccountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/deletedAccounts/{deletedAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the deleted storage account. </param>
        /// <param name="deletedAccountName"> Name of the deleted storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedAccountName"/> is null. </exception>
        public virtual Response<bool> Exists(AzureLocation location, string deletedAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedAccountName, nameof(deletedAccountName));

            using var scope = _deletedAccountClientDiagnostics.CreateScope("DeletedAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _deletedAccountRestClient.Get(Id.SubscriptionId, location, deletedAccountName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeletedAccountResource> IEnumerable<DeletedAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeletedAccountResource> IAsyncEnumerable<DeletedAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
