// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using ExactMatchFlattenInheritance.Models;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region AzureResourceFlattenModel1
        /// <summary> Gets an object representing a AzureResourceFlattenModel1Container along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="AzureResourceFlattenModel1Container" /> object. </returns>
        public static AzureResourceFlattenModel1Container GetAzureResourceFlattenModel1s(this ResourceGroup resourceGroup)
        {
            return new AzureResourceFlattenModel1Container(resourceGroup);
        }
        #endregion

        #region CustomModel2
        /// <summary> Gets an object representing a CustomModel2Container along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="CustomModel2Container" /> object. </returns>
        public static CustomModel2Container GetCustomModel2s(this ResourceGroup resourceGroup)
        {
            return new CustomModel2Container(resourceGroup);
        }
        #endregion

        #region CustomModel3
        /// <summary> Gets an object representing a CustomModel3Container along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="CustomModel3Container" /> object. </returns>
        public static CustomModel3Container GetCustomModel3s(this ResourceGroup resourceGroup)
        {
            return new CustomModel3Container(resourceGroup);
        }
        #endregion

        private static AzureResourceFlattenModel2SRestOperations GetAzureResourceFlattenModel2SRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new AzureResourceFlattenModel2SRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        private static AzureResourceFlattenModel3SRestOperations GetAzureResourceFlattenModel3SRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new AzureResourceFlattenModel3SRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        private static AzureResourceFlattenModel4SRestOperations GetAzureResourceFlattenModel4SRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new AzureResourceFlattenModel4SRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        private static AzureResourceFlattenModel5SRestOperations GetAzureResourceFlattenModel5SRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new AzureResourceFlattenModel5SRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        /// <summary> Create or update an AzureResourceFlattenModel2. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<AzureResourceFlattenModel2>> PutAzureResourceFlattenModel2Async(this ResourceGroup resourceGroup, string name, AzureResourceFlattenModel2 parameters, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PutAzureResourceFlattenModel2");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel2SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = await restOperations.PutAsync(resourceGroup.Id.ResourceGroupName, name, parameters, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Create or update an AzureResourceFlattenModel2. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public static Response<AzureResourceFlattenModel2> PutAzureResourceFlattenModel2(this ResourceGroup resourceGroup, string name, AzureResourceFlattenModel2 parameters, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PutAzureResourceFlattenModel2");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel2SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = restOperations.Put(resourceGroup.Id.ResourceGroupName, name, parameters, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Get an AzureResourceFlattenModel2. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<AzureResourceFlattenModel2>> GetAzureResourceFlattenModel2Async(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetAzureResourceFlattenModel2");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel2SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = await restOperations.GetAsync(resourceGroup.Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Get an AzureResourceFlattenModel2. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<AzureResourceFlattenModel2> GetAzureResourceFlattenModel2(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetAzureResourceFlattenModel2");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel2SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = restOperations.Get(resourceGroup.Id.ResourceGroupName, name, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Create or update an AzureResourceFlattenModel3. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<AzureResourceFlattenModel3>> PutAzureResourceFlattenModel3Async(this ResourceGroup resourceGroup, string name, AzureResourceFlattenModel3 parameters, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PutAzureResourceFlattenModel3");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel3SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = await restOperations.PutAsync(resourceGroup.Id.ResourceGroupName, name, parameters, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Create or update an AzureResourceFlattenModel3. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public static Response<AzureResourceFlattenModel3> PutAzureResourceFlattenModel3(this ResourceGroup resourceGroup, string name, AzureResourceFlattenModel3 parameters, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PutAzureResourceFlattenModel3");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel3SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = restOperations.Put(resourceGroup.Id.ResourceGroupName, name, parameters, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Get an AzureResourceFlattenModel3. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<AzureResourceFlattenModel3>> GetAzureResourceFlattenModel3Async(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetAzureResourceFlattenModel3");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel3SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = await restOperations.GetAsync(resourceGroup.Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Get an AzureResourceFlattenModel3. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<AzureResourceFlattenModel3> GetAzureResourceFlattenModel3(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetAzureResourceFlattenModel3");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel3SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = restOperations.Get(resourceGroup.Id.ResourceGroupName, name, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Create or update an AzureResourceFlattenModel4. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<AzureResourceFlattenModel4>> PutAzureResourceFlattenModel4Async(this ResourceGroup resourceGroup, string name, AzureResourceFlattenModel4 parameters, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PutAzureResourceFlattenModel4");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel4SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = await restOperations.PutAsync(resourceGroup.Id.ResourceGroupName, name, parameters, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Create or update an AzureResourceFlattenModel4. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public static Response<AzureResourceFlattenModel4> PutAzureResourceFlattenModel4(this ResourceGroup resourceGroup, string name, AzureResourceFlattenModel4 parameters, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PutAzureResourceFlattenModel4");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel4SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = restOperations.Put(resourceGroup.Id.ResourceGroupName, name, parameters, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Get an AzureResourceFlattenModel4. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<AzureResourceFlattenModel4>> GetAzureResourceFlattenModel4Async(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetAzureResourceFlattenModel4");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel4SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = await restOperations.GetAsync(resourceGroup.Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Get an AzureResourceFlattenModel4. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<AzureResourceFlattenModel4> GetAzureResourceFlattenModel4(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetAzureResourceFlattenModel4");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel4SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = restOperations.Get(resourceGroup.Id.ResourceGroupName, name, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Create or update an AzureResourceFlattenModel5. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="foo"> New property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<AzureResourceFlattenModel5>> PutAzureResourceFlattenModel5Async(this ResourceGroup resourceGroup, string name, int? foo = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PutAzureResourceFlattenModel5");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel5SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = await restOperations.PutAsync(resourceGroup.Id.ResourceGroupName, name, foo, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Create or update an AzureResourceFlattenModel5. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="foo"> New property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<AzureResourceFlattenModel5> PutAzureResourceFlattenModel5(this ResourceGroup resourceGroup, string name, int? foo = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PutAzureResourceFlattenModel5");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel5SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = restOperations.Put(resourceGroup.Id.ResourceGroupName, name, foo, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Get an AzureResourceFlattenModel5. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<AzureResourceFlattenModel5>> GetAzureResourceFlattenModel5Async(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetAzureResourceFlattenModel5");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel5SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = await restOperations.GetAsync(resourceGroup.Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Get an AzureResourceFlattenModel5. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<AzureResourceFlattenModel5> GetAzureResourceFlattenModel5(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetAzureResourceFlattenModel5");
                scope.Start();
                try
                {
                    var restOperations = GetAzureResourceFlattenModel5SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = restOperations.Get(resourceGroup.Id.ResourceGroupName, name, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }
    }
}
