// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Encode.Duration
{
    // Data plane generated sub-client.
    /// <summary> The Header sub-client. </summary>
    public partial class Header
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Header for mocking. </summary>
        protected Header()
        {
        }

        /// <summary> Initializes a new instance of Header. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> TestServer endpoint. </param>
        internal Header(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _endpoint = endpoint;
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Default.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="duration"> The <see cref="TimeSpan"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='DefaultAsync(TimeSpan,RequestContext)']/*" />
        public virtual async Task<Response> DefaultAsync(TimeSpan duration, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("Header.Default");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDefaultRequest(duration, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Default.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="duration"> The <see cref="TimeSpan"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Default(TimeSpan,RequestContext)']/*" />
        public virtual Response Default(TimeSpan duration, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("Header.Default");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDefaultRequest(duration, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Iso 8601.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="duration"> The <see cref="TimeSpan"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Iso8601Async(TimeSpan,RequestContext)']/*" />
        public virtual async Task<Response> Iso8601Async(TimeSpan duration, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("Header.Iso8601");
            scope.Start();
            try
            {
                using HttpMessage message = CreateIso8601Request(duration, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Iso 8601.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="duration"> The <see cref="TimeSpan"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Iso8601(TimeSpan,RequestContext)']/*" />
        public virtual Response Iso8601(TimeSpan duration, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("Header.Iso8601");
            scope.Start();
            try
            {
                using HttpMessage message = CreateIso8601Request(duration, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Iso 8601 array.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="duration"> The <see cref="IEnumerable{T}"/> where <c>T</c> is of type <see cref="TimeSpan"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="duration"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Iso8601ArrayAsync(IEnumerable{TimeSpan},RequestContext)']/*" />
        public virtual async Task<Response> Iso8601ArrayAsync(IEnumerable<TimeSpan> duration, RequestContext context = null)
        {
            Argument.AssertNotNull(duration, nameof(duration));

            using var scope = ClientDiagnostics.CreateScope("Header.Iso8601Array");
            scope.Start();
            try
            {
                using HttpMessage message = CreateIso8601ArrayRequest(duration, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Iso 8601 array.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="duration"> The <see cref="IEnumerable{T}"/> where <c>T</c> is of type <see cref="TimeSpan"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="duration"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Iso8601Array(IEnumerable{TimeSpan},RequestContext)']/*" />
        public virtual Response Iso8601Array(IEnumerable<TimeSpan> duration, RequestContext context = null)
        {
            Argument.AssertNotNull(duration, nameof(duration));

            using var scope = ClientDiagnostics.CreateScope("Header.Iso8601Array");
            scope.Start();
            try
            {
                using HttpMessage message = CreateIso8601ArrayRequest(duration, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Int 32 seconds.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="duration"> The <see cref="TimeSpan"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Int32SecondsAsync(TimeSpan,RequestContext)']/*" />
        public virtual async Task<Response> Int32SecondsAsync(TimeSpan duration, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("Header.Int32Seconds");
            scope.Start();
            try
            {
                using HttpMessage message = CreateInt32SecondsRequest(duration, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Int 32 seconds.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="duration"> The <see cref="TimeSpan"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='Int32Seconds(TimeSpan,RequestContext)']/*" />
        public virtual Response Int32Seconds(TimeSpan duration, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("Header.Int32Seconds");
            scope.Start();
            try
            {
                using HttpMessage message = CreateInt32SecondsRequest(duration, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Float seconds.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="duration"> The <see cref="TimeSpan"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='FloatSecondsAsync(TimeSpan,RequestContext)']/*" />
        public virtual async Task<Response> FloatSecondsAsync(TimeSpan duration, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("Header.FloatSeconds");
            scope.Start();
            try
            {
                using HttpMessage message = CreateFloatSecondsRequest(duration, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Float seconds.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="duration"> The <see cref="TimeSpan"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Header.xml" path="doc/members/member[@name='FloatSeconds(TimeSpan,RequestContext)']/*" />
        public virtual Response FloatSeconds(TimeSpan duration, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("Header.FloatSeconds");
            scope.Start();
            try
            {
                using HttpMessage message = CreateFloatSecondsRequest(duration, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateDefaultRequest(TimeSpan duration, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/encode/duration/header/default", false);
            request.Uri = uri;
            request.Headers.Add("duration", duration, "P");
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateIso8601Request(TimeSpan duration, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/encode/duration/header/iso8601", false);
            request.Uri = uri;
            request.Headers.Add("duration", duration, "P");
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateIso8601ArrayRequest(IEnumerable<TimeSpan> duration, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/encode/duration/header/iso8601-array", false);
            request.Uri = uri;
            request.Headers.AddDelimited("duration", duration, ",", "P");
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateInt32SecondsRequest(TimeSpan duration, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/encode/duration/header/int32-seconds", false);
            request.Uri = uri;
            request.Headers.Add("duration", duration, "%s");
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateFloatSecondsRequest(TimeSpan duration, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/encode/duration/header/float-seconds", false);
            request.Uri = uri;
            request.Headers.Add("duration", duration, "s\\.fff");
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
