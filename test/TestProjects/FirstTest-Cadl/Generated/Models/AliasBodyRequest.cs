// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace CadlFirstTest.Models
{
    /// <summary>
    /// The AliasBodyRequest.
    /// Please note <see cref="AliasBodyRequest"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="StringAliasBodyRequest"/>, <see cref="StringListAliasBodyRequest"/> and <see cref="Int32AliasBodyRequest"/>.
    /// </summary>
    public abstract partial class AliasBodyRequest
    {
        /// <summary> Initializes a new instance of AliasBodyRequest. </summary>
        /// <param name="name"></param>
        /// <param name="requiredLiteral"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="requiredLiteral"/> is null. </exception>
        public AliasBodyRequest(string name, string requiredLiteral)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(requiredLiteral, nameof(requiredLiteral));

            Name = name;
            RequiredLiteral = requiredLiteral;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the required literal. </summary>
        public string RequiredLiteral { get; }
    }
}
