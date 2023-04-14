// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace body_complex.Models
{
    /// <summary> The DotSalmon. </summary>
    public partial class DotSalmon : DotFish
    {
        /// <summary> Initializes a new instance of DotSalmon. </summary>
        public DotSalmon()
        {
            FishType = "DotSalmon";
        }

        /// <summary> Initializes a new instance of DotSalmon. </summary>
        /// <param name="species"></param>
        /// <param name="location"></param>
        /// <param name="iswild"></param>
        internal DotSalmon(string species, string location, bool? iswild) : base("DotSalmon", species)
        {
            Location = location;
            Iswild = iswild;
        }

        /// <summary> Gets the location. </summary>
        public string Location { get; }
        /// <summary> Gets the iswild. </summary>
        public bool? Iswild { get; }
    }
}
