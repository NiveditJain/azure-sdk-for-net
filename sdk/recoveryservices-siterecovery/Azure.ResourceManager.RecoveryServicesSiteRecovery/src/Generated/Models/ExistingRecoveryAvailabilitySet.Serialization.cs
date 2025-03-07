// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ExistingRecoveryAvailabilitySet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryAvailabilitySetId))
            {
                writer.WritePropertyName("recoveryAvailabilitySetId"u8);
                writer.WriteStringValue(RecoveryAvailabilitySetId);
            }
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
            writer.WriteEndObject();
        }

        internal static ExistingRecoveryAvailabilitySet DeserializeExistingRecoveryAvailabilitySet(JsonElement element)
        {
            Optional<string> recoveryAvailabilitySetId = default;
            string resourceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryAvailabilitySetId"u8))
                {
                    recoveryAvailabilitySetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
            }
            return new ExistingRecoveryAvailabilitySet(resourceType, recoveryAvailabilitySetId.Value);
        }
    }
}
