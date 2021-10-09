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
using SupersetInheritance.Models;

namespace SupersetInheritance
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region SupersetModel1
        /// <summary> Gets an object representing a SupersetModel1Container along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="SupersetModel1Container" /> object. </returns>
        public static SupersetModel1Container GetSupersetModel1s(this ResourceGroup resourceGroup)
        {
            return new SupersetModel1Container(resourceGroup);
        }
        #endregion

        #region SupersetModel4
        /// <summary> Gets an object representing a SupersetModel4Container along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="SupersetModel4Container" /> object. </returns>
        public static SupersetModel4Container GetSupersetModel4s(this ResourceGroup resourceGroup)
        {
            return new SupersetModel4Container(resourceGroup);
        }
        #endregion

        private static SupersetModel2SRestOperations GetSupersetModel2SRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new SupersetModel2SRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        private static SupersetModel3SRestOperations GetSupersetModel3SRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new SupersetModel3SRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="supersetModel2SName"> The String to use. </param>
        /// <param name="parameters"> The SupersetModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel2SName"/> or <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<SupersetModel2>> PutSupersetModel2Async(this ResourceGroup resourceGroup, string supersetModel2SName, SupersetModel2 parameters, CancellationToken cancellationToken = default)
        {
            if (supersetModel2SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel2SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PutSupersetModel2");
                scope.Start();
                try
                {
                    var restOperations = GetSupersetModel2SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = await restOperations.PutAsync(resourceGroup.Id.ResourceGroupName, supersetModel2SName, parameters, cancellationToken).ConfigureAwait(false);
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

        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="supersetModel2SName"> The String to use. </param>
        /// <param name="parameters"> The SupersetModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel2SName"/> or <paramref name="parameters"/> is null. </exception>
        public static Response<SupersetModel2> PutSupersetModel2(this ResourceGroup resourceGroup, string supersetModel2SName, SupersetModel2 parameters, CancellationToken cancellationToken = default)
        {
            if (supersetModel2SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel2SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PutSupersetModel2");
                scope.Start();
                try
                {
                    var restOperations = GetSupersetModel2SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = restOperations.Put(resourceGroup.Id.ResourceGroupName, supersetModel2SName, parameters, cancellationToken);
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

        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="supersetModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel2SName"/> is null. </exception>
        public static async Task<Response<SupersetModel2>> GetSupersetModel2Async(this ResourceGroup resourceGroup, string supersetModel2SName, CancellationToken cancellationToken = default)
        {
            if (supersetModel2SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel2SName));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetSupersetModel2");
                scope.Start();
                try
                {
                    var restOperations = GetSupersetModel2SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = await restOperations.GetAsync(resourceGroup.Id.ResourceGroupName, supersetModel2SName, cancellationToken).ConfigureAwait(false);
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

        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="supersetModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel2SName"/> is null. </exception>
        public static Response<SupersetModel2> GetSupersetModel2(this ResourceGroup resourceGroup, string supersetModel2SName, CancellationToken cancellationToken = default)
        {
            if (supersetModel2SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel2SName));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetSupersetModel2");
                scope.Start();
                try
                {
                    var restOperations = GetSupersetModel2SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = restOperations.Get(resourceGroup.Id.ResourceGroupName, supersetModel2SName, cancellationToken);
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

        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="supersetModel3SName"> The String to use. </param>
        /// <param name="parameters"> The SupersetModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel3SName"/> or <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<SupersetModel3>> PutSupersetModel3Async(this ResourceGroup resourceGroup, string supersetModel3SName, SupersetModel3 parameters, CancellationToken cancellationToken = default)
        {
            if (supersetModel3SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel3SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PutSupersetModel3");
                scope.Start();
                try
                {
                    var restOperations = GetSupersetModel3SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = await restOperations.PutAsync(resourceGroup.Id.ResourceGroupName, supersetModel3SName, parameters, cancellationToken).ConfigureAwait(false);
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

        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="supersetModel3SName"> The String to use. </param>
        /// <param name="parameters"> The SupersetModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel3SName"/> or <paramref name="parameters"/> is null. </exception>
        public static Response<SupersetModel3> PutSupersetModel3(this ResourceGroup resourceGroup, string supersetModel3SName, SupersetModel3 parameters, CancellationToken cancellationToken = default)
        {
            if (supersetModel3SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel3SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PutSupersetModel3");
                scope.Start();
                try
                {
                    var restOperations = GetSupersetModel3SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = restOperations.Put(resourceGroup.Id.ResourceGroupName, supersetModel3SName, parameters, cancellationToken);
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

        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="supersetModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel3SName"/> is null. </exception>
        public static async Task<Response<SupersetModel3>> GetSupersetModel3Async(this ResourceGroup resourceGroup, string supersetModel3SName, CancellationToken cancellationToken = default)
        {
            if (supersetModel3SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel3SName));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetSupersetModel3");
                scope.Start();
                try
                {
                    var restOperations = GetSupersetModel3SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = await restOperations.GetAsync(resourceGroup.Id.ResourceGroupName, supersetModel3SName, cancellationToken).ConfigureAwait(false);
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

        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="supersetModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel3SName"/> is null. </exception>
        public static Response<SupersetModel3> GetSupersetModel3(this ResourceGroup resourceGroup, string supersetModel3SName, CancellationToken cancellationToken = default)
        {
            if (supersetModel3SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel3SName));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetSupersetModel3");
                scope.Start();
                try
                {
                    var restOperations = GetSupersetModel3SRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                    var response = restOperations.Get(resourceGroup.Id.ResourceGroupName, supersetModel3SName, cancellationToken);
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
