// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Response to the get custom model operation. </summary>
    public partial class Model
    {
        /// <summary> Initializes a new instance of Model. </summary>
        /// <param name="modelInfo"> Basic custom model information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelInfo"/> is null. </exception>
        public Model(ModelInfo modelInfo)
        {
            Argument.AssertNotNull(modelInfo, nameof(modelInfo));

            ModelInfo = modelInfo;
        }

        /// <summary> Initializes a new instance of Model. </summary>
        /// <param name="modelInfo"> Basic custom model information. </param>
        /// <param name="keys"> Keys extracted by the custom model. </param>
        /// <param name="trainResult"> Custom model training result. </param>
        internal Model(ModelInfo modelInfo, KeysResult keys, TrainResult trainResult)
        {
            ModelInfo = modelInfo;
            Keys = keys;
            TrainResult = trainResult;
        }

        /// <summary> Basic custom model information. </summary>
        public ModelInfo ModelInfo { get; }
        /// <summary> Keys extracted by the custom model. </summary>
        public KeysResult Keys { get; }
        /// <summary> Custom model training result. </summary>
        public TrainResult TrainResult { get; }
    }
}
