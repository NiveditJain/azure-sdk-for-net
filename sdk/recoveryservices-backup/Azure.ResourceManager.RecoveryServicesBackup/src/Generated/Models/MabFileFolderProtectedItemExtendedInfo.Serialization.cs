// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class MabFileFolderProtectedItemExtendedInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LastRefreshedOn))
            {
                writer.WritePropertyName("lastRefreshedAt"u8);
                writer.WriteStringValue(LastRefreshedOn.Value, "O");
            }
            if (Optional.IsDefined(OldestRecoveryPoint))
            {
                writer.WritePropertyName("oldestRecoveryPoint"u8);
                writer.WriteStringValue(OldestRecoveryPoint.Value, "O");
            }
            if (Optional.IsDefined(RecoveryPointCount))
            {
                writer.WritePropertyName("recoveryPointCount"u8);
                writer.WriteNumberValue(RecoveryPointCount.Value);
            }
            writer.WriteEndObject();
        }

        internal static MabFileFolderProtectedItemExtendedInfo DeserializeMabFileFolderProtectedItemExtendedInfo(JsonElement element)
        {
            Optional<DateTimeOffset> lastRefreshedAt = default;
            Optional<DateTimeOffset> oldestRecoveryPoint = default;
            Optional<int> recoveryPointCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastRefreshedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastRefreshedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("oldestRecoveryPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    oldestRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveryPointCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recoveryPointCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new MabFileFolderProtectedItemExtendedInfo(Optional.ToNullable(lastRefreshedAt), Optional.ToNullable(oldestRecoveryPoint), Optional.ToNullable(recoveryPointCount));
        }
    }
}
