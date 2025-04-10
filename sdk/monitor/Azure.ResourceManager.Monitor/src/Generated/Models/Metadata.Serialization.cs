// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class Metadata
    {
        internal static Metadata DeserializeMetadata(JsonElement element)
        {
            Optional<string> provisionedBy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisionedBy"u8))
                {
                    provisionedBy = property.Value.GetString();
                    continue;
                }
            }
            return new Metadata(provisionedBy.Value);
        }
    }
}
