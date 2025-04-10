// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class SyncFullSchemaPropertiesListResult
    {
        internal static SyncFullSchemaPropertiesListResult DeserializeSyncFullSchemaPropertiesListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SyncFullSchemaProperties>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SyncFullSchemaProperties> array = new List<SyncFullSchemaProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncFullSchemaProperties.DeserializeSyncFullSchemaProperties(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SyncFullSchemaPropertiesListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
