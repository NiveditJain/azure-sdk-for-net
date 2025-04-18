// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class DefaultRolloutPropertiesStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NextTrafficRegion))
            {
                writer.WritePropertyName("nextTrafficRegion"u8);
                writer.WriteStringValue(NextTrafficRegion.Value.ToString());
            }
            if (Optional.IsDefined(NextTrafficRegionScheduledOn))
            {
                writer.WritePropertyName("nextTrafficRegionScheduledTime"u8);
                writer.WriteStringValue(NextTrafficRegionScheduledOn.Value, "O");
            }
            if (Optional.IsDefined(SubscriptionReregistrationResult))
            {
                writer.WritePropertyName("subscriptionReregistrationResult"u8);
                writer.WriteStringValue(SubscriptionReregistrationResult.Value.ToString());
            }
            if (Optional.IsCollectionDefined(CompletedRegions))
            {
                writer.WritePropertyName("completedRegions"u8);
                writer.WriteStartArray();
                foreach (var item in CompletedRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FailedOrSkippedRegions))
            {
                writer.WritePropertyName("failedOrSkippedRegions"u8);
                writer.WriteStartObject();
                foreach (var item in FailedOrSkippedRegions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static DefaultRolloutPropertiesStatus DeserializeDefaultRolloutPropertiesStatus(JsonElement element)
        {
            Optional<TrafficRegionCategory> nextTrafficRegion = default;
            Optional<DateTimeOffset> nextTrafficRegionScheduledTime = default;
            Optional<SubscriptionReregistrationResult> subscriptionReregistrationResult = default;
            Optional<IList<string>> completedRegions = default;
            Optional<IDictionary<string, ExtendedErrorInfo>> failedOrSkippedRegions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextTrafficRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nextTrafficRegion = new TrafficRegionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nextTrafficRegionScheduledTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nextTrafficRegionScheduledTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("subscriptionReregistrationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subscriptionReregistrationResult = new SubscriptionReregistrationResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("completedRegions"u8))
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
                    completedRegions = array;
                    continue;
                }
                if (property.NameEquals("failedOrSkippedRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ExtendedErrorInfo> dictionary = new Dictionary<string, ExtendedErrorInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ExtendedErrorInfo.DeserializeExtendedErrorInfo(property0.Value));
                    }
                    failedOrSkippedRegions = dictionary;
                    continue;
                }
            }
            return new DefaultRolloutPropertiesStatus(Optional.ToList(completedRegions), Optional.ToDictionary(failedOrSkippedRegions), Optional.ToNullable(nextTrafficRegion), Optional.ToNullable(nextTrafficRegionScheduledTime), Optional.ToNullable(subscriptionReregistrationResult));
        }
    }
}
