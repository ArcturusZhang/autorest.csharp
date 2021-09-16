// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace constants.Models
{
    /// <summary> The ModelAsStringRequiredOneValueNoDefaultOpEnum. </summary>
    public readonly partial struct ModelAsStringRequiredOneValueNoDefaultOpEnum : IEquatable<ModelAsStringRequiredOneValueNoDefaultOpEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelAsStringRequiredOneValueNoDefaultOpEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelAsStringRequiredOneValueNoDefaultOpEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Value1Value = "value1";

        /// <summary> value1. </summary>
        public static ModelAsStringRequiredOneValueNoDefaultOpEnum Value1 { get; } = new ModelAsStringRequiredOneValueNoDefaultOpEnum(Value1Value);
        /// <summary> Determines if two <see cref="ModelAsStringRequiredOneValueNoDefaultOpEnum"/> values are the same. </summary>
        public static bool operator ==(ModelAsStringRequiredOneValueNoDefaultOpEnum left, ModelAsStringRequiredOneValueNoDefaultOpEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelAsStringRequiredOneValueNoDefaultOpEnum"/> values are not the same. </summary>
        public static bool operator !=(ModelAsStringRequiredOneValueNoDefaultOpEnum left, ModelAsStringRequiredOneValueNoDefaultOpEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelAsStringRequiredOneValueNoDefaultOpEnum"/>. </summary>
        public static implicit operator ModelAsStringRequiredOneValueNoDefaultOpEnum(string value) => new ModelAsStringRequiredOneValueNoDefaultOpEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelAsStringRequiredOneValueNoDefaultOpEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelAsStringRequiredOneValueNoDefaultOpEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
