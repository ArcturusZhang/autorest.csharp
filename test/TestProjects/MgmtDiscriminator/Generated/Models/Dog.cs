// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtDiscriminator.Models
{
    /// <summary> A dog. </summary>
    public partial class Dog : Pet
    {
        /// <summary> Initializes a new instance of Dog. </summary>
        public Dog()
        {
            Kind = PetKind.Dog;
        }

        /// <summary> Initializes a new instance of Dog. </summary>
        /// <param name="id"> The Id of the pet. </param>
        /// <param name="bark"> A dog can bark. </param>
        internal Dog(string id, string bark) : base(PetKind.Dog, id)
        {
            Bark = bark;
        }

        /// <summary> A dog can bark. </summary>
        public string Bark { get; set; }
    }
}
