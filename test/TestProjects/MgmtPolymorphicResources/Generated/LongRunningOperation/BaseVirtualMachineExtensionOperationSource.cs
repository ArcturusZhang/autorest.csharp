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
    internal class BaseVirtualMachineExtensionOperationSource : IOperationSource<BaseVirtualMachineExtensionResource>
    {
        private readonly ArmClient _client;

        internal BaseVirtualMachineExtensionOperationSource(ArmClient client)
        {
            _client = client;
        }

        BaseVirtualMachineExtensionResource IOperationSource<BaseVirtualMachineExtensionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualMachineExtensionData.DeserializeVirtualMachineExtensionData(document.RootElement);
            return BaseVirtualMachineExtensionResource.GetResource(_client, data);
        }

        async ValueTask<BaseVirtualMachineExtensionResource> IOperationSource<BaseVirtualMachineExtensionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualMachineExtensionData.DeserializeVirtualMachineExtensionData(document.RootElement);
            return BaseVirtualMachineExtensionResource.GetResource(_client, data);
        }
    }
}
