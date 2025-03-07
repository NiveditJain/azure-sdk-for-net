// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class HealthcareApisServiceCosmosDbConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OfferThroughput))
            {
                writer.WritePropertyName("offerThroughput"u8);
                writer.WriteNumberValue(OfferThroughput.Value);
            }
            if (Optional.IsDefined(KeyVaultKeyUri))
            {
                writer.WritePropertyName("keyVaultKeyUri"u8);
                writer.WriteStringValue(KeyVaultKeyUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static HealthcareApisServiceCosmosDbConfiguration DeserializeHealthcareApisServiceCosmosDbConfiguration(JsonElement element)
        {
            Optional<int> offerThroughput = default;
            Optional<Uri> keyVaultKeyUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerThroughput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    offerThroughput = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("keyVaultKeyUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyVaultKeyUri = null;
                        continue;
                    }
                    keyVaultKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new HealthcareApisServiceCosmosDbConfiguration(Optional.ToNullable(offerThroughput), keyVaultKeyUri.Value);
        }
    }
}
