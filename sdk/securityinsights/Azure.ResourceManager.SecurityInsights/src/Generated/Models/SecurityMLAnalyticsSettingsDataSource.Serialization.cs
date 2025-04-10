// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityMLAnalyticsSettingsDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectorId))
            {
                writer.WritePropertyName("connectorId"u8);
                writer.WriteStringValue(ConnectorId);
            }
            if (Optional.IsCollectionDefined(DataTypes))
            {
                writer.WritePropertyName("dataTypes"u8);
                writer.WriteStartArray();
                foreach (var item in DataTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SecurityMLAnalyticsSettingsDataSource DeserializeSecurityMLAnalyticsSettingsDataSource(JsonElement element)
        {
            Optional<string> connectorId = default;
            Optional<IList<string>> dataTypes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectorId"u8))
                {
                    connectorId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataTypes"u8))
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
                    dataTypes = array;
                    continue;
                }
            }
            return new SecurityMLAnalyticsSettingsDataSource(connectorId.Value, Optional.ToList(dataTypes));
        }
    }
}
