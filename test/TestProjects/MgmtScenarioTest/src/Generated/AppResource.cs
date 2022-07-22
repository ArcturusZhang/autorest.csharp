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
using MgmtScenarioTest.Models;

namespace MgmtScenarioTest
{
    /// <summary>
    /// A Class representing an AppResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AppResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAppResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServiceResource" /> using the GetAppResource method.
    /// </summary>
    public partial class AppResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AppResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string appName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _appResourceAppsClientDiagnostics;
        private readonly AppsRestOperations _appResourceAppsRestClient;
        private readonly AppResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="AppResource"/> class for mocking. </summary>
        protected AppResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AppResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AppResource(ArmClient client, AppResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AppResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appResourceAppsClientDiagnostics = new ClientDiagnostics("MgmtScenarioTest", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string appResourceAppsApiVersion);
            _appResourceAppsRestClient = new AppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appResourceAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppPlatform/Spring/apps";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppResourceData Data
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

        /// <summary> Gets a collection of BindingResources in the AppResource. </summary>
        /// <returns> An object representing collection of BindingResources and their operations over a BindingResource. </returns>
        public virtual BindingResourceCollection GetBindingResources()
        {
            return GetCachedClient(Client => new BindingResourceCollection(Client, Id));
        }

        /// <summary>
        /// Get a Binding and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}
        /// Operation Id: Bindings_Get
        /// </summary>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BindingResource>> GetBindingResourceAsync(string bindingName, CancellationToken cancellationToken = default)
        {
            return await GetBindingResources().GetAsync(bindingName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Binding and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/bindings/{bindingName}
        /// Operation Id: Bindings_Get
        /// </summary>
        /// <param name="bindingName"> The name of the Binding resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bindingName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<BindingResource> GetBindingResource(string bindingName, CancellationToken cancellationToken = default)
        {
            return GetBindingResources().Get(bindingName, cancellationToken);
        }

        /// <summary> Gets a collection of CustomDomainResources in the AppResource. </summary>
        /// <returns> An object representing collection of CustomDomainResources and their operations over a CustomDomainResource. </returns>
        public virtual CustomDomainResourceCollection GetCustomDomainResources()
        {
            return GetCachedClient(Client => new CustomDomainResourceCollection(Client, Id));
        }

        /// <summary>
        /// Get the custom domain of one lifecycle application.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}
        /// Operation Id: CustomDomains_Get
        /// </summary>
        /// <param name="domainName"> The name of the custom domain resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CustomDomainResource>> GetCustomDomainResourceAsync(string domainName, CancellationToken cancellationToken = default)
        {
            return await GetCustomDomainResources().GetAsync(domainName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the custom domain of one lifecycle application.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/domains/{domainName}
        /// Operation Id: CustomDomains_Get
        /// </summary>
        /// <param name="domainName"> The name of the custom domain resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<CustomDomainResource> GetCustomDomainResource(string domainName, CancellationToken cancellationToken = default)
        {
            return GetCustomDomainResources().Get(domainName, cancellationToken);
        }

        /// <summary> Gets a collection of DeploymentResources in the AppResource. </summary>
        /// <returns> An object representing collection of DeploymentResources and their operations over a DeploymentResource. </returns>
        public virtual DeploymentResourceCollection GetDeploymentResources()
        {
            return GetCachedClient(Client => new DeploymentResourceCollection(Client, Id));
        }

        /// <summary>
        /// Get a Deployment and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}
        /// Operation Id: Deployments_Get
        /// </summary>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DeploymentResource>> GetDeploymentResourceAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            return await GetDeploymentResources().GetAsync(deploymentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Deployment and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/deployments/{deploymentName}
        /// Operation Id: Deployments_Get
        /// </summary>
        /// <param name="deploymentName"> The name of the Deployment resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<DeploymentResource> GetDeploymentResource(string deploymentName, CancellationToken cancellationToken = default)
        {
            return GetDeploymentResources().Get(deploymentName, cancellationToken);
        }

        /// <summary>
        /// Get an App and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}
        /// Operation Id: Apps_Get
        /// </summary>
        /// <param name="syncStatus"> Indicates whether sync status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppResource>> GetAsync(string syncStatus = null, CancellationToken cancellationToken = default)
        {
            using var scope = _appResourceAppsClientDiagnostics.CreateScope("AppResource.Get");
            scope.Start();
            try
            {
                var response = await _appResourceAppsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncStatus, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an App and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}
        /// Operation Id: Apps_Get
        /// </summary>
        /// <param name="syncStatus"> Indicates whether sync status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppResource> Get(string syncStatus = null, CancellationToken cancellationToken = default)
        {
            using var scope = _appResourceAppsClientDiagnostics.CreateScope("AppResource.Get");
            scope.Start();
            try
            {
                var response = _appResourceAppsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, syncStatus, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Operation to delete an App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}
        /// Operation Id: Apps_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _appResourceAppsClientDiagnostics.CreateScope("AppResource.Delete");
            scope.Start();
            try
            {
                var response = await _appResourceAppsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtScenarioTestArmOperation(_appResourceAppsClientDiagnostics, Pipeline, _appResourceAppsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Operation to delete an App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}
        /// Operation Id: Apps_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _appResourceAppsClientDiagnostics.CreateScope("AppResource.Delete");
            scope.Start();
            try
            {
                var response = _appResourceAppsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MgmtScenarioTestArmOperation(_appResourceAppsClientDiagnostics, Pipeline, _appResourceAppsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Operation to update an exiting App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}
        /// Operation Id: Apps_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppResource>> UpdateAsync(WaitUntil waitUntil, AppResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appResourceAppsClientDiagnostics.CreateScope("AppResource.Update");
            scope.Start();
            try
            {
                var response = await _appResourceAppsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtScenarioTestArmOperation<AppResource>(new AppResourceOperationSource(Client), _appResourceAppsClientDiagnostics, Pipeline, _appResourceAppsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Operation to update an exiting App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}
        /// Operation Id: Apps_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppResource> Update(WaitUntil waitUntil, AppResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appResourceAppsClientDiagnostics.CreateScope("AppResource.Update");
            scope.Start();
            try
            {
                var response = _appResourceAppsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MgmtScenarioTestArmOperation<AppResource>(new AppResourceOperationSource(Client), _appResourceAppsClientDiagnostics, Pipeline, _appResourceAppsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get an resource upload URL for an App, which may be artifacts or source archive.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/getResourceUploadUrl
        /// Operation Id: Apps_GetResourceUploadUrl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceUploadDefinition>> GetResourceUploadUrlAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appResourceAppsClientDiagnostics.CreateScope("AppResource.GetResourceUploadUrl");
            scope.Start();
            try
            {
                var response = await _appResourceAppsRestClient.GetResourceUploadUrlAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an resource upload URL for an App, which may be artifacts or source archive.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/getResourceUploadUrl
        /// Operation Id: Apps_GetResourceUploadUrl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceUploadDefinition> GetResourceUploadUrl(CancellationToken cancellationToken = default)
        {
            using var scope = _appResourceAppsClientDiagnostics.CreateScope("AppResource.GetResourceUploadUrl");
            scope.Start();
            try
            {
                var response = _appResourceAppsRestClient.GetResourceUploadUrl(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the resource name is valid as well as not in use.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/validateDomain
        /// Operation Id: Apps_ValidateDomain
        /// </summary>
        /// <param name="validatePayload"> Custom domain payload to be validated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validatePayload"/> is null. </exception>
        public virtual async Task<Response<CustomDomainValidateResult>> ValidateDomainAsync(CustomDomainValidatePayload validatePayload, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(validatePayload, nameof(validatePayload));

            using var scope = _appResourceAppsClientDiagnostics.CreateScope("AppResource.ValidateDomain");
            scope.Start();
            try
            {
                var response = await _appResourceAppsRestClient.ValidateDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, validatePayload, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the resource name is valid as well as not in use.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/apps/{appName}/validateDomain
        /// Operation Id: Apps_ValidateDomain
        /// </summary>
        /// <param name="validatePayload"> Custom domain payload to be validated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validatePayload"/> is null. </exception>
        public virtual Response<CustomDomainValidateResult> ValidateDomain(CustomDomainValidatePayload validatePayload, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(validatePayload, nameof(validatePayload));

            using var scope = _appResourceAppsClientDiagnostics.CreateScope("AppResource.ValidateDomain");
            scope.Start();
            try
            {
                var response = _appResourceAppsRestClient.ValidateDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, validatePayload, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
