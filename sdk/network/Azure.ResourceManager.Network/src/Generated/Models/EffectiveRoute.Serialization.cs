// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class EffectiveRoute
    {
        internal static EffectiveRoute DeserializeEffectiveRoute(JsonElement element)
        {
            Optional<string> name = default;
            Optional<bool> disableBgpRoutePropagation = default;
            Optional<EffectiveRouteSource> source = default;
            Optional<EffectiveRouteState> state = default;
            Optional<IReadOnlyList<string>> addressPrefix = default;
            Optional<IReadOnlyList<string>> nextHopIPAddress = default;
            Optional<RouteNextHopType> nextHopType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disableBgpRoutePropagation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableBgpRoutePropagation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    source = new EffectiveRouteSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new EffectiveRouteState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("addressPrefix"u8))
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
                    addressPrefix = array;
                    continue;
                }
                if (property.NameEquals("nextHopIpAddress"u8))
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
                    nextHopIPAddress = array;
                    continue;
                }
                if (property.NameEquals("nextHopType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nextHopType = new RouteNextHopType(property.Value.GetString());
                    continue;
                }
            }
            return new EffectiveRoute(name.Value, Optional.ToNullable(disableBgpRoutePropagation), Optional.ToNullable(source), Optional.ToNullable(state), Optional.ToList(addressPrefix), Optional.ToList(nextHopIPAddress), Optional.ToNullable(nextHopType));
        }
    }
}
