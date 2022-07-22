// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using MgmtScenarioTest.Models;

namespace MgmtScenarioTest
{
    /// <summary> A class to add extension methods to MgmtScenarioTest. </summary>
    public static partial class MgmtScenarioTestExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary>
        /// Lists all of the available runtime versions supported by Microsoft.AppPlatform provider.
        /// Request Path: /providers/Microsoft.AppPlatform/runtimeVersions
        /// Operation Id: RuntimeVersions_ListRuntimeVersions
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SupportedRuntimeVersion" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SupportedRuntimeVersion> GetRuntimeVersionsRuntimeVersionsAsync(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenantResource).GetRuntimeVersionsRuntimeVersionsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all of the available runtime versions supported by Microsoft.AppPlatform provider.
        /// Request Path: /providers/Microsoft.AppPlatform/runtimeVersions
        /// Operation Id: RuntimeVersions_ListRuntimeVersions
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SupportedRuntimeVersion" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SupportedRuntimeVersion> GetRuntimeVersionsRuntimeVersions(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenantResource).GetRuntimeVersionsRuntimeVersions(cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Checks that the resource name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppPlatform/locations/{location}/checkNameAvailability
        /// Operation Id: Services_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> the region. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<NameAvailability>> CheckNameAvailabilityServiceAsync(this SubscriptionResource subscriptionResource, string location, NameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckNameAvailabilityServiceAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks that the resource name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppPlatform/locations/{location}/checkNameAvailability
        /// Operation Id: Services_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> the region. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="content"/> is null. </exception>
        public static Response<NameAvailability> CheckNameAvailabilityService(this SubscriptionResource subscriptionResource, string location, NameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckNameAvailabilityService(location, content, cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppPlatform/Spring
        /// Operation Id: Services_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ServiceResource> GetServiceResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetServiceResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppPlatform/Spring
        /// Operation Id: Services_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ServiceResource> GetServiceResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetServiceResources(cancellationToken);
        }

        /// <summary>
        /// Lists all of the available skus of the Microsoft.AppPlatform provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppPlatform/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceSku" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceSku> GetSkusAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSkusAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all of the available skus of the Microsoft.AppPlatform provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppPlatform/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceSku" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceSku> GetSkus(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSkus(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ServiceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ServiceResources and their operations over a ServiceResource. </returns>
        public static ServiceResourceCollection GetServiceResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetServiceResources();
        }

        /// <summary>
        /// Get a Service and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}
        /// Operation Id: Services_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ServiceResource>> GetServiceResourceAsync(this ResourceGroupResource resourceGroupResource, string serviceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetServiceResources().GetAsync(serviceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Service and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}
        /// Operation Id: Services_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serviceName"> The name of the Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ServiceResource> GetServiceResource(this ResourceGroupResource resourceGroupResource, string serviceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetServiceResources().Get(serviceName, cancellationToken);
        }

        #region ServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="ServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceResource.CreateResourceIdentifier" /> to create a <see cref="ServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceResource" /> object. </returns>
        public static ServiceResource GetServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServiceResource.ValidateResourceId(id);
                return new ServiceResource(client, id);
            }
            );
        }
        #endregion

        #region ConfigServerResource
        /// <summary>
        /// Gets an object representing a <see cref="ConfigServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConfigServerResource.CreateResourceIdentifier" /> to create a <see cref="ConfigServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConfigServerResource" /> object. </returns>
        public static ConfigServerResource GetConfigServerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ConfigServerResource.ValidateResourceId(id);
                return new ConfigServerResource(client, id);
            }
            );
        }
        #endregion

        #region MonitoringSettingResource
        /// <summary>
        /// Gets an object representing a <see cref="MonitoringSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MonitoringSettingResource.CreateResourceIdentifier" /> to create a <see cref="MonitoringSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MonitoringSettingResource" /> object. </returns>
        public static MonitoringSettingResource GetMonitoringSettingResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MonitoringSettingResource.ValidateResourceId(id);
                return new MonitoringSettingResource(client, id);
            }
            );
        }
        #endregion

        #region AppResource
        /// <summary>
        /// Gets an object representing an <see cref="AppResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppResource.CreateResourceIdentifier" /> to create an <see cref="AppResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppResource" /> object. </returns>
        public static AppResource GetAppResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AppResource.ValidateResourceId(id);
                return new AppResource(client, id);
            }
            );
        }
        #endregion

        #region BindingResource
        /// <summary>
        /// Gets an object representing a <see cref="BindingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BindingResource.CreateResourceIdentifier" /> to create a <see cref="BindingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BindingResource" /> object. </returns>
        public static BindingResource GetBindingResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BindingResource.ValidateResourceId(id);
                return new BindingResource(client, id);
            }
            );
        }
        #endregion

        #region CertificateResource
        /// <summary>
        /// Gets an object representing a <see cref="CertificateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CertificateResource.CreateResourceIdentifier" /> to create a <see cref="CertificateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CertificateResource" /> object. </returns>
        public static CertificateResource GetCertificateResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                CertificateResource.ValidateResourceId(id);
                return new CertificateResource(client, id);
            }
            );
        }
        #endregion

        #region CustomDomainResource
        /// <summary>
        /// Gets an object representing a <see cref="CustomDomainResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CustomDomainResource.CreateResourceIdentifier" /> to create a <see cref="CustomDomainResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CustomDomainResource" /> object. </returns>
        public static CustomDomainResource GetCustomDomainResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                CustomDomainResource.ValidateResourceId(id);
                return new CustomDomainResource(client, id);
            }
            );
        }
        #endregion

        #region DeploymentResource
        /// <summary>
        /// Gets an object representing a <see cref="DeploymentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeploymentResource.CreateResourceIdentifier" /> to create a <see cref="DeploymentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeploymentResource" /> object. </returns>
        public static DeploymentResource GetDeploymentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DeploymentResource.ValidateResourceId(id);
                return new DeploymentResource(client, id);
            }
            );
        }
        #endregion
    }
}
