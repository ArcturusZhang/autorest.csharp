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
using Azure.ResourceManager.Core;

namespace ExactMatchInheritance
{
    /// <summary> Extension methods for convenient access on SubscriptionOperations in a client. </summary>
    public static partial class SubscriptionExtensions
    {
        #region ExactMatchModel2s
        private static ExactMatchModel2SRestOperations GetExactMatchModel2SRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new ExactMatchModel2SRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
        }

        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="exactMatchModel2SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> placeholder. </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="exactMatchModel2SName"/>, or <paramref name="parameters"/> is null. </exception>
        public static Task<Response<ExactMatchModel2>> PutExactMatchModel2sAsync(this SubscriptionOperations subscription, string resourceGroupName, string exactMatchModel2SName, ExactMatchModel2 parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (exactMatchModel2SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel2SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetExactMatchModel2SRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                return PutExactMatchModel2sAsync(clientDiagnostics, restOperations, resourceGroupName, exactMatchModel2SName, parameters, cancellationToken);
            }
            );
        }

        /// <param name="_clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="exactMatchModel2SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="exactMatchModel2SName"/>, or <paramref name="parameters"/> is null. </exception>
        private static async Task<Response<ExactMatchModel2>> PutExactMatchModel2sAsync(ClientDiagnostics _clientDiagnostics, ExactMatchModel2SRestOperations restOperations, string resourceGroupName, string exactMatchModel2SName, ExactMatchModel2 parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (exactMatchModel2SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel2SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel2s.PutExactMatchModel2s");
            scope.Start();
            try
            {
                return await restOperations.PutAsync(resourceGroupName, exactMatchModel2SName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="exactMatchModel2SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> placeholder. </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="exactMatchModel2SName"/>, or <paramref name="parameters"/> is null. </exception>
        public static Response<ExactMatchModel2> PutExactMatchModel2s(this SubscriptionOperations subscription, string resourceGroupName, string exactMatchModel2SName, ExactMatchModel2 parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (exactMatchModel2SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel2SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetExactMatchModel2SRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                return PutExactMatchModel2s(clientDiagnostics, restOperations, resourceGroupName, exactMatchModel2SName, parameters, cancellationToken);
            }
            );
        }

        /// <param name="_clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="exactMatchModel2SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="exactMatchModel2SName"/>, or <paramref name="parameters"/> is null. </exception>
        private static Response<ExactMatchModel2> PutExactMatchModel2s(ClientDiagnostics _clientDiagnostics, ExactMatchModel2SRestOperations restOperations, string resourceGroupName, string exactMatchModel2SName, ExactMatchModel2 parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (exactMatchModel2SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel2SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel2s.PutExactMatchModel2s");
            scope.Start();
            try
            {
                return restOperations.Put(resourceGroupName, exactMatchModel2SName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        #endregion
        #region ExactMatchModel4s
        private static ExactMatchModel4SRestOperations GetExactMatchModel4SRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new ExactMatchModel4SRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
        }

        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="exactMatchModel4SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> placeholder. </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="exactMatchModel4SName"/>, or <paramref name="parameters"/> is null. </exception>
        public static Task<Response<ExactMatchModel4>> PutExactMatchModel4sAsync(this SubscriptionOperations subscription, string resourceGroupName, string exactMatchModel4SName, ExactMatchModel4 parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (exactMatchModel4SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel4SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetExactMatchModel4SRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                return PutExactMatchModel4sAsync(clientDiagnostics, restOperations, resourceGroupName, exactMatchModel4SName, parameters, cancellationToken);
            }
            );
        }

        /// <param name="_clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="exactMatchModel4SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="exactMatchModel4SName"/>, or <paramref name="parameters"/> is null. </exception>
        private static async Task<Response<ExactMatchModel4>> PutExactMatchModel4sAsync(ClientDiagnostics _clientDiagnostics, ExactMatchModel4SRestOperations restOperations, string resourceGroupName, string exactMatchModel4SName, ExactMatchModel4 parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (exactMatchModel4SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel4SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel4s.PutExactMatchModel4s");
            scope.Start();
            try
            {
                return await restOperations.PutAsync(resourceGroupName, exactMatchModel4SName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="exactMatchModel4SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> placeholder. </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="exactMatchModel4SName"/>, or <paramref name="parameters"/> is null. </exception>
        public static Response<ExactMatchModel4> PutExactMatchModel4s(this SubscriptionOperations subscription, string resourceGroupName, string exactMatchModel4SName, ExactMatchModel4 parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (exactMatchModel4SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel4SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetExactMatchModel4SRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                return PutExactMatchModel4s(clientDiagnostics, restOperations, resourceGroupName, exactMatchModel4SName, parameters, cancellationToken);
            }
            );
        }

        /// <param name="_clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="exactMatchModel4SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="exactMatchModel4SName"/>, or <paramref name="parameters"/> is null. </exception>
        private static Response<ExactMatchModel4> PutExactMatchModel4s(ClientDiagnostics _clientDiagnostics, ExactMatchModel4SRestOperations restOperations, string resourceGroupName, string exactMatchModel4SName, ExactMatchModel4 parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (exactMatchModel4SName == null)
            {
                throw new ArgumentNullException(nameof(exactMatchModel4SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExactMatchModel4s.PutExactMatchModel4s");
            scope.Start();
            try
            {
                return restOperations.Put(resourceGroupName, exactMatchModel4SName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        #endregion
    }
}
