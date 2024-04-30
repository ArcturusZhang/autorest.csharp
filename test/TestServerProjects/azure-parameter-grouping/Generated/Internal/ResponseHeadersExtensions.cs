// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;
using Azure.Core;

namespace azure_parameter_grouping
{
    internal static class ResponseHeadersExtensions
    {
        private static readonly string[] KnownFormats =
        {
"ddd, d MMM yyyy H:m:s 'GMT'",
"ddd, d MMM yyyy H:m:s 'UTC'",
"ddd, d MMM yyyy H:m:s",
"d MMM yyyy H:m:s 'GMT'",
"d MMM yyyy H:m:s 'UTC'",
"d MMM yyyy H:m:s",
"ddd, d MMM yy H:m:s 'GMT'",
"ddd, d MMM yy H:m:s 'UTC'",
"ddd, d MMM yy H:m:s",
"d MMM yy H:m:s 'GMT'",
"d MMM yy H:m:s 'UTC'",
"d MMM yy H:m:s",
"dddd, d'-'MMM'-'yy H:m:s 'GMT'",
"dddd, d'-'MMM'-'yy H:m:s 'UTC'",
"dddd, d'-'MMM'-'yy H:m:s zzz",
"dddd, d'-'MMM'-'yy H:m:s",
"ddd MMM d H:m:s yyyy",
"ddd, d MMM yyyy H:m:s zzz",
"ddd, d MMM yyyy H:m:s",
"d MMM yyyy H:m:s zzz",
"d MMM yyyy H:m:s"
};

        public static bool TryGetValue(this ResponseHeaders headers, string name, out byte[] value)
        {
            if (headers.TryGetValue(name, out string stringValue))
            {
                value = Convert.FromBase64String(stringValue);
                return true;
            }

            value = null;
            return false;
        }

        public static bool TryGetValue(this ResponseHeaders headers, string name, out TimeSpan? value)
        {
            if (headers.TryGetValue(name, out string stringValue))
            {
                value = XmlConvert.ToTimeSpan(stringValue);
                return true;
            }

            value = null;
            return false;
        }

        public static bool TryGetValue(this ResponseHeaders headers, string name, out DateTimeOffset? value)
        {
            if (headers.TryGetValue(name, out string stringValue))
            {
                if (DateTimeOffset.TryParseExact(stringValue, "r", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTimeOffset dto) || DateTimeOffset.TryParseExact(stringValue, KnownFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.AllowInnerWhite | DateTimeStyles.AssumeUniversal, out dto))
                {
                    value = dto;
                }
                else
                {
                    value = ModelSerializationExtensions.TypeFormatters.ParseDateTimeOffset(stringValue, "");
                }
                return true;
            }

            value = null;
            return false;
        }

        public static bool TryGetValue<T>(this ResponseHeaders headers, string name, out T? value)
        where T : struct
        {
            if (headers.TryGetValue(name, out string stringValue))
            {
                value = (T)Convert.ChangeType(stringValue, typeof(T), CultureInfo.InvariantCulture);
                return true;
            }

            value = null;
            return false;
        }

        public static bool TryGetValue<T>(this ResponseHeaders headers, string name, out T value)
        where T : class
        {
            if (headers.TryGetValue(name, out string stringValue))
            {
                value = (T)Convert.ChangeType(stringValue, typeof(T), CultureInfo.InvariantCulture);
                return true;
            }

            value = null;
            return false;
        }

        public static bool TryGetValue(this ResponseHeaders headers, string prefix, out IDictionary<string, string> value)
        {
            value = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            foreach (var item in headers)
            {
                if (item.Name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    value.Add(item.Name.Substring(prefix.Length), item.Value);
                }
            }

            return true;
        }
    }
}
