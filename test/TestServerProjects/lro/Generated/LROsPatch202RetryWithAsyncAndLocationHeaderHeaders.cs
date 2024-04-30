// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;

namespace lro
{
    internal partial class LROsPatch202RetryWithAsyncAndLocationHeaderHeaders
    {
        private readonly Response _response;
        public LROsPatch202RetryWithAsyncAndLocationHeaderHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Location to poll for result status: will be set to /lro/patch/202/retry/asyncAndLocationHeader/operationResults/202. </summary>
        public string AzureAsyncOperation => _response.Headers.TryGetValue("Azure-AsyncOperation", out string value) ? value : null;
        /// <summary> Location to poll for final status: will be set to /lro/patch/202/retry/asyncAndLocationHeader/operationResults/202/finalResults/202. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
    }
}
