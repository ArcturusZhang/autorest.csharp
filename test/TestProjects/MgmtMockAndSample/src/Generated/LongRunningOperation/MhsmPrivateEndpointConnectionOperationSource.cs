// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace MgmtMockAndSample
{
    internal class MhsmPrivateEndpointConnectionOperationSource : IOperationSource<MhsmPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal MhsmPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        MhsmPrivateEndpointConnectionResource IOperationSource<MhsmPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MhsmPrivateEndpointConnectionData.DeserializeMhsmPrivateEndpointConnectionData(document.RootElement);
            return new MhsmPrivateEndpointConnectionResource(_client, data, data.Id);
        }

        async ValueTask<MhsmPrivateEndpointConnectionResource> IOperationSource<MhsmPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MhsmPrivateEndpointConnectionData.DeserializeMhsmPrivateEndpointConnectionData(document.RootElement);
            return new MhsmPrivateEndpointConnectionResource(_client, data, data.Id);
        }
    }
}
