// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class SoftDeletePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsSoftDeleteEnabled))
            {
                writer.WritePropertyName("isSoftDeleteEnabled"u8);
                writer.WriteBooleanValue(IsSoftDeleteEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static SoftDeletePolicy DeserializeSoftDeletePolicy(JsonElement element)
        {
            Optional<bool> isSoftDeleteEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isSoftDeleteEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isSoftDeleteEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SoftDeletePolicy(Optional.ToNullable(isSoftDeleteEnabled));
        }
    }
}
