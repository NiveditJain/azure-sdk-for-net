// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class ApiManagementGroupUserListResult
    {
        internal static ApiManagementGroupUserListResult DeserializeApiManagementGroupUserListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ApiManagementGroupUserData>> value = default;
            Optional<long> count = default;
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
                    List<ApiManagementGroupUserData> array = new List<ApiManagementGroupUserData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiManagementGroupUserData.DeserializeApiManagementGroupUserData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ApiManagementGroupUserListResult(Optional.ToList(value), Optional.ToNullable(count), nextLink.Value);
        }
    }
}
