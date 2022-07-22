// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MgmtScenarioTest.Models
{
    /// <summary> Describes an available Azure Spring Cloud SKU. </summary>
    public partial class ResourceSku
    {
        /// <summary> Initializes a new instance of ResourceSku. </summary>
        internal ResourceSku()
        {
            Locations = new ChangeTrackingList<string>();
            LocationInfo = new ChangeTrackingList<ResourceSkuLocationInfo>();
            Restrictions = new ChangeTrackingList<ResourceSkuRestrictions>();
        }

        /// <summary> Initializes a new instance of ResourceSku. </summary>
        /// <param name="resourceType"> Gets the type of resource the SKU applies to. </param>
        /// <param name="name"> Gets the name of SKU. </param>
        /// <param name="tier"> Gets the tier of SKU. </param>
        /// <param name="capacity"> Gets the capacity of SKU. </param>
        /// <param name="locations"> Gets the set of locations that the SKU is available. </param>
        /// <param name="locationInfo"> Gets a list of locations and availability zones in those locations where the SKU is available. </param>
        /// <param name="restrictions">
        /// Gets the restrictions because of which SKU cannot be used. This is
        /// empty if there are no restrictions.
        /// </param>
        internal ResourceSku(string resourceType, string name, string tier, SkuCapacity capacity, IReadOnlyList<string> locations, IReadOnlyList<ResourceSkuLocationInfo> locationInfo, IReadOnlyList<ResourceSkuRestrictions> restrictions)
        {
            ResourceType = resourceType;
            Name = name;
            Tier = tier;
            Capacity = capacity;
            Locations = locations;
            LocationInfo = locationInfo;
            Restrictions = restrictions;
        }

        /// <summary> Gets the type of resource the SKU applies to. </summary>
        public string ResourceType { get; }
        /// <summary> Gets the name of SKU. </summary>
        public string Name { get; }
        /// <summary> Gets the tier of SKU. </summary>
        public string Tier { get; }
        /// <summary> Gets the capacity of SKU. </summary>
        public SkuCapacity Capacity { get; }
        /// <summary> Gets the set of locations that the SKU is available. </summary>
        public IReadOnlyList<string> Locations { get; }
        /// <summary> Gets a list of locations and availability zones in those locations where the SKU is available. </summary>
        public IReadOnlyList<ResourceSkuLocationInfo> LocationInfo { get; }
        /// <summary>
        /// Gets the restrictions because of which SKU cannot be used. This is
        /// empty if there are no restrictions.
        /// </summary>
        public IReadOnlyList<ResourceSkuRestrictions> Restrictions { get; }
    }
}
