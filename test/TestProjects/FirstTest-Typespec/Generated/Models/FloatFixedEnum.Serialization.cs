// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace TypeSpecFirstTest.Models
{
    internal static partial class FloatFixedEnumExtensions
    {
        public static float ToSerialSingle(this FloatFixedEnum value) => value switch
        {
            FloatFixedEnum.One => 1.1F,
            FloatFixedEnum.Two => 2.2F,
            FloatFixedEnum.Four => 4.4F,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FloatFixedEnum value.")
        };

        public static FloatFixedEnum ToFloatFixedEnum(this float value)
        {
            if (value == 1.1F) return FloatFixedEnum.One;
            if (value == 2.2F) return FloatFixedEnum.Two;
            if (value == 4.4F) return FloatFixedEnum.Four;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FloatFixedEnum value.");
        }
    }
}
