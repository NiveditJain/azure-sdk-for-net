// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Maps;

namespace Azure.ResourceManager.Maps.Models
{
    internal partial class MapsCreatorListResult
    {
        internal static MapsCreatorListResult DeserializeMapsCreatorListResult(JsonElement element)
        {
            Optional<IReadOnlyList<MapsCreatorData>> value = default;
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
                    List<MapsCreatorData> array = new List<MapsCreatorData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MapsCreatorData.DeserializeMapsCreatorData(item));
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
            return new MapsCreatorListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
