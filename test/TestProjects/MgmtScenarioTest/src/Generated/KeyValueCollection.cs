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

namespace MgmtScenarioTest
{
    /// <summary>
    /// A class representing a collection of <see cref="KeyValueResource" /> and their operations.
    /// Each <see cref="KeyValueResource" /> in the collection will belong to the same instance of <see cref="ConfigurationStoreResource" />.
    /// To get a <see cref="KeyValueCollection" /> instance call the GetKeyValues method from an instance of <see cref="ConfigurationStoreResource" />.
    /// </summary>
    public partial class KeyValueCollection : ArmCollection, IEnumerable<KeyValueResource>, IAsyncEnumerable<KeyValueResource>
    {
        private readonly ClientDiagnostics _keyValueClientDiagnostics;
        private readonly KeyValuesRestOperations _keyValueRestClient;

        /// <summary> Initializes a new instance of the <see cref="KeyValueCollection"/> class for mocking. </summary>
        protected KeyValueCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KeyValueCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal KeyValueCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _keyValueClientDiagnostics = new ClientDiagnostics("MgmtScenarioTest", KeyValueResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(KeyValueResource.ResourceType, out string keyValueApiVersion);
            _keyValueRestClient = new KeyValuesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, keyValueApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ConfigurationStoreResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ConfigurationStoreResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a key-value.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}
        /// Operation Id: KeyValues_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="data"> The parameters for creating a key-value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual async Task<ArmOperation<KeyValueResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string keyValueName, KeyValueData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _keyValueClientDiagnostics.CreateScope("KeyValueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _keyValueRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtScenarioTestArmOperation<KeyValueResource>(Response.FromValue(new KeyValueResource(Client, response), response.GetRawResponse()));
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
        /// Creates a key-value.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}
        /// Operation Id: KeyValues_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="data"> The parameters for creating a key-value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual ArmOperation<KeyValueResource> CreateOrUpdate(WaitUntil waitUntil, string keyValueName, KeyValueData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _keyValueClientDiagnostics.CreateScope("KeyValueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _keyValueRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, data, cancellationToken);
                var operation = new MgmtScenarioTestArmOperation<KeyValueResource>(Response.FromValue(new KeyValueResource(Client, response), response.GetRawResponse()));
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
        /// Gets the properties of the specified key-value.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}
        /// Operation Id: KeyValues_Get
        /// </summary>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual async Task<Response<KeyValueResource>> GetAsync(string keyValueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _keyValueClientDiagnostics.CreateScope("KeyValueCollection.Get");
            scope.Start();
            try
            {
                var response = await _keyValueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KeyValueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified key-value.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}
        /// Operation Id: KeyValues_Get
        /// </summary>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual Response<KeyValueResource> Get(string keyValueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _keyValueClientDiagnostics.CreateScope("KeyValueCollection.Get");
            scope.Start();
            try
            {
                var response = _keyValueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KeyValueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the key-values for a given configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues
        /// Operation Id: KeyValues_ListByConfigurationStore
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KeyValueResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KeyValueResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<KeyValueResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _keyValueClientDiagnostics.CreateScope("KeyValueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _keyValueRestClient.ListByConfigurationStoreAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new KeyValueResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<KeyValueResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _keyValueClientDiagnostics.CreateScope("KeyValueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _keyValueRestClient.ListByConfigurationStoreNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new KeyValueResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the key-values for a given configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues
        /// Operation Id: KeyValues_ListByConfigurationStore
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KeyValueResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KeyValueResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<KeyValueResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _keyValueClientDiagnostics.CreateScope("KeyValueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _keyValueRestClient.ListByConfigurationStore(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new KeyValueResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<KeyValueResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _keyValueClientDiagnostics.CreateScope("KeyValueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _keyValueRestClient.ListByConfigurationStoreNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new KeyValueResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}
        /// Operation Id: KeyValues_Get
        /// </summary>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string keyValueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _keyValueClientDiagnostics.CreateScope("KeyValueCollection.Exists");
            scope.Start();
            try
            {
                var response = await _keyValueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}
        /// Operation Id: KeyValues_Get
        /// </summary>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual Response<bool> Exists(string keyValueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _keyValueClientDiagnostics.CreateScope("KeyValueCollection.Exists");
            scope.Start();
            try
            {
                var response = _keyValueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<KeyValueResource> IEnumerable<KeyValueResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<KeyValueResource> IAsyncEnumerable<KeyValueResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
