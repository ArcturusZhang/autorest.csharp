// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using OmitOperationGroups;

namespace OmitOperationGroups.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class OmitOperationGroupsModelFactory
    {
        /// <summary> Initializes a new instance of ModelZ. </summary>
        /// <param name="h"></param>
        /// <param name="i"></param>
        /// <returns> A new <see cref="Models.ModelZ"/> instance for mocking. </returns>
        public static ModelZ ModelZ(string h = null, string i = null)
        {
            return new ModelZ(h, i);
        }

        /// <summary> Initializes a new instance of Model2Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="b"></param>
        /// <param name="modelx"></param>
        /// <param name="f"></param>
        /// <param name="g"></param>
        /// <returns> A new <see cref="OmitOperationGroups.Model2Data"/> instance for mocking. </returns>
        public static Model2Data Model2Data(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string b = null, ModelX modelx = null, string f = null, string g = null)
        {
            return new Model2Data(id, name, resourceType, systemData, b, modelx, f, g);
        }

        /// <summary> Initializes a new instance of Model4. </summary>
        /// <param name="id"></param>
        /// <param name="j"></param>
        /// <param name="modelz"></param>
        /// <returns> A new <see cref="Models.Model4"/> instance for mocking. </returns>
        public static Model4 Model4(string id = null, string j = null, ModelZ modelz = null)
        {
            return new Model4(id, j, modelz);
        }

        /// <summary> Initializes a new instance of Model5. </summary>
        /// <param name="id"></param>
        /// <param name="k"></param>
        /// <param name="modelqs"></param>
        /// <returns> A new <see cref="Models.Model5"/> instance for mocking. </returns>
        public static Model5 Model5(string id = null, string k = null, IEnumerable<ModelQ> modelqs = null)
        {
            modelqs ??= new List<ModelQ>();

            return new Model5(id, k, modelqs?.ToList());
        }
    }
}
