// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtSubscriptionNameParameter
{
    /// <summary>
    /// A Class representing a SBSubscription along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SBSubscriptionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSBSubscriptionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetSBSubscription method.
    /// </summary>
    public partial class SBSubscriptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SBSubscriptionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string subscriptionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sbSubscriptionSubscriptionsClientDiagnostics;
        private readonly SubscriptionsRestOperations _sbSubscriptionSubscriptionsRestClient;
        private readonly SBSubscriptionData _data;

        /// <summary> Initializes a new instance of the <see cref="SBSubscriptionResource"/> class for mocking. </summary>
        protected SBSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SBSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        /// <param name="id"> The resource identifier of the resource. </param>
        internal SBSubscriptionResource(ArmClient client, SBSubscriptionData data, ResourceIdentifier id) : this(client, id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SBSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SBSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sbSubscriptionSubscriptionsClientDiagnostics = new ClientDiagnostics("MgmtSubscriptionNameParameter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sbSubscriptionSubscriptionsApiVersion);
            _sbSubscriptionSubscriptionsRestClient = new SubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sbSubscriptionSubscriptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/subscriptions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SBSubscriptionData Data
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
        /// Returns a subscription description for the specified topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscriptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SBSubscriptionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = await _sbSubscriptionSubscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SBSubscriptionResource(Client, response.Value, response.Value.Id), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a subscription description for the specified topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscriptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SBSubscriptionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = _sbSubscriptionSubscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SBSubscriptionResource(Client, response.Value, response.Value.Id), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a subscription from the specified topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscriptions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = await _sbSubscriptionSubscriptionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtSubscriptionNameParameterArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a subscription from the specified topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscriptions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = _sbSubscriptionSubscriptionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new MgmtSubscriptionNameParameterArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a topic subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscriptions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to create a subscription resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SBSubscriptionResource>> UpdateAsync(WaitUntil waitUntil, SBSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionResource.Update");
            scope.Start();
            try
            {
                var response = await _sbSubscriptionSubscriptionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtSubscriptionNameParameterArmOperation<SBSubscriptionResource>(Response.FromValue(new SBSubscriptionResource(Client, response.Value, response.Value.Id), response.GetRawResponse()));
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
        /// Creates a topic subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscriptions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to create a subscription resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SBSubscriptionResource> Update(WaitUntil waitUntil, SBSubscriptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionResource.Update");
            scope.Start();
            try
            {
                var response = _sbSubscriptionSubscriptionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, cancellationToken);
                var operation = new MgmtSubscriptionNameParameterArmOperation<SBSubscriptionResource>(Response.FromValue(new SBSubscriptionResource(Client, response.Value, response.Value.Id), response.GetRawResponse()));
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
    }
}
