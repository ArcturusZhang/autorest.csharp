// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace CadlFirstTest.Models
{
    /// <summary>
    /// The DoWithRequiredUnionRequest.
    /// Please note <see cref="DoWithRequiredUnionRequest"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="StringDoWithRequiredUnionRequest"/>, <see cref="StringListDoWithRequiredUnionRequest"/> and <see cref="Int32DoWithRequiredUnionRequest"/>.
    /// </summary>
    internal abstract partial class DoWithRequiredUnionRequest
    {
        /// <summary> Initializes a new instance of DoWithRequiredUnionRequest. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DoWithRequiredUnionRequest(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the color. </summary>
        public string Color { get; set; }
    }
}
