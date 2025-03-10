// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class AvailableLabServicesSkuCapacity
    {
        internal static AvailableLabServicesSkuCapacity DeserializeAvailableLabServicesSkuCapacity(JsonElement element)
        {
            Optional<long> @default = default;
            Optional<long> minimum = default;
            Optional<long> maximum = default;
            Optional<LabServicesSkuCapacityScaleType> scaleType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    @default = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minimum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maximum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("scaleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scaleType = new LabServicesSkuCapacityScaleType(property.Value.GetString());
                    continue;
                }
            }
            return new AvailableLabServicesSkuCapacity(Optional.ToNullable(@default), Optional.ToNullable(minimum), Optional.ToNullable(maximum), Optional.ToNullable(scaleType));
        }
    }
}
