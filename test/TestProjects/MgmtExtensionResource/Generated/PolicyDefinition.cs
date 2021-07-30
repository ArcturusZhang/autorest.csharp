// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace MgmtExtensionResource
{
    /// <summary> A Class representing a PolicyDefinition along with the instance operations that can be performed on it. </summary>
    public class PolicyDefinition : PolicyDefinitionOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "PolicyDefinition"/> class for mocking. </summary>
        protected PolicyDefinition() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PolicyDefinition"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal PolicyDefinition(ResourceOperations options, PolicyDefinitionData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the PolicyDefinitionData. </summary>
        public virtual PolicyDefinitionData Data { get; private set; }
    }
}
