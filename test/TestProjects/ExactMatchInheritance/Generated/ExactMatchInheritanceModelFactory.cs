// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;
using ExactMatchInheritance;

namespace ExactMatchInheritance.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class ExactMatchInheritanceModelFactory
    {

        /// <summary> Initializes a new instance of ExactMatchModel1Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="new"></param>
        /// <param name="supportingUris"></param>
        /// <param name="type1"></param>
        /// <param name="type2"></param>
        /// <param name="type3"></param>
        /// <param name="type4"></param>
        /// <returns> A new <see cref="ExactMatchInheritance.ExactMatchModel1Data"/> instance for mocking. </returns>
        public static ExactMatchModel1Data ExactMatchModel1Data(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string @new = null, IEnumerable<Uri> supportingUris = null, Type1? type1 = null, Type2? type2 = null, IPAddress type3 = null, object type4 = null)
        {
            supportingUris ??= new List<Uri>();

            return new ExactMatchModel1Data(id, name, resourceType, systemData, @new, supportingUris?.ToList(), type1, type2, type3, type4);
        }

        /// <summary> Initializes a new instance of ExactMatchModel5Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="new"></param>
        /// <returns> A new <see cref="ExactMatchInheritance.ExactMatchModel5Data"/> instance for mocking. </returns>
        public static ExactMatchModel5Data ExactMatchModel5Data(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string @new = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ExactMatchModel5Data(id, name, resourceType, systemData, tags, location, @new);
        }

        /// <summary> Initializes a new instance of ExactMatchModel11. </summary>
        /// <param name="name"></param>
        /// <param name="resourceType"></param>
        /// <returns> A new <see cref="Models.ExactMatchModel11"/> instance for mocking. </returns>
        public static ExactMatchModel11 ExactMatchModel11(string name = null, ResourceType? resourceType = null)
        {
            return new ExactMatchModel11(name, resourceType);
        }
    }
}
