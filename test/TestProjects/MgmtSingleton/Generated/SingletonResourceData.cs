// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace MgmtSingleton
{
    /// <summary> A class representing the SingletonResource data model. </summary>
    public partial class SingletonResourceData : Resource
    {
        /// <summary> Initializes a new instance of SingletonResourceData. </summary>
        public SingletonResourceData()
        {
        }

        /// <summary> Initializes a new instance of SingletonResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="new"></param>
        internal SingletonResourceData(ResourceIdentifier id, string name, ResourceType type, string @new) : base(id, name, type)
        {
            New = @new;
        }

        /// <summary> Gets or sets the new. </summary>
        public string New { get; set; }
    }
}
