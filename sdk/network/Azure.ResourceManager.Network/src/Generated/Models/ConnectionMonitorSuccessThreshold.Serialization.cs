// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorSuccessThreshold : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ChecksFailedPercent))
            {
                writer.WritePropertyName("checksFailedPercent"u8);
                writer.WriteNumberValue(ChecksFailedPercent.Value);
            }
            if (Optional.IsDefined(RoundTripTimeMs))
            {
                writer.WritePropertyName("roundTripTimeMs"u8);
                writer.WriteNumberValue(RoundTripTimeMs.Value);
            }
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorSuccessThreshold DeserializeConnectionMonitorSuccessThreshold(JsonElement element)
        {
            Optional<int> checksFailedPercent = default;
            Optional<float> roundTripTimeMs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("checksFailedPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    checksFailedPercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("roundTripTimeMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    roundTripTimeMs = property.Value.GetSingle();
                    continue;
                }
            }
            return new ConnectionMonitorSuccessThreshold(Optional.ToNullable(checksFailedPercent), Optional.ToNullable(roundTripTimeMs));
        }
    }
}
