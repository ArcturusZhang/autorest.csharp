// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Threading;

namespace Scm.Parameters.Spread
{
    // Data plane generated client.
    /// <summary> The Spread service client. </summary>
    public partial class SpreadClient
    {
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of SpreadClient. </summary>
        public SpreadClient() : this(new Uri("http://localhost:3000"), new SpreadClientOptions())
        {
        }

        /// <summary> Initializes a new instance of SpreadClient. </summary>
        /// <param name="endpoint"> TestServer endpoint. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public SpreadClient(Uri endpoint, SpreadClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new SpreadClientOptions();

            _pipeline = ClientPipeline.Create(options, Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>());
            _endpoint = endpoint;
        }

        private Model _cachedModel;
        private Alias _cachedAlias;

        /// <summary> Initializes a new instance of Model. </summary>
        public virtual Model GetModelClient()
        {
            return Volatile.Read(ref _cachedModel) ?? Interlocked.CompareExchange(ref _cachedModel, new Model(_pipeline, _endpoint), null) ?? _cachedModel;
        }

        /// <summary> Initializes a new instance of Alias. </summary>
        public virtual Alias GetAliasClient()
        {
            return Volatile.Read(ref _cachedAlias) ?? Interlocked.CompareExchange(ref _cachedAlias, new Alias(_pipeline, _endpoint), null) ?? _cachedAlias;
        }
    }
}
