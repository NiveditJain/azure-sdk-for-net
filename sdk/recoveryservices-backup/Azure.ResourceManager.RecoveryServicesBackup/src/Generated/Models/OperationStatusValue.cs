// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Operation status. </summary>
    public readonly partial struct OperationStatusValue : IEquatable<OperationStatusValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationStatusValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationStatusValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Invalid. </summary>
        public static OperationStatusValue Invalid { get; } = new OperationStatusValue(InvalidValue);
        /// <summary> InProgress. </summary>
        public static OperationStatusValue InProgress { get; } = new OperationStatusValue(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static OperationStatusValue Succeeded { get; } = new OperationStatusValue(SucceededValue);
        /// <summary> Failed. </summary>
        public static OperationStatusValue Failed { get; } = new OperationStatusValue(FailedValue);
        /// <summary> Canceled. </summary>
        public static OperationStatusValue Canceled { get; } = new OperationStatusValue(CanceledValue);
        /// <summary> Determines if two <see cref="OperationStatusValue"/> values are the same. </summary>
        public static bool operator ==(OperationStatusValue left, OperationStatusValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationStatusValue"/> values are not the same. </summary>
        public static bool operator !=(OperationStatusValue left, OperationStatusValue right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OperationStatusValue"/>. </summary>
        public static implicit operator OperationStatusValue(string value) => new OperationStatusValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationStatusValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationStatusValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
