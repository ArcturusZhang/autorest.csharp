// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace _Type._Enum.Fixed.Models
{
    internal static partial class DaysOfWeekEnumExtensions
    {
        public static string ToSerialString(this DaysOfWeekEnum value) => value switch
        {
            DaysOfWeekEnum.Monday => "Monday",
            DaysOfWeekEnum.Tuesday => "Tuesday",
            DaysOfWeekEnum.Wednesday => "Wednesday",
            DaysOfWeekEnum.Thursday => "Thursday",
            DaysOfWeekEnum.Friday => "Friday",
            DaysOfWeekEnum.Saturday => "Saturday",
            DaysOfWeekEnum.Sunday => "Sunday",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DaysOfWeekEnum value.")
        };

        public static DaysOfWeekEnum ToDaysOfWeekEnum(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Monday")) return DaysOfWeekEnum.Monday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Tuesday")) return DaysOfWeekEnum.Tuesday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Wednesday")) return DaysOfWeekEnum.Wednesday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Thursday")) return DaysOfWeekEnum.Thursday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Friday")) return DaysOfWeekEnum.Friday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Saturday")) return DaysOfWeekEnum.Saturday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Sunday")) return DaysOfWeekEnum.Sunday;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DaysOfWeekEnum value.");
        }
    }
}
