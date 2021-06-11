// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A Class representing a AzureResourceFlattenModel3 along with the instance operations that can be performed on it. </summary>
    public class AzureResourceFlattenModel3 : AzureResourceFlattenModel3Operations
    {
        /// <summary> Initializes a new instance of the <see cref = "AzureResourceFlattenModel3"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal AzureResourceFlattenModel3(ResourceOperationsBase options, AzureResourceFlattenModel3Data resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the AzureResourceFlattenModel3Data. </summary>
        public AzureResourceFlattenModel3Data Data { get; private set; }

        /// <inheritdoc />
        protected override AzureResourceFlattenModel3 GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<AzureResourceFlattenModel3> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
