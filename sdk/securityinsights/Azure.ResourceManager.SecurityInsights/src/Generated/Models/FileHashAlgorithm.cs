// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The hash algorithm type. </summary>
    public readonly partial struct FileHashAlgorithm : IEquatable<FileHashAlgorithm>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FileHashAlgorithm"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FileHashAlgorithm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string MD5Value = "MD5";
        private const string SHA1Value = "SHA1";
        private const string SHA256Value = "SHA256";
        private const string SHA256ACValue = "SHA256AC";

        /// <summary> Unknown hash algorithm. </summary>
        public static FileHashAlgorithm Unknown { get; } = new FileHashAlgorithm(UnknownValue);
        /// <summary> MD5 hash type. </summary>
        public static FileHashAlgorithm MD5 { get; } = new FileHashAlgorithm(MD5Value);
        /// <summary> SHA1 hash type. </summary>
        public static FileHashAlgorithm SHA1 { get; } = new FileHashAlgorithm(SHA1Value);
        /// <summary> SHA256 hash type. </summary>
        public static FileHashAlgorithm SHA256 { get; } = new FileHashAlgorithm(SHA256Value);
        /// <summary> SHA256 Authenticode hash type. </summary>
        public static FileHashAlgorithm SHA256AC { get; } = new FileHashAlgorithm(SHA256ACValue);
        /// <summary> Determines if two <see cref="FileHashAlgorithm"/> values are the same. </summary>
        public static bool operator ==(FileHashAlgorithm left, FileHashAlgorithm right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FileHashAlgorithm"/> values are not the same. </summary>
        public static bool operator !=(FileHashAlgorithm left, FileHashAlgorithm right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FileHashAlgorithm"/>. </summary>
        public static implicit operator FileHashAlgorithm(string value) => new FileHashAlgorithm(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FileHashAlgorithm other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FileHashAlgorithm other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
