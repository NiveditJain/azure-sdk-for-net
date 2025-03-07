// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class ExpressRoutePortsLocationListResult
    {
        internal static ExpressRoutePortsLocationListResult DeserializeExpressRoutePortsLocationListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ExpressRoutePortsLocationData>> value = default;
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
                    List<ExpressRoutePortsLocationData> array = new List<ExpressRoutePortsLocationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressRoutePortsLocationData.DeserializeExpressRoutePortsLocationData(item));
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
            return new ExpressRoutePortsLocationListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
