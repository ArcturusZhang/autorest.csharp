// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> The usage names that can be used; currently limited to StorageAccount. </summary>
    public partial class UsageName
    {
        /// <summary> Initializes a new instance of UsageName. </summary>
        public UsageName()
        {
        }

        /// <summary> Initializes a new instance of UsageName. </summary>
        /// <param name="value"> Gets a string describing the resource name. </param>
        /// <param name="localizedValue"> Gets a localized string describing the resource name. </param>
        internal UsageName(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> Gets a string describing the resource name. </summary>
        public string Value { get; }
        /// <summary> Gets a localized string describing the resource name. </summary>
        public string LocalizedValue { get; }
    }
}
