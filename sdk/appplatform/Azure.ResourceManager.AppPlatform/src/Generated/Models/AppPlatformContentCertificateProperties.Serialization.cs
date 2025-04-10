// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformContentCertificateProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStringValue(Content);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CertificatePropertiesType);
            writer.WriteEndObject();
        }

        internal static AppPlatformContentCertificateProperties DeserializeAppPlatformContentCertificateProperties(JsonElement element)
        {
            Optional<string> content = default;
            string type = default;
            Optional<string> thumbprint = default;
            Optional<string> issuer = default;
            Optional<DateTimeOffset> issuedDate = default;
            Optional<DateTimeOffset> expirationDate = default;
            Optional<DateTimeOffset> activateDate = default;
            Optional<string> subjectName = default;
            Optional<IReadOnlyList<string>> dnsNames = default;
            Optional<AppPlatformCertificateProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuer"u8))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    issuedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("activateDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    activateDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("subjectName"u8))
                {
                    subjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsNames"u8))
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
                    dnsNames = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new AppPlatformCertificateProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new AppPlatformContentCertificateProperties(type, thumbprint.Value, issuer.Value, Optional.ToNullable(issuedDate), Optional.ToNullable(expirationDate), Optional.ToNullable(activateDate), subjectName.Value, Optional.ToList(dnsNames), Optional.ToNullable(provisioningState), content.Value);
        }
    }
}
