// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class SecurityConnectorsList
    {
        internal static SecurityConnectorsList DeserializeSecurityConnectorsList(JsonElement element)
        {
            IReadOnlyList<SecurityConnectorData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<SecurityConnectorData> array = new List<SecurityConnectorData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityConnectorData.DeserializeSecurityConnectorData(item));
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
            return new SecurityConnectorsList(value, nextLink.Value);
        }
    }
}
