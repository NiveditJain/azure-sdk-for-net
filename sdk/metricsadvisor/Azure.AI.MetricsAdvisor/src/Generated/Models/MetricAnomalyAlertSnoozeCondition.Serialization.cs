// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class MetricAnomalyAlertSnoozeCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("autoSnooze"u8);
            writer.WriteNumberValue(AutoSnooze);
            writer.WritePropertyName("snoozeScope"u8);
            writer.WriteStringValue(SnoozeScope.ToString());
            writer.WritePropertyName("onlyForSuccessive"u8);
            writer.WriteBooleanValue(IsOnlyForSuccessive);
            writer.WriteEndObject();
        }

        internal static MetricAnomalyAlertSnoozeCondition DeserializeMetricAnomalyAlertSnoozeCondition(JsonElement element)
        {
            int autoSnooze = default;
            SnoozeScope snoozeScope = default;
            bool onlyForSuccessive = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoSnooze"u8))
                {
                    autoSnooze = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("snoozeScope"u8))
                {
                    snoozeScope = new SnoozeScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onlyForSuccessive"u8))
                {
                    onlyForSuccessive = property.Value.GetBoolean();
                    continue;
                }
            }
            return new MetricAnomalyAlertSnoozeCondition(autoSnooze, snoozeScope, onlyForSuccessive);
        }
    }
}
