// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing the SubResourceModel2 data model. </summary>
    public partial class SubResourceModel2Data : SubResource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of SubResourceModel2Data. </summary>
        public SubResourceModel2Data()
        {
        }

        /// <summary> Initializes a new instance of SubResourceModel2Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="foo"> . </param>
        internal SubResourceModel2Data(string id, string foo) : base(id)
        {
            Foo = foo;
        }

        public string Foo { get; set; }
    }
}
