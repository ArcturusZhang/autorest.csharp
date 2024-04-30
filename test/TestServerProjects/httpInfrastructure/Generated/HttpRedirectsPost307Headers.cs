// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;

namespace httpInfrastructure
{
    internal partial class HttpRedirectsPost307Headers
    {
        private readonly Response _response;
        public HttpRedirectsPost307Headers(Response response)
        {
            _response = response;
        }
        /// <summary> The redirect location for this request. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
    }
}
