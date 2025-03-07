// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PrivateDns.Models
{
    public partial class PrivateDnsSrvRecordInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(Weight))
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteNumberValue(Weight.Value);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            writer.WriteEndObject();
        }

        internal static PrivateDnsSrvRecordInfo DeserializePrivateDnsSrvRecordInfo(JsonElement element)
        {
            Optional<int> priority = default;
            Optional<int> weight = default;
            Optional<int> port = default;
            Optional<string> target = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("weight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weight = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
            }
            return new PrivateDnsSrvRecordInfo(Optional.ToNullable(priority), Optional.ToNullable(weight), Optional.ToNullable(port), target.Value);
        }
    }
}
