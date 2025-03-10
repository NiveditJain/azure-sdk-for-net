// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class FilterTrackPropertyCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("property"u8);
            writer.WriteStringValue(Property.ToString());
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
            writer.WritePropertyName("operation"u8);
            writer.WriteStringValue(Operation.ToString());
            writer.WriteEndObject();
        }

        internal static FilterTrackPropertyCondition DeserializeFilterTrackPropertyCondition(JsonElement element)
        {
            FilterTrackPropertyType property = default;
            string value = default;
            FilterTrackPropertyCompareOperation operation = default;
            foreach (var property0 in element.EnumerateObject())
            {
                if (property0.NameEquals("property"u8))
                {
                    property = new FilterTrackPropertyType(property0.Value.GetString());
                    continue;
                }
                if (property0.NameEquals("value"u8))
                {
                    value = property0.Value.GetString();
                    continue;
                }
                if (property0.NameEquals("operation"u8))
                {
                    operation = new FilterTrackPropertyCompareOperation(property0.Value.GetString());
                    continue;
                }
            }
            return new FilterTrackPropertyCondition(property, value, operation);
        }
    }
}
