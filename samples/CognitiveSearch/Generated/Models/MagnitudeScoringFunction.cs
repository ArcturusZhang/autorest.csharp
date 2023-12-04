// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace CognitiveSearch.Models
{
    /// <summary> Defines a function that boosts scores based on the magnitude of a numeric field. </summary>
    public partial class MagnitudeScoringFunction : ScoringFunction
    {
        /// <summary> Initializes a new instance of <see cref="MagnitudeScoringFunction"/>. </summary>
        /// <param name="fieldName"> The name of the field used as input to the scoring function. </param>
        /// <param name="boost"> A multiplier for the raw score. Must be a positive number not equal to 1.0. </param>
        /// <param name="parameters"> Parameter values for the magnitude scoring function. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fieldName"/> or <paramref name="parameters"/> is null. </exception>
        public MagnitudeScoringFunction(string fieldName, double boost, MagnitudeScoringParameters parameters) : base(fieldName, boost)
        {
            Argument.AssertNotNull(fieldName, nameof(fieldName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            Parameters = parameters;
            Type = "magnitude";
        }

        /// <summary> Initializes a new instance of <see cref="MagnitudeScoringFunction"/>. </summary>
        /// <param name="type"> Indicates the type of function to use. Valid values include magnitude, freshness, distance, and tag. The function type must be lower case. </param>
        /// <param name="fieldName"> The name of the field used as input to the scoring function. </param>
        /// <param name="boost"> A multiplier for the raw score. Must be a positive number not equal to 1.0. </param>
        /// <param name="interpolation"> A value indicating how boosting will be interpolated across document scores; defaults to "Linear". </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="parameters"> Parameter values for the magnitude scoring function. </param>
        internal MagnitudeScoringFunction(string type, string fieldName, double boost, ScoringFunctionInterpolation? interpolation, IDictionary<string, BinaryData> serializedAdditionalRawData, MagnitudeScoringParameters parameters) : base(type, fieldName, boost, interpolation, serializedAdditionalRawData)
        {
            Parameters = parameters;
            Type = type ?? "magnitude";
        }

        /// <summary> Initializes a new instance of <see cref="MagnitudeScoringFunction"/> for deserialization. </summary>
        internal MagnitudeScoringFunction()
        {
        }

        /// <summary> Parameter values for the magnitude scoring function. </summary>
        public MagnitudeScoringParameters Parameters { get; set; }
    }
}
