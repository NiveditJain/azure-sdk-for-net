// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class SimpleSchedulePolicyV2 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduleRunFrequency))
            {
                writer.WritePropertyName("scheduleRunFrequency"u8);
                writer.WriteStringValue(ScheduleRunFrequency.Value.ToString());
            }
            if (Optional.IsDefined(HourlySchedule))
            {
                writer.WritePropertyName("hourlySchedule"u8);
                writer.WriteObjectValue(HourlySchedule);
            }
            if (Optional.IsDefined(DailySchedule))
            {
                writer.WritePropertyName("dailySchedule"u8);
                writer.WriteObjectValue(DailySchedule);
            }
            if (Optional.IsDefined(WeeklySchedule))
            {
                writer.WritePropertyName("weeklySchedule"u8);
                writer.WriteObjectValue(WeeklySchedule);
            }
            writer.WritePropertyName("schedulePolicyType"u8);
            writer.WriteStringValue(SchedulePolicyType);
            writer.WriteEndObject();
        }

        internal static SimpleSchedulePolicyV2 DeserializeSimpleSchedulePolicyV2(JsonElement element)
        {
            Optional<ScheduleRunType> scheduleRunFrequency = default;
            Optional<HourlySchedule> hourlySchedule = default;
            Optional<DailySchedule> dailySchedule = default;
            Optional<WeeklySchedule> weeklySchedule = default;
            string schedulePolicyType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleRunFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scheduleRunFrequency = new ScheduleRunType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hourlySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hourlySchedule = HourlySchedule.DeserializeHourlySchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("dailySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dailySchedule = DailySchedule.DeserializeDailySchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("weeklySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weeklySchedule = WeeklySchedule.DeserializeWeeklySchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("schedulePolicyType"u8))
                {
                    schedulePolicyType = property.Value.GetString();
                    continue;
                }
            }
            return new SimpleSchedulePolicyV2(schedulePolicyType, Optional.ToNullable(scheduleRunFrequency), hourlySchedule.Value, dailySchedule.Value, weeklySchedule.Value);
        }
    }
}
