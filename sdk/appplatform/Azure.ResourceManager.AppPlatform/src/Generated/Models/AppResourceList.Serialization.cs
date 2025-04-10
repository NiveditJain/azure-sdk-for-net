// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class AppResourceList
    {
        internal static AppResourceList DeserializeAppResourceList(JsonElement element)
        {
            Optional<IReadOnlyList<AppPlatformAppData>> value = default;
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
                    List<AppPlatformAppData> array = new List<AppPlatformAppData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformAppData.DeserializeAppPlatformAppData(item));
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
            return new AppResourceList(Optional.ToList(value), nextLink.Value);
        }
    }
}
