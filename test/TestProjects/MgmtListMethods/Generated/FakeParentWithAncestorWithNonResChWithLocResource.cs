// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary>
    /// A Class representing a FakeParentWithAncestorWithNonResChWithLoc along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="FakeParentWithAncestorWithNonResChWithLocResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetFakeParentWithAncestorWithNonResChWithLocResource method.
    /// Otherwise you can get one from its parent resource <see cref="FakeResource"/> using the GetFakeParentWithAncestorWithNonResChWithLoc method.
    /// </summary>
    public partial class FakeParentWithAncestorWithNonResChWithLocResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FakeParentWithAncestorWithNonResChWithLocResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="fakeName"> The fakeName. </param>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> The fakeParentWithAncestorWithNonResChWithLocName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string fakeName, string fakeParentWithAncestorWithNonResChWithLocName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics;
        private readonly FakeParentWithAncestorWithNonResChWithLocsRestOperations _fakeParentWithAncestorWithNonResChWithLocRestClient;
        private readonly FakeParentWithAncestorWithNonResChWithLocData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Fake/fakes/fakeParentWithAncestorWithNonResChWithLocs";

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorWithNonResChWithLocResource"/> class for mocking. </summary>
        protected FakeParentWithAncestorWithNonResChWithLocResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorWithNonResChWithLocResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FakeParentWithAncestorWithNonResChWithLocResource(ArmClient client, FakeParentWithAncestorWithNonResChWithLocData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorWithNonResChWithLocResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FakeParentWithAncestorWithNonResChWithLocResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string fakeParentWithAncestorWithNonResChWithLocApiVersion);
            _fakeParentWithAncestorWithNonResChWithLocRestClient = new FakeParentWithAncestorWithNonResChWithLocsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, fakeParentWithAncestorWithNonResChWithLocApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FakeParentWithAncestorWithNonResChWithLocData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithNonResChWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FakeParentWithAncestorWithNonResChWithLocResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.Get");
            scope.Start();
            try
            {
                var response = await _fakeParentWithAncestorWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithNonResChWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FakeParentWithAncestorWithNonResChWithLocResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.Get");
            scope.Start();
            try
            {
                var response = _fakeParentWithAncestorWithNonResChWithLocRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithNonResChWithLocs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FakeParentWithAncestorWithNonResChWithLocResource>> UpdateAsync(WaitUntil waitUntil, FakeParentWithAncestorWithNonResChWithLocData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.Update");
            scope.Start();
            try
            {
                var response = await _fakeParentWithAncestorWithNonResChWithLocRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtListMethodsArmOperation<FakeParentWithAncestorWithNonResChWithLocResource>(Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, response), response.GetRawResponse()));
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
        /// Create or update.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithNonResChWithLocs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FakeParentWithAncestorWithNonResChWithLocResource> Update(WaitUntil waitUntil, FakeParentWithAncestorWithNonResChWithLocData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.Update");
            scope.Start();
            try
            {
                var response = _fakeParentWithAncestorWithNonResChWithLocRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MgmtListMethodsArmOperation<FakeParentWithAncestorWithNonResChWithLocResource>(Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, response), response.GetRawResponse()));
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
        /// Lists all.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}/nonResourceChild</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithNonResChWithLocs_ListNonResourceChild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NonResourceChild"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NonResourceChild> GetNonResourceChildAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fakeParentWithAncestorWithNonResChWithLocRestClient.CreateListNonResourceChildRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => NonResourceChild.DeserializeNonResourceChild(e), _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics, Pipeline, "FakeParentWithAncestorWithNonResChWithLocResource.GetNonResourceChild", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}/nonResourceChild</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithNonResChWithLocs_ListNonResourceChild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NonResourceChild"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NonResourceChild> GetNonResourceChild(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fakeParentWithAncestorWithNonResChWithLocRestClient.CreateListNonResourceChildRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => NonResourceChild.DeserializeNonResourceChild(e), _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics, Pipeline, "FakeParentWithAncestorWithNonResChWithLocResource.GetNonResourceChild", "value", null, cancellationToken);
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithNonResChWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<FakeParentWithAncestorWithNonResChWithLocResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _fakeParentWithAncestorWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags[key] = value;
                    var result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithNonResChWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorWithNonResChWithLocResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _fakeParentWithAncestorWithNonResChWithLocRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                    return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    current.Tags[key] = value;
                    var result = Update(WaitUntil.Completed, current, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithNonResChWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<FakeParentWithAncestorWithNonResChWithLocResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _fakeParentWithAncestorWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithNonResChWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorWithNonResChWithLocResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _fakeParentWithAncestorWithNonResChWithLocRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                    return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    current.Tags.ReplaceWith(tags);
                    var result = Update(WaitUntil.Completed, current, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithNonResChWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<FakeParentWithAncestorWithNonResChWithLocResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _fakeParentWithAncestorWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags.Remove(key);
                    var result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakeParentWithAncestorWithNonResChWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorWithNonResChWithLocResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _fakeParentWithAncestorWithNonResChWithLocRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                    return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    current.Tags.Remove(key);
                    var result = Update(WaitUntil.Completed, current, cancellationToken: cancellationToken);
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
