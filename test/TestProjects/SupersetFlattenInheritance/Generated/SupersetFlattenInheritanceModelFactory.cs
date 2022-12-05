// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using SupersetFlattenInheritance;

namespace SupersetFlattenInheritance.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class SupersetFlattenInheritanceModelFactory
    {

        /// <summary> Initializes a new instance of CustomModel1. </summary>
        /// <param name="id"></param>
        /// <param name="foo"></param>
        /// <returns> A new <see cref="Models.CustomModel1"/> instance for mocking. </returns>
        public static CustomModel1 CustomModel1(string id = null, string foo = null)
        {
            return new CustomModel1(id, foo);
        }

        /// <summary> Initializes a new instance of CustomModel2. </summary>
        /// <param name="id"></param>
        /// <param name="bar"></param>
        /// <param name="idPropertiesId"></param>
        /// <param name="foo"></param>
        /// <returns> A new <see cref="Models.CustomModel2"/> instance for mocking. </returns>
        public static CustomModel2 CustomModel2(string id = null, string bar = null, string idPropertiesId = null, string foo = null)
        {
            return new CustomModel2(id, bar, idPropertiesId, foo);
        }

        /// <summary> Initializes a new instance of SubResourceModel1. </summary>
        /// <param name="id"></param>
        /// <param name="foo"></param>
        /// <returns> A new <see cref="Models.SubResourceModel1"/> instance for mocking. </returns>
        public static SubResourceModel1 SubResourceModel1(string id = null, string foo = null)
        {
            return new SubResourceModel1(id, foo);
        }

        /// <summary> Initializes a new instance of SubResourceModel2. </summary>
        /// <param name="id"></param>
        /// <param name="idPropertiesId"></param>
        /// <param name="foo"></param>
        /// <returns> A new <see cref="Models.SubResourceModel2"/> instance for mocking. </returns>
        public static SubResourceModel2 SubResourceModel2(string id = null, string idPropertiesId = null, string foo = null)
        {
            return new SubResourceModel2(id, idPropertiesId, foo);
        }

        /// <summary> Initializes a new instance of WritableSubResourceModel1. </summary>
        /// <param name="id"></param>
        /// <param name="foo"></param>
        /// <returns> A new <see cref="Models.WritableSubResourceModel1"/> instance for mocking. </returns>
        public static WritableSubResourceModel1 WritableSubResourceModel1(string id = null, string foo = null)
        {
            return new WritableSubResourceModel1(id, foo);
        }

        /// <summary> Initializes a new instance of WritableSubResourceModel2. </summary>
        /// <param name="id"></param>
        /// <param name="idPropertiesId"></param>
        /// <param name="foo"></param>
        /// <returns> A new <see cref="Models.WritableSubResourceModel2"/> instance for mocking. </returns>
        public static WritableSubResourceModel2 WritableSubResourceModel2(string id = null, string idPropertiesId = null, string foo = null)
        {
            return new WritableSubResourceModel2(id, idPropertiesId, foo);
        }

        /// <summary> Initializes a new instance of ResourceModel1Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="foo"></param>
        /// <returns> A new <see cref="SupersetFlattenInheritance.ResourceModel1Data"/> instance for mocking. </returns>
        public static ResourceModel1Data ResourceModel1Data(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string foo = null)
        {
            return new ResourceModel1Data(id, name, resourceType, systemData, foo);
        }

        /// <summary> Initializes a new instance of ResourceModel2. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="foo"></param>
        /// <returns> A new <see cref="Models.ResourceModel2"/> instance for mocking. </returns>
        public static ResourceModel2 ResourceModel2(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string foo = null)
        {
            return new ResourceModel2(id, name, resourceType, systemData, foo);
        }

        /// <summary> Initializes a new instance of TrackedResourceModel1Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"></param>
        /// <returns> A new <see cref="SupersetFlattenInheritance.TrackedResourceModel1Data"/> instance for mocking. </returns>
        public static TrackedResourceModel1Data TrackedResourceModel1Data(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string foo = null)
        {
            tags ??= new Dictionary<string, string>();

            return new TrackedResourceModel1Data(id, name, resourceType, systemData, tags, location, foo);
        }

        /// <summary> Initializes a new instance of TrackedResourceModel2. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"></param>
        /// <param name="bar"></param>
        /// <param name="fooPropertiesFoo"></param>
        /// <returns> A new <see cref="Models.TrackedResourceModel2"/> instance for mocking. </returns>
        public static TrackedResourceModel2 TrackedResourceModel2(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string foo = null, string bar = null, string fooPropertiesFoo = null)
        {
            tags ??= new Dictionary<string, string>();

            return new TrackedResourceModel2(id, name, resourceType, systemData, tags, location, foo, bar, fooPropertiesFoo);
        }

        /// <summary> Initializes a new instance of NonResourceModel1. </summary>
        /// <param name="bar"></param>
        /// <param name="id"></param>
        /// <param name="foo"></param>
        /// <returns> A new <see cref="Models.NonResourceModel1"/> instance for mocking. </returns>
        public static NonResourceModel1 NonResourceModel1(string bar = null, string id = null, string foo = null)
        {
            return new NonResourceModel1(bar, id, foo);
        }
    }
}
