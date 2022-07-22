// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtScenarioTest.Models
{
    /// <summary> Sku of Azure Spring Cloud. </summary>
    public partial class MgmtScenarioTestSku
    {
        /// <summary> Initializes a new instance of MgmtScenarioTestSku. </summary>
        public MgmtScenarioTestSku()
        {
        }

        /// <summary> Initializes a new instance of MgmtScenarioTestSku. </summary>
        /// <param name="name"> Name of the Sku. </param>
        /// <param name="tier"> Tier of the Sku. </param>
        /// <param name="capacity"> Current capacity of the target resource. </param>
        internal MgmtScenarioTestSku(string name, string tier, int? capacity)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
        }

        /// <summary> Name of the Sku. </summary>
        public string Name { get; set; }
        /// <summary> Tier of the Sku. </summary>
        public string Tier { get; set; }
        /// <summary> Current capacity of the target resource. </summary>
        public int? Capacity { get; set; }
    }
}
