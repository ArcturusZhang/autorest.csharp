// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using MgmtListMethods;

namespace MgmtListMethods.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class MgmtListMethodsModelFactory
    {

        /// <summary> Initializes a new instance of NonResourceChild. </summary>
        /// <param name="name"> Name. </param>
        /// <param name="numberOfCores"> Test Desc. </param>
        /// <returns> A new <see cref="Models.NonResourceChild"/> instance for mocking. </returns>
        public static NonResourceChild NonResourceChild(string name = null, int? numberOfCores = null)
        {
            return new NonResourceChild(name, numberOfCores);
        }

        /// <summary> Initializes a new instance of UpdateWorkspaceQuotas. </summary>
        /// <param name="id"> Specifies the resource ID. </param>
        /// <param name="updateWorkspaceQuotasType"> Specifies the resource type. </param>
        /// <param name="limit"> The maximum permitted quota of the resource. </param>
        /// <param name="unit"> An enum describing the unit of quota measurement. </param>
        /// <param name="status"> Status of update workspace quota. </param>
        /// <returns> A new <see cref="Models.UpdateWorkspaceQuotas"/> instance for mocking. </returns>
        public static UpdateWorkspaceQuotas UpdateWorkspaceQuotas(string id = null, string updateWorkspaceQuotasType = null, long? limit = null, QuotaUnit? unit = null, Status? status = null)
        {
            return new UpdateWorkspaceQuotas(id, updateWorkspaceQuotasType, limit, unit, status);
        }
    }
}
