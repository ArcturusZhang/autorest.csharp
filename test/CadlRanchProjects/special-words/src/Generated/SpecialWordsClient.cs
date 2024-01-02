// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace SpecialWords
{
    // Data plane generated client.
    /// <summary> The SpecialWords service client. </summary>
    public partial class SpecialWordsClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of SpecialWordsClient. </summary>
        public SpecialWordsClient() : this(new Uri("http://localhost:3000"), new SpecialWordsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of SpecialWordsClient. </summary>
        /// <param name="endpoint"> TestServer endpoint. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public SpecialWordsClient(Uri endpoint, SpecialWordsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new SpecialWordsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
        }

        private Models _cachedModels;
        private ModelProperties _cachedModelProperties;
        private Operations _cachedOperations;
        private Parameters _cachedParameters;

        /// <summary> Initializes a new instance of Models. </summary>
        public virtual Models GetModelsClient()
        {
            return Volatile.Read(ref _cachedModels) ?? Interlocked.CompareExchange(ref _cachedModels, new Models(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedModels;
        }

        /// <summary> Initializes a new instance of ModelProperties. </summary>
        public virtual ModelProperties GetModelPropertiesClient()
        {
            return Volatile.Read(ref _cachedModelProperties) ?? Interlocked.CompareExchange(ref _cachedModelProperties, new ModelProperties(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedModelProperties;
        }

        /// <summary> Initializes a new instance of Operations. </summary>
        public virtual Operations GetOperationsClient()
        {
            return Volatile.Read(ref _cachedOperations) ?? Interlocked.CompareExchange(ref _cachedOperations, new Operations(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedOperations;
        }

        /// <summary> Initializes a new instance of Parameters. </summary>
        public virtual Parameters GetParametersClient()
        {
            return Volatile.Read(ref _cachedParameters) ?? Interlocked.CompareExchange(ref _cachedParameters, new Parameters(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedParameters;
        }
    }
}
