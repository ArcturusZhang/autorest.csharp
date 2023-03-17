// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ModelsInCadl.Models
{
    /// <summary> Deriver model with discriminator property. </summary>
    public partial class DerivedModelWithDiscriminatorB : BaseModelWithDiscriminator
    {
        /// <summary> Initializes a new instance of DerivedModelWithDiscriminatorB. </summary>
        /// <param name="requiredPropertyOnBase"> Required property on base. </param>
        /// <param name="requiredInt"> Required int. </param>
        public DerivedModelWithDiscriminatorB(int requiredPropertyOnBase, int requiredInt) : base("B", requiredPropertyOnBase)
        {
            RequiredInt = requiredInt;
        }

        /// <summary> Initializes a new instance of DerivedModelWithDiscriminatorB. </summary>
        /// <param name="optionalPropertyOnBase"> Optional property on base. </param>
        /// <param name="requiredPropertyOnBase"> Required property on base. </param>
        /// <param name="requiredInt"> Required int. </param>
        internal DerivedModelWithDiscriminatorB(string optionalPropertyOnBase, int requiredPropertyOnBase, int requiredInt) : base("B", optionalPropertyOnBase, requiredPropertyOnBase)
        {
            RequiredInt = requiredInt;
        }

        /// <summary> Required int. </summary>
        public int RequiredInt { get; set; }
    }
}
