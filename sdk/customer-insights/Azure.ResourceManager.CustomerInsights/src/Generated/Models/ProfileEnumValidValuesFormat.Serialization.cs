// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class ProfileEnumValidValuesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
            if (Optional.IsCollectionDefined(LocalizedValueNames))
            {
                writer.WritePropertyName("localizedValueNames"u8);
                writer.WriteStartObject();
                foreach (var item in LocalizedValueNames)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ProfileEnumValidValuesFormat DeserializeProfileEnumValidValuesFormat(JsonElement element)
        {
            Optional<int> value = default;
            Optional<IDictionary<string, string>> localizedValueNames = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("localizedValueNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    localizedValueNames = dictionary;
                    continue;
                }
            }
            return new ProfileEnumValidValuesFormat(Optional.ToNullable(value), Optional.ToDictionary(localizedValueNames));
        }
    }
}
