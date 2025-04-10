// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubMatchedRoute
    {
        internal static IotHubMatchedRoute DeserializeIotHubMatchedRoute(JsonElement element)
        {
            Optional<RoutingRuleProperties> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = RoutingRuleProperties.DeserializeRoutingRuleProperties(property.Value);
                    continue;
                }
            }
            return new IotHubMatchedRoute(properties.Value);
        }
    }
}
