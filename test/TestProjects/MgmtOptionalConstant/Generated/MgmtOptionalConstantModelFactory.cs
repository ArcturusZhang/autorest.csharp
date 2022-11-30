// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtOptionalConstant;

namespace MgmtOptionalConstant.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class MgmtOptionalConstantModelFactory
    {
        /// <summary> Initializes a new instance of OptionalMachineData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="listener"> Describes Protocol and thumbprint of Windows Remote Management listener. </param>
        /// <param name="content"> Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup. Contents are defined by setting name, component name, and the pass in which the content is applied. </param>
        /// <returns> A new <see cref="MgmtOptionalConstant.OptionalMachineData"/> instance for mocking. </returns>
        public static OptionalMachineData OptionalMachineData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ModelWithRequiredConstant listener = null, ModelWithOptionalConstant content = null)
        {
            tags ??= new Dictionary<string, string>();

            return new OptionalMachineData(id, name, resourceType, systemData, tags, location, listener, content);
        }
    }
}
