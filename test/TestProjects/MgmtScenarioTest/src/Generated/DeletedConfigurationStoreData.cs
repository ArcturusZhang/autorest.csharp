// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtScenarioTest
{
    /// <summary> A class representing the DeletedConfigurationStore data model. </summary>
    public partial class DeletedConfigurationStoreData : ResourceData
    {
        /// <summary> Initializes a new instance of DeletedConfigurationStoreData. </summary>
        internal DeletedConfigurationStoreData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DeletedConfigurationStoreData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="configurationStoreId"> The resource id of the original configuration store. </param>
        /// <param name="location"> The location of the original configuration store. </param>
        /// <param name="deletionOn"> The deleted date. </param>
        /// <param name="scheduledPurgeOn"> The scheduled purged date. </param>
        /// <param name="tags"> Tags of the original configuration store. </param>
        /// <param name="purgeProtectionEnabled"> Purge protection status of the original configuration store. </param>
        internal DeletedConfigurationStoreData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string configurationStoreId, string location, DateTimeOffset? deletionOn, DateTimeOffset? scheduledPurgeOn, IReadOnlyDictionary<string, string> tags, bool? purgeProtectionEnabled) : base(id, name, resourceType, systemData)
        {
            ConfigurationStoreId = configurationStoreId;
            Location = location;
            DeletionOn = deletionOn;
            ScheduledPurgeOn = scheduledPurgeOn;
            Tags = tags;
            PurgeProtectionEnabled = purgeProtectionEnabled;
        }

        /// <summary> The resource id of the original configuration store. </summary>
        public string ConfigurationStoreId { get; }
        /// <summary> The location of the original configuration store. </summary>
        public string Location { get; }
        /// <summary> The deleted date. </summary>
        public DateTimeOffset? DeletionOn { get; }
        /// <summary> The scheduled purged date. </summary>
        public DateTimeOffset? ScheduledPurgeOn { get; }
        /// <summary> Tags of the original configuration store. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> Purge protection status of the original configuration store. </summary>
        public bool? PurgeProtectionEnabled { get; }
    }
}
