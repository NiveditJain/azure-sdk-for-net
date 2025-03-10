// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsAlertsDataTypeOfDataConnector : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Alerts))
            {
                writer.WritePropertyName("alerts"u8);
                writer.WriteObjectValue(Alerts);
            }
            writer.WriteEndObject();
        }

        internal static SecurityInsightsAlertsDataTypeOfDataConnector DeserializeSecurityInsightsAlertsDataTypeOfDataConnector(JsonElement element)
        {
            Optional<DataConnectorDataTypeCommon> alerts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alerts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    alerts = DataConnectorDataTypeCommon.DeserializeDataConnectorDataTypeCommon(property.Value);
                    continue;
                }
            }
            return new SecurityInsightsAlertsDataTypeOfDataConnector(alerts.Value);
        }
    }
}
