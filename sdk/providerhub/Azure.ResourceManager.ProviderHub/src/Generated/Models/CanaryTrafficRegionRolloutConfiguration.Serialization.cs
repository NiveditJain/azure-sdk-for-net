// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class CanaryTrafficRegionRolloutConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SkipRegions))
            {
                writer.WritePropertyName("skipRegions"u8);
                writer.WriteStartArray();
                foreach (var item in SkipRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Regions))
            {
                writer.WritePropertyName("regions"u8);
                writer.WriteStartArray();
                foreach (var item in Regions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static CanaryTrafficRegionRolloutConfiguration DeserializeCanaryTrafficRegionRolloutConfiguration(JsonElement element)
        {
            Optional<IList<string>> skipRegions = default;
            Optional<IList<string>> regions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skipRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    skipRegions = array;
                    continue;
                }
                if (property.NameEquals("regions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    regions = array;
                    continue;
                }
            }
            return new CanaryTrafficRegionRolloutConfiguration(Optional.ToList(skipRegions), Optional.ToList(regions));
        }
    }
}
