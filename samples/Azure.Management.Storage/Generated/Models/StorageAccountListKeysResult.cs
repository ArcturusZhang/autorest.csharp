// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    /// <summary> The response from the ListKeys operation. </summary>
    public partial class StorageAccountListKeysResult
    {
        /// <summary> Initializes a new instance of StorageAccountListKeysResult. </summary>
        public StorageAccountListKeysResult()
        {
            Keys = new ChangeTrackingList<StorageAccountKey>();
        }

        /// <summary> Initializes a new instance of StorageAccountListKeysResult. </summary>
        /// <param name="keys"> Gets the list of storage account keys and their properties for the specified storage account. </param>
        internal StorageAccountListKeysResult(IReadOnlyList<StorageAccountKey> keys)
        {
            Keys = keys;
        }

        /// <summary> Gets the list of storage account keys and their properties for the specified storage account. </summary>
        public IReadOnlyList<StorageAccountKey> Keys { get; }
    }
}
