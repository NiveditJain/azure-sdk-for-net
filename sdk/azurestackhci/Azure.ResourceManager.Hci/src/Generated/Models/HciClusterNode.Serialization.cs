// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciClusterNode
    {
        internal static HciClusterNode DeserializeHciClusterNode(JsonElement element)
        {
            Optional<string> name = default;
            Optional<float> id = default;
            Optional<WindowsServerSubscription> windowsServerSubscription = default;
            Optional<string> manufacturer = default;
            Optional<string> model = default;
            Optional<string> osName = default;
            Optional<string> osVersion = default;
            Optional<string> serialNumber = default;
            Optional<float> coreCount = default;
            Optional<float> memoryInGiB = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("windowsServerSubscription"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    windowsServerSubscription = new WindowsServerSubscription(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("manufacturer"u8))
                {
                    manufacturer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osName"u8))
                {
                    osName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osVersion"u8))
                {
                    osVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    coreCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("memoryInGiB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    memoryInGiB = property.Value.GetSingle();
                    continue;
                }
            }
            return new HciClusterNode(name.Value, Optional.ToNullable(id), Optional.ToNullable(windowsServerSubscription), manufacturer.Value, model.Value, osName.Value, osVersion.Value, serialNumber.Value, Optional.ToNullable(coreCount), Optional.ToNullable(memoryInGiB));
        }
    }
}
