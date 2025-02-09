// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class ServiceBusFilterAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SqlExpression))
            {
                writer.WritePropertyName("sqlExpression"u8);
                writer.WriteStringValue(SqlExpression);
            }
            if (Optional.IsDefined(CompatibilityLevel))
            {
                writer.WritePropertyName("compatibilityLevel"u8);
                writer.WriteNumberValue(CompatibilityLevel.Value);
            }
            if (Optional.IsDefined(RequiresPreprocessing))
            {
                writer.WritePropertyName("requiresPreprocessing"u8);
                writer.WriteBooleanValue(RequiresPreprocessing.Value);
            }
            writer.WriteEndObject();
        }

        internal static ServiceBusFilterAction DeserializeServiceBusFilterAction(JsonElement element)
        {
            Optional<string> sqlExpression = default;
            Optional<int> compatibilityLevel = default;
            Optional<bool> requiresPreprocessing = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlExpression"u8))
                {
                    sqlExpression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("compatibilityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    compatibilityLevel = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("requiresPreprocessing"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requiresPreprocessing = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ServiceBusFilterAction(sqlExpression.Value, Optional.ToNullable(compatibilityLevel), Optional.ToNullable(requiresPreprocessing));
        }
    }
}
