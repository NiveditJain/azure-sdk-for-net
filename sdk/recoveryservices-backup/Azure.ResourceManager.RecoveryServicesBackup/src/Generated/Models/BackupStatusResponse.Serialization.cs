// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupStatusResponse
    {
        internal static BackupStatusResponse DeserializeBackupStatusResponse(JsonElement element)
        {
            Optional<ProtectionStatus> protectionStatus = default;
            Optional<string> vaultId = default;
            Optional<FabricName> fabricName = default;
            Optional<string> containerName = default;
            Optional<string> protectedItemName = default;
            Optional<string> errorCode = default;
            Optional<string> errorMessage = default;
            Optional<string> policyName = default;
            Optional<string> registrationStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protectionStatus = new ProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vaultId"u8))
                {
                    vaultId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fabricName = new FabricName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemName"u8))
                {
                    protectedItemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
            }
            return new BackupStatusResponse(Optional.ToNullable(protectionStatus), vaultId.Value, Optional.ToNullable(fabricName), containerName.Value, protectedItemName.Value, errorCode.Value, errorMessage.Value, policyName.Value, registrationStatus.Value);
        }
    }
}
