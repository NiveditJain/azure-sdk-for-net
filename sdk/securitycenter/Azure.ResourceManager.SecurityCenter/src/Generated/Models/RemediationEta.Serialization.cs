// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class RemediationEta : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("eta"u8);
            writer.WriteStringValue(Eta, "O");
            writer.WritePropertyName("justification"u8);
            writer.WriteStringValue(Justification);
            writer.WriteEndObject();
        }

        internal static RemediationEta DeserializeRemediationEta(JsonElement element)
        {
            DateTimeOffset eta = default;
            string justification = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eta"u8))
                {
                    eta = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("justification"u8))
                {
                    justification = property.Value.GetString();
                    continue;
                }
            }
            return new RemediationEta(eta, justification);
        }
    }
}
