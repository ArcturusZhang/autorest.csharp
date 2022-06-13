// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Provides parameter values to a magnitude scoring function. </summary>
    public partial class MagnitudeScoringParameters
    {
        /// <summary> Initializes a new instance of MagnitudeScoringParameters. </summary>
        /// <param name="boostingRangeStart"> The field value at which boosting starts. </param>
        /// <param name="boostingRangeEnd"> The field value at which boosting ends. </param>
        public MagnitudeScoringParameters(double boostingRangeStart, double boostingRangeEnd)
        {
            BoostingRangeStart = boostingRangeStart;
            BoostingRangeEnd = boostingRangeEnd;
        }

        /// <summary> Initializes a new instance of MagnitudeScoringParameters. </summary>
        /// <param name="boostingRangeStart"> The field value at which boosting starts. </param>
        /// <param name="boostingRangeEnd"> The field value at which boosting ends. </param>
        /// <param name="shouldBoostBeyondRangeByConstant"> A value indicating whether to apply a constant boost for field values beyond the range end value; default is false. </param>
        internal MagnitudeScoringParameters(double boostingRangeStart, double boostingRangeEnd, bool? shouldBoostBeyondRangeByConstant)
        {
            BoostingRangeStart = boostingRangeStart;
            BoostingRangeEnd = boostingRangeEnd;
            ShouldBoostBeyondRangeByConstant = shouldBoostBeyondRangeByConstant;
        }

        /// <summary> The field value at which boosting starts. </summary>
        public double BoostingRangeStart { get; set; }
        /// <summary> The field value at which boosting ends. </summary>
        public double BoostingRangeEnd { get; set; }
        /// <summary> A value indicating whether to apply a constant boost for field values beyond the range end value; default is false. </summary>
        public bool? ShouldBoostBeyondRangeByConstant { get; set; }
    }
}
