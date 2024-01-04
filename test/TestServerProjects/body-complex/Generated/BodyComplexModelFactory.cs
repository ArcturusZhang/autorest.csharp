// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace body_complex.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class BodyComplexModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.DotFish"/>. </summary>
        /// <param name="fishType"></param>
        /// <param name="species"></param>
        /// <returns> A new <see cref="Models.DotFish"/> instance for mocking. </returns>
        public static DotFish DotFish(string fishType = null, string species = null)
        {
            return new UnknownDotFish(fishType, species, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DotFishMarket"/>. </summary>
        /// <param name="sampleSalmon"></param>
        /// <param name="salmons"></param>
        /// <param name="sampleFish">
        /// Please note <see cref="Models.DotFish"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.DotSalmon"/>.
        /// </param>
        /// <param name="fishes">
        /// Please note <see cref="Models.DotFish"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.DotSalmon"/>.
        /// </param>
        /// <returns> A new <see cref="Models.DotFishMarket"/> instance for mocking. </returns>
        public static DotFishMarket DotFishMarket(DotSalmon sampleSalmon = null, IEnumerable<DotSalmon> salmons = null, DotFish sampleFish = null, IEnumerable<DotFish> fishes = null)
        {
            salmons ??= new List<DotSalmon>();
            fishes ??= new List<DotFish>();

            return new DotFishMarket(sampleSalmon, salmons?.ToList(), sampleFish, fishes?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DotSalmon"/>. </summary>
        /// <param name="species"></param>
        /// <param name="location"></param>
        /// <param name="iswild"></param>
        /// <returns> A new <see cref="Models.DotSalmon"/> instance for mocking. </returns>
        public static DotSalmon DotSalmon(string species = null, string location = null, bool? iswild = null)
        {
            return new DotSalmon("DotSalmon", species, serializedAdditionalRawData: null, location, iswild);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ReadonlyObj"/>. </summary>
        /// <param name="id"></param>
        /// <param name="size"></param>
        /// <returns> A new <see cref="Models.ReadonlyObj"/> instance for mocking. </returns>
        public static ReadonlyObj ReadonlyObj(string id = null, int? size = null)
        {
            return new ReadonlyObj(id, size, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MyBaseType"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="propB1"></param>
        /// <param name="propBH1"></param>
        /// <returns> A new <see cref="Models.MyBaseType"/> instance for mocking. </returns>
        public static MyBaseType MyBaseType(string kind = "Unknown", string propB1 = null, string propBH1 = null)
        {
            return new UnknownMyBaseType(kind, propB1, propBH1, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MyDerivedType"/>. </summary>
        /// <param name="propB1"></param>
        /// <param name="propBH1"></param>
        /// <param name="propD1"></param>
        /// <returns> A new <see cref="Models.MyDerivedType"/> instance for mocking. </returns>
        public static MyDerivedType MyDerivedType(string propB1 = null, string propBH1 = null, string propD1 = null)
        {
            return new MyDerivedType(MyKind.Kind1, propB1, propBH1, serializedAdditionalRawData: null, propD1);
        }
    }
}
