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

namespace MgmtPolymorphicResources
{
    internal class VirtualMachineScaleSetOperationSource : IOperationSource<VirtualMachineScaleSetResource>
    {
        private readonly ArmClient _client;

        internal VirtualMachineScaleSetOperationSource(ArmClient client)
        {
            _client = client;
        }

        VirtualMachineScaleSetResource IOperationSource<VirtualMachineScaleSetResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualMachineScaleSetData.DeserializeVirtualMachineScaleSetData(document.RootElement);
            return new VirtualMachineScaleSetResource(_client, data);
        }

        async ValueTask<VirtualMachineScaleSetResource> IOperationSource<VirtualMachineScaleSetResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualMachineScaleSetData.DeserializeVirtualMachineScaleSetData(document.RootElement);
            return new VirtualMachineScaleSetResource(_client, data);
        }
    }
}
