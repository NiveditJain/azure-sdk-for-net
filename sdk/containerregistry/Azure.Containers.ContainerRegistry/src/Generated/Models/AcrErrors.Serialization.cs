// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class AcrErrors
    {
        internal static AcrErrors DeserializeAcrErrors(JsonElement element)
        {
            Optional<IReadOnlyList<AcrErrorInfo>> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AcrErrorInfo> array = new List<AcrErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcrErrorInfo.DeserializeAcrErrorInfo(item));
                    }
                    errors = array;
                    continue;
                }
            }
            return new AcrErrors(Optional.ToList(errors));
        }
    }
}
