// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class ExternalFqdnResponse
    {
        internal static ExternalFqdnResponse DeserializeExternalFqdnResponse(JsonElement element)
        {
            Optional<IReadOnlyList<MachineLearningFqdnEndpoints>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MachineLearningFqdnEndpoints> array = new List<MachineLearningFqdnEndpoints>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningFqdnEndpoints.DeserializeMachineLearningFqdnEndpoints(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ExternalFqdnResponse(Optional.ToList(value));
        }
    }
}
