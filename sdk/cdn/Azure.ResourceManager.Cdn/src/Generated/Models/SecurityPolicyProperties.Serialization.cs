// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class SecurityPolicyProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(PolicyType.ToString());
            writer.WriteEndObject();
        }

        internal static SecurityPolicyProperties DeserializeSecurityPolicyProperties(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "WebApplicationFirewall": return SecurityPolicyWebApplicationFirewall.DeserializeSecurityPolicyWebApplicationFirewall(element);
                }
            }
            return UnknownSecurityPolicyProperties.DeserializeUnknownSecurityPolicyProperties(element);
        }
    }
}
