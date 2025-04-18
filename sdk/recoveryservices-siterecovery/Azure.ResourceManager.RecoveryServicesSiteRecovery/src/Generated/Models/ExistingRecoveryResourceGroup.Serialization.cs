// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ExistingRecoveryResourceGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryResourceGroupId))
            {
                writer.WritePropertyName("recoveryResourceGroupId"u8);
                writer.WriteStringValue(RecoveryResourceGroupId);
            }
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
            writer.WriteEndObject();
        }

        internal static ExistingRecoveryResourceGroup DeserializeExistingRecoveryResourceGroup(JsonElement element)
        {
            Optional<string> recoveryResourceGroupId = default;
            string resourceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryResourceGroupId"u8))
                {
                    recoveryResourceGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
            }
            return new ExistingRecoveryResourceGroup(resourceType, recoveryResourceGroupId.Value);
        }
    }
}
