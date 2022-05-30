// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> The SubResource. </summary>
    public partial class SubResource
    {
        /// <summary> Initializes a new instance of <see cref="SubResource"/>. </summary>
        public SubResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SubResource"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        internal SubResource(string id)
        {
            Id = id;
        }

        /// <summary> Resource Id. </summary>
        public string Id { get; set; }
    }
}
