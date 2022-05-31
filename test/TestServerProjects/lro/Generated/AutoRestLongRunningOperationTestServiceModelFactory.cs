// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace lro.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class AutoRestLongRunningOperationTestServiceModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Product"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="type"> Resource Type. </param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <param name="location"> Resource Location. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="provisioningState"></param>
        /// <param name="provisioningStateValues"></param>
        /// <returns> A new <see cref="Models.Product"/> instance for mocking. </returns>
        public static Product Product(string id = null, string type = null, IDictionary<string, string> tags = null, string location = null, string name = null, string provisioningState = null, ProductPropertiesProvisioningStateValues? provisioningStateValues = null)
        {
            tags ??= new Dictionary<string, string>();

            return new Product(id, type, tags, location, name, provisioningState, provisioningStateValues);
        }

        /// <summary> Initializes a new instance of <see cref="Resource"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="type"> Resource Type. </param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <param name="location"> Resource Location. </param>
        /// <param name="name"> Resource Name. </param>
        /// <returns> A new <see cref="Models.Resource"/> instance for mocking. </returns>
        public static Resource Resource(string id = null, string type = null, IDictionary<string, string> tags = null, string location = null, string name = null)
        {
            tags ??= new Dictionary<string, string>();

            return new Resource(id, type, tags, location, name);
        }

        /// <summary> Initializes a new instance of <see cref="SubProduct"/>. </summary>
        /// <param name="id"> Sub Resource Id. </param>
        /// <param name="provisioningState"></param>
        /// <param name="provisioningStateValues"></param>
        /// <returns> A new <see cref="Models.SubProduct"/> instance for mocking. </returns>
        public static SubProduct SubProduct(string id = null, string provisioningState = null, SubProductPropertiesProvisioningStateValues? provisioningStateValues = null)
        {
            return new SubProduct(id, provisioningState, provisioningStateValues);
        }

        /// <summary> Initializes a new instance of <see cref="SubResource"/>. </summary>
        /// <param name="id"> Sub Resource Id. </param>
        /// <returns> A new <see cref="Models.SubResource"/> instance for mocking. </returns>
        public static SubResource SubResource(string id = null)
        {
            return new SubResource(id);
        }
    }
}
