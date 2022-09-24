// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using MgmtPolymorphicResources.Models;

namespace MgmtPolymorphicResources
{
    /// <summary>
    /// A Class representing a ThroughputSetting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ThroughputSettingResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetThroughputSettingResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetThroughputSetting method.
    /// </summary>
    public partial class ThroughputSettingResource : BaseThroughputSettingResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ThroughputSettingResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputSettings/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _throughputSettingCassandraResourcesClientDiagnostics;
        private readonly CassandraResourcesRestOperations _throughputSettingCassandraResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ThroughputSettingResource"/> class for mocking. </summary>
        protected ThroughputSettingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ThroughputSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ThroughputSettingResource(ArmClient client, ThroughputSettingData data) : base(client, data)
        {
            _throughputSettingCassandraResourcesClientDiagnostics = new ClientDiagnostics("MgmtPolymorphicResources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string throughputSettingCassandraResourcesApiVersion);
            _throughputSettingCassandraResourcesRestClient = new CassandraResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, throughputSettingCassandraResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ThroughputSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ThroughputSettingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _throughputSettingCassandraResourcesClientDiagnostics = new ClientDiagnostics("MgmtPolymorphicResources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string throughputSettingCassandraResourcesApiVersion);
            _throughputSettingCassandraResourcesRestClient = new CassandraResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, throughputSettingCassandraResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/throughputSettings";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the RUs per second of the Cassandra Keyspace under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ThroughputSettingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _throughputSettingCassandraResourcesClientDiagnostics.CreateScope("ThroughputSettingResource.Get");
            scope.Start();
            try
            {
                var response = await _throughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ThroughputSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the RUs per second of the Cassandra Keyspace under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ThroughputSettingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _throughputSettingCassandraResourcesClientDiagnostics.CreateScope("ThroughputSettingResource.Get");
            scope.Start();
            try
            {
                var response = _throughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughput(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ThroughputSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update RUs per second of an Azure Cosmos DB Cassandra Keyspace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputSettings/default
        /// Operation Id: CassandraResources_UpdateCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="updateThroughputParameters"> The RUs per second of the parameters to provide for the current Cassandra Keyspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ThroughputSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, ThroughputSettingsUpdateParameters updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(updateThroughputParameters, nameof(updateThroughputParameters));

            using var scope = _throughputSettingCassandraResourcesClientDiagnostics.CreateScope("ThroughputSettingResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _throughputSettingCassandraResourcesRestClient.UpdateCassandraKeyspaceThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, updateThroughputParameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtPolymorphicResourcesArmOperation<ThroughputSettingResource>(new ThroughputSettingOperationSource(Client), _throughputSettingCassandraResourcesClientDiagnostics, Pipeline, _throughputSettingCassandraResourcesRestClient.CreateUpdateCassandraKeyspaceThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, updateThroughputParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Update RUs per second of an Azure Cosmos DB Cassandra Keyspace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputSettings/default
        /// Operation Id: CassandraResources_UpdateCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="updateThroughputParameters"> The RUs per second of the parameters to provide for the current Cassandra Keyspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public virtual ArmOperation<ThroughputSettingResource> CreateOrUpdate(WaitUntil waitUntil, ThroughputSettingsUpdateParameters updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(updateThroughputParameters, nameof(updateThroughputParameters));

            using var scope = _throughputSettingCassandraResourcesClientDiagnostics.CreateScope("ThroughputSettingResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _throughputSettingCassandraResourcesRestClient.UpdateCassandraKeyspaceThroughput(Id.SubscriptionId, Id.ResourceGroupName, updateThroughputParameters, cancellationToken);
                var operation = new MgmtPolymorphicResourcesArmOperation<ThroughputSettingResource>(new ThroughputSettingOperationSource(Client), _throughputSettingCassandraResourcesClientDiagnostics, Pipeline, _throughputSettingCassandraResourcesRestClient.CreateUpdateCassandraKeyspaceThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, updateThroughputParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<ThroughputSettingResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _throughputSettingCassandraResourcesClientDiagnostics.CreateScope("ThroughputSettingResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _throughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new ThroughputSettingResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new ThroughputSettingsUpdateParameters(current.Location);
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = await CreateOrUpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<ThroughputSettingResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _throughputSettingCassandraResourcesClientDiagnostics.CreateScope("ThroughputSettingResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _throughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughput(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                    return Response.FromValue(new ThroughputSettingResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new ThroughputSettingsUpdateParameters(current.Location);
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = CreateOrUpdate(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<ThroughputSettingResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _throughputSettingCassandraResourcesClientDiagnostics.CreateScope("ThroughputSettingResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _throughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new ThroughputSettingResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new ThroughputSettingsUpdateParameters(current.Location);
                    patch.Tags.ReplaceWith(tags);
                    var result = await CreateOrUpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<ThroughputSettingResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _throughputSettingCassandraResourcesClientDiagnostics.CreateScope("ThroughputSettingResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _throughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughput(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                    return Response.FromValue(new ThroughputSettingResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new ThroughputSettingsUpdateParameters(current.Location);
                    patch.Tags.ReplaceWith(tags);
                    var result = CreateOrUpdate(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<ThroughputSettingResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _throughputSettingCassandraResourcesClientDiagnostics.CreateScope("ThroughputSettingResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _throughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new ThroughputSettingResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new ThroughputSettingsUpdateParameters(current.Location);
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = await CreateOrUpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/throughputSettings/default
        /// Operation Id: CassandraResources_GetCassandraKeyspaceThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<ThroughputSettingResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _throughputSettingCassandraResourcesClientDiagnostics.CreateScope("ThroughputSettingResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _throughputSettingCassandraResourcesRestClient.GetCassandraKeyspaceThroughput(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                    return Response.FromValue(new ThroughputSettingResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new ThroughputSettingsUpdateParameters(current.Location);
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = CreateOrUpdate(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
