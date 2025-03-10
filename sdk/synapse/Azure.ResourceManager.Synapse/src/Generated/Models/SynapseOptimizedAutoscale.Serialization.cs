// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseOptimizedAutoscale : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("version"u8);
            writer.WriteNumberValue(Version);
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("minimum"u8);
            writer.WriteNumberValue(Minimum);
            writer.WritePropertyName("maximum"u8);
            writer.WriteNumberValue(Maximum);
            writer.WriteEndObject();
        }

        internal static SynapseOptimizedAutoscale DeserializeSynapseOptimizedAutoscale(JsonElement element)
        {
            int version = default;
            bool isEnabled = default;
            int minimum = default;
            int maximum = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minimum"u8))
                {
                    minimum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    maximum = property.Value.GetInt32();
                    continue;
                }
            }
            return new SynapseOptimizedAutoscale(version, isEnabled, minimum, maximum);
        }
    }
}
