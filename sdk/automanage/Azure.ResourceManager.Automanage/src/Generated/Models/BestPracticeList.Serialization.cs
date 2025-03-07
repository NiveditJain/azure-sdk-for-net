// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automanage;

namespace Azure.ResourceManager.Automanage.Models
{
    internal partial class BestPracticeList
    {
        internal static BestPracticeList DeserializeBestPracticeList(JsonElement element)
        {
            Optional<IReadOnlyList<BestPracticeData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BestPracticeData> array = new List<BestPracticeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BestPracticeData.DeserializeBestPracticeData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BestPracticeList(Optional.ToList(value));
        }
    }
}
