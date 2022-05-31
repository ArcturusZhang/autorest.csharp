// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtSafeFlatten.Models
{
    /// <summary> The LayerOneBaseType. </summary>
    public partial class LayerOneBaseType
    {
        /// <summary> Initializes a new instance of <see cref="LayerOneBaseType"/>. </summary>
        public LayerOneBaseType()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LayerOneBaseType"/>. </summary>
        /// <param name="name"></param>
        internal LayerOneBaseType(LayerOneTypeName name)
        {
            Name = name;
        }

        /// <summary> Gets or sets the name. </summary>
        internal LayerOneTypeName Name { get; set; }
    }
}
