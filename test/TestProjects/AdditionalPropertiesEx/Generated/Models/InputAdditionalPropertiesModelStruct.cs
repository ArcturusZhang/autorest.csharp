// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AdditionalPropertiesEx.Models
{
    /// <summary> The InputAdditionalPropertiesModelStruct. </summary>
    public readonly partial struct InputAdditionalPropertiesModelStruct
    {
        /// <summary> Initializes a new instance of InputAdditionalPropertiesModelStruct. </summary>
        /// <param name="id"> . </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="additionalProperties"/> is null. </exception>
        public InputAdditionalPropertiesModelStruct(int id, IDictionary<string, object> additionalProperties)
        {
            if (additionalProperties == null)
            {
                throw new ArgumentNullException(nameof(additionalProperties));
            }

            Id = id;
            AdditionalProperties = additionalProperties;
        }

        public int Id { get; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
