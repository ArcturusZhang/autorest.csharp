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

namespace MgmtScenarioTest
{
    /// <summary> A class to add extension methods to MgmtScenarioTest. </summary>
    public static partial class MgmtScenarioTestExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DeletedConfigurationStoreResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeletedConfigurationStoreResources and their operations over a DeletedConfigurationStoreResource. </returns>
        public static DeletedConfigurationStoreCollection GetDeletedConfigurationStores(this SubscriptionResource subscriptionResource)
        {
            return GetExtensionClient(subscriptionResource).GetDeletedConfigurationStores();
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="configStoreName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DeletedConfigurationStoreResource>> GetDeletedConfigurationStoreAsync(this SubscriptionResource subscriptionResource, string location, string configStoreName, CancellationToken cancellationToken = default)
        {
            return await subscriptionResource.GetDeletedConfigurationStores().GetAsync(location, configStoreName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="configStoreName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DeletedConfigurationStoreResource> GetDeletedConfigurationStore(this SubscriptionResource subscriptionResource, string location, string configStoreName, CancellationToken cancellationToken = default)
        {
            return subscriptionResource.GetDeletedConfigurationStores().Get(location, configStoreName, cancellationToken);
        }

        /// <summary>
        /// Lists the configuration stores for a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/configurationStores
        /// Operation Id: ConfigurationStores_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfigurationStoreResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ConfigurationStoreResource> GetConfigurationStoresAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetConfigurationStoresAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists the configuration stores for a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/configurationStores
        /// Operation Id: ConfigurationStores_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfigurationStoreResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ConfigurationStoreResource> GetConfigurationStores(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetConfigurationStores(skipToken, cancellationToken);
        }

        /// <summary>
        /// Gets information about the deleted configuration stores in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/deletedConfigurationStores
        /// Operation Id: ConfigurationStores_ListDeleted
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedConfigurationStoreResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeletedConfigurationStoreResource> GetDeletedConfigurationStoresAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDeletedConfigurationStoresAsync(cancellationToken);
        }

        /// <summary>
        /// Gets information about the deleted configuration stores in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/deletedConfigurationStores
        /// Operation Id: ConfigurationStores_ListDeleted
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedConfigurationStoreResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeletedConfigurationStoreResource> GetDeletedConfigurationStores(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDeletedConfigurationStores(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ConfigurationStoreResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ConfigurationStoreResources and their operations over a ConfigurationStoreResource. </returns>
        public static ConfigurationStoreCollection GetConfigurationStores(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetConfigurationStores();
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ConfigurationStoreResource>> GetConfigurationStoreAsync(this ResourceGroupResource resourceGroupResource, string configStoreName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetConfigurationStores().GetAsync(configStoreName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ConfigurationStoreResource> GetConfigurationStore(this ResourceGroupResource resourceGroupResource, string configStoreName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetConfigurationStores().Get(configStoreName, cancellationToken);
        }

        #region ConfigurationStoreResource
        /// <summary>
        /// Gets an object representing a <see cref="ConfigurationStoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConfigurationStoreResource.CreateResourceIdentifier" /> to create a <see cref="ConfigurationStoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConfigurationStoreResource" /> object. </returns>
        public static ConfigurationStoreResource GetConfigurationStoreResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ConfigurationStoreResource.ValidateResourceId(id);
                return new ConfigurationStoreResource(client, id);
            }
            );
        }
        #endregion

        #region DeletedConfigurationStoreResource
        /// <summary>
        /// Gets an object representing a <see cref="DeletedConfigurationStoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeletedConfigurationStoreResource.CreateResourceIdentifier" /> to create a <see cref="DeletedConfigurationStoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeletedConfigurationStoreResource" /> object. </returns>
        public static DeletedConfigurationStoreResource GetDeletedConfigurationStoreResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DeletedConfigurationStoreResource.ValidateResourceId(id);
                return new DeletedConfigurationStoreResource(client, id);
            }
            );
        }
        #endregion

        #region MgmtScenarioTestPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="MgmtScenarioTestPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MgmtScenarioTestPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="MgmtScenarioTestPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MgmtScenarioTestPrivateEndpointConnectionResource" /> object. </returns>
        public static MgmtScenarioTestPrivateEndpointConnectionResource GetMgmtScenarioTestPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MgmtScenarioTestPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new MgmtScenarioTestPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region MgmtScenarioTestPrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="MgmtScenarioTestPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MgmtScenarioTestPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="MgmtScenarioTestPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MgmtScenarioTestPrivateLinkResource" /> object. </returns>
        public static MgmtScenarioTestPrivateLinkResource GetMgmtScenarioTestPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MgmtScenarioTestPrivateLinkResource.ValidateResourceId(id);
                return new MgmtScenarioTestPrivateLinkResource(client, id);
            }
            );
        }
        #endregion

        #region KeyValueResource
        /// <summary>
        /// Gets an object representing a <see cref="KeyValueResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KeyValueResource.CreateResourceIdentifier" /> to create a <see cref="KeyValueResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KeyValueResource" /> object. </returns>
        public static KeyValueResource GetKeyValueResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                KeyValueResource.ValidateResourceId(id);
                return new KeyValueResource(client, id);
            }
            );
        }
        #endregion
    }
}
