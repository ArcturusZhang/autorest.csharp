// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Xml.Linq;

namespace extensible_enums_swagger
{
    internal static class XElementExtensions
    {
        public static byte[] GetBytesFromBase64Value(this XElement element, string format) => format switch
        {
            "U" => ModelSerializationExtensions.TypeFormatters.FromBase64UrlString(element.Value),
            "D" => Convert.FromBase64String(element.Value),
            _ => throw new ArgumentException($"Format is not supported: '{format}'", nameof(format))
        };

        public static DateTimeOffset GetDateTimeOffsetValue(this XElement element, string format) => format switch
        {
            "U" => DateTimeOffset.FromUnixTimeSeconds((long)element),
            _ => ModelSerializationExtensions.TypeFormatters.ParseDateTimeOffset(element.Value, format)
        };

        public static TimeSpan GetTimeSpanValue(this XElement element, string format) => ModelSerializationExtensions.TypeFormatters.ParseTimeSpan(element.Value, format);
    }
}
