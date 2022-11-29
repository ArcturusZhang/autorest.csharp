// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtExtensionResource;

namespace MgmtExtensionResource.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class MgmtExtensionResourceModelFactory
    {
        /// <summary> Initializes a new instance of DnsNameAvailabilityResult. </summary>
        /// <param name="available"> Domain availability (True/False). </param>
        /// <returns> A new <see cref="Models.DnsNameAvailabilityResult"/> instance for mocking. </returns>
        public static DnsNameAvailabilityResult DnsNameAvailabilityResult(bool? available = null)
        {
            return new DnsNameAvailabilityResult(available);
        }

        /// <summary> Initializes a new instance of SubSingletonData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="something"> The something. </param>
        /// <returns> A new <see cref="MgmtExtensionResource.SubSingletonData"/> instance for mocking. </returns>
        public static SubSingletonData SubSingletonData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string something = null)
        {
            return new SubSingletonData(id, name, resourceType, systemData, something);
        }
    }
}
