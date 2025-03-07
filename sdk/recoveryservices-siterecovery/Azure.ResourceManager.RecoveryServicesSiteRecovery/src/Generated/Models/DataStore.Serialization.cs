// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class DataStore
    {
        internal static DataStore DeserializeDataStore(JsonElement element)
        {
            Optional<string> symbolicName = default;
            Optional<string> uuid = default;
            Optional<string> capacity = default;
            Optional<string> freeSpace = default;
            Optional<string> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("symbolicName"u8))
                {
                    symbolicName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uuid"u8))
                {
                    uuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    capacity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("freeSpace"u8))
                {
                    freeSpace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new DataStore(symbolicName.Value, uuid.Value, capacity.Value, freeSpace.Value, type.Value);
        }
    }
}
