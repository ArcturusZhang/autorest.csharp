// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace TypeSpec.Versioning.Specific
{
    // Data plane generated client.
    /// <summary> The Specific service client. </summary>
    public partial class SpecificClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of SpecificClient for mocking. </summary>
        protected SpecificClient()
        {
        }

        /// <summary> Initializes a new instance of SpecificClient. </summary>
        /// <param name="endpoint"> Service endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public SpecificClient(Uri endpoint) : this(endpoint, new SpecificClientOptions())
        {
        }

        /// <summary> Initializes a new instance of SpecificClient. </summary>
        /// <param name="endpoint"> Service endpoint. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public SpecificClient(Uri endpoint, SpecificClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new SpecificClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
        }

        private Resource _cachedResource;

        /// <summary> Initializes a new instance of Resource. </summary>
        public virtual Resource GetResourceClient()
        {
            return Volatile.Read(ref _cachedResource) ?? Interlocked.CompareExchange(ref _cachedResource, new Resource(ClientDiagnostics, _pipeline), null) ?? _cachedResource;
        }

        /// <summary> Initializes a new instance of VersioningOp. </summary>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual VersioningOp GetVersioningOpClient(string apiVersion = "2022-12-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new VersioningOp(ClientDiagnostics, _pipeline, _endpoint, apiVersion);
        }
    }
}
