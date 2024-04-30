// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;

namespace header
{
    internal partial class HeaderResponseFloatHeaders
    {
        private readonly Response _response;
        public HeaderResponseFloatHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> response with header value "value": 0.07 or -3.0. </summary>
        public float? Value => _response.Headers.TryGetValue("value", out float? value) ? value : null;
    }
}
