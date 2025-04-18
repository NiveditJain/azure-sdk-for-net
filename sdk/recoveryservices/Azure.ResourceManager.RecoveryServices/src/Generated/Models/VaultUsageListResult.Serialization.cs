// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    internal partial class VaultUsageListResult
    {
        internal static VaultUsageListResult DeserializeVaultUsageListResult(JsonElement element)
        {
            Optional<IReadOnlyList<VaultUsage>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VaultUsage> array = new List<VaultUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VaultUsage.DeserializeVaultUsage(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new VaultUsageListResult(Optional.ToList(value));
        }
    }
}
