// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtNonStringPathVariable.Models;

namespace MgmtNonStringPathVariable
{
    /// <summary> A class representing the Bar data model. </summary>
    public partial class BarData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="BarData"/>. </summary>
        /// <param name="location"> The location. </param>
        public BarData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="BarData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The instance view of a resource. </param>
        internal BarData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, BarProperties properties) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
        }

        /// <summary> The instance view of a resource. </summary>
        internal BarProperties Properties { get; set; }
        /// <summary> Update Domain count. </summary>
        public Guid? BarBuzz
        {
            get => Properties is null ? default : Properties.Buzz;
            set
            {
                if (Properties is null)
                    Properties = new BarProperties();
                Properties.Buzz = value;
            }
        }
    }
}
