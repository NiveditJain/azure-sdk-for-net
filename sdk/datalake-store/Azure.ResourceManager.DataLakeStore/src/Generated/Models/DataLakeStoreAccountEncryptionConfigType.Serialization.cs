// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    internal static partial class DataLakeStoreAccountEncryptionConfigTypeExtensions
    {
        public static string ToSerialString(this DataLakeStoreAccountEncryptionConfigType value) => value switch
        {
            DataLakeStoreAccountEncryptionConfigType.UserManaged => "UserManaged",
            DataLakeStoreAccountEncryptionConfigType.ServiceManaged => "ServiceManaged",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataLakeStoreAccountEncryptionConfigType value.")
        };

        public static DataLakeStoreAccountEncryptionConfigType ToDataLakeStoreAccountEncryptionConfigType(this string value)
        {
            if (string.Equals(value, "UserManaged", StringComparison.InvariantCultureIgnoreCase)) return DataLakeStoreAccountEncryptionConfigType.UserManaged;
            if (string.Equals(value, "ServiceManaged", StringComparison.InvariantCultureIgnoreCase)) return DataLakeStoreAccountEncryptionConfigType.ServiceManaged;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataLakeStoreAccountEncryptionConfigType value.");
        }
    }
}
