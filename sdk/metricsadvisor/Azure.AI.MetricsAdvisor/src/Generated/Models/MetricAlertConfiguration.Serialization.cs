// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class MetricAlertConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("anomalyDetectionConfigurationId"u8);
            writer.WriteStringValue(DetectionConfigurationId);
            writer.WritePropertyName("anomalyScopeType"u8);
            writer.WriteStringValue(AnomalyScopeType.ToString());
            if (Optional.IsDefined(UseDetectionResultToFilterAnomalies))
            {
                writer.WritePropertyName("negationOperation"u8);
                writer.WriteBooleanValue(UseDetectionResultToFilterAnomalies.Value);
            }
            if (Optional.IsDefined(DimensionAnomalyScope))
            {
                writer.WritePropertyName("dimensionAnomalyScope"u8);
                writer.WriteObjectValue(DimensionAnomalyScope);
            }
            if (Optional.IsDefined(TopNAnomalyScope))
            {
                writer.WritePropertyName("topNAnomalyScope"u8);
                writer.WriteObjectValue(TopNAnomalyScope);
            }
            if (Optional.IsDefined(SeverityFilter))
            {
                writer.WritePropertyName("severityFilter"u8);
                writer.WriteObjectValue(SeverityFilter);
            }
            if (Optional.IsDefined(AlertSnoozeCondition))
            {
                writer.WritePropertyName("snoozeFilter"u8);
                writer.WriteObjectValue(AlertSnoozeCondition);
            }
            if (Optional.IsDefined(ValueFilter))
            {
                writer.WritePropertyName("valueFilter"u8);
                writer.WriteObjectValue(ValueFilter);
            }
            writer.WriteEndObject();
        }

        internal static MetricAlertConfiguration DeserializeMetricAlertConfiguration(JsonElement element)
        {
            string anomalyDetectionConfigurationId = default;
            MetricAnomalyAlertScopeType anomalyScopeType = default;
            Optional<bool> negationOperation = default;
            Optional<DimensionKey> dimensionAnomalyScope = default;
            Optional<TopNGroupScope> topNAnomalyScope = default;
            Optional<SeverityCondition> severityFilter = default;
            Optional<MetricAnomalyAlertSnoozeCondition> snoozeFilter = default;
            Optional<MetricBoundaryCondition> valueFilter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("anomalyDetectionConfigurationId"u8))
                {
                    anomalyDetectionConfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("anomalyScopeType"u8))
                {
                    anomalyScopeType = new MetricAnomalyAlertScopeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("negationOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    negationOperation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dimensionAnomalyScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dimensionAnomalyScope = DimensionKey.DeserializeDimensionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("topNAnomalyScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    topNAnomalyScope = TopNGroupScope.DeserializeTopNGroupScope(property.Value);
                    continue;
                }
                if (property.NameEquals("severityFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    severityFilter = SeverityCondition.DeserializeSeverityCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("snoozeFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    snoozeFilter = MetricAnomalyAlertSnoozeCondition.DeserializeMetricAnomalyAlertSnoozeCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("valueFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    valueFilter = MetricBoundaryCondition.DeserializeMetricBoundaryCondition(property.Value);
                    continue;
                }
            }
            return new MetricAlertConfiguration(anomalyDetectionConfigurationId, anomalyScopeType, Optional.ToNullable(negationOperation), dimensionAnomalyScope.Value, topNAnomalyScope.Value, severityFilter.Value, snoozeFilter.Value, valueFilter.Value);
        }
    }
}
