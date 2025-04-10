// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppIngressConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(External))
            {
                writer.WritePropertyName("external"u8);
                writer.WriteBooleanValue(External.Value);
            }
            if (Optional.IsDefined(TargetPort))
            {
                writer.WritePropertyName("targetPort"u8);
                writer.WriteNumberValue(TargetPort.Value);
            }
            if (Optional.IsDefined(ExposedPort))
            {
                writer.WritePropertyName("exposedPort"u8);
                writer.WriteNumberValue(ExposedPort.Value);
            }
            if (Optional.IsDefined(Transport))
            {
                writer.WritePropertyName("transport"u8);
                writer.WriteStringValue(Transport.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Traffic))
            {
                writer.WritePropertyName("traffic"u8);
                writer.WriteStartArray();
                foreach (var item in Traffic)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CustomDomains))
            {
                writer.WritePropertyName("customDomains"u8);
                writer.WriteStartArray();
                foreach (var item in CustomDomains)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllowInsecure))
            {
                writer.WritePropertyName("allowInsecure"u8);
                writer.WriteBooleanValue(AllowInsecure.Value);
            }
            if (Optional.IsCollectionDefined(IPSecurityRestrictions))
            {
                writer.WritePropertyName("ipSecurityRestrictions"u8);
                writer.WriteStartArray();
                foreach (var item in IPSecurityRestrictions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ClientCertificateMode))
            {
                writer.WritePropertyName("clientCertificateMode"u8);
                writer.WriteStringValue(ClientCertificateMode.Value.ToString());
            }
            if (Optional.IsDefined(CorsPolicy))
            {
                writer.WritePropertyName("corsPolicy"u8);
                writer.WriteObjectValue(CorsPolicy);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppIngressConfiguration DeserializeContainerAppIngressConfiguration(JsonElement element)
        {
            Optional<string> fqdn = default;
            Optional<bool> external = default;
            Optional<int> targetPort = default;
            Optional<int> exposedPort = default;
            Optional<ContainerAppIngressTransportMethod> transport = default;
            Optional<IList<ContainerAppRevisionTrafficWeight>> traffic = default;
            Optional<IList<ContainerAppCustomDomain>> customDomains = default;
            Optional<bool> allowInsecure = default;
            Optional<IList<ContainerAppIPSecurityRestrictionRule>> ipSecurityRestrictions = default;
            Optional<ContainerAppIngressClientCertificateMode> clientCertificateMode = default;
            Optional<ContainerAppCorsPolicy> corsPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("external"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    external = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("targetPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exposedPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    exposedPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("transport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    transport = new ContainerAppIngressTransportMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("traffic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ContainerAppRevisionTrafficWeight> array = new List<ContainerAppRevisionTrafficWeight>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppRevisionTrafficWeight.DeserializeContainerAppRevisionTrafficWeight(item));
                    }
                    traffic = array;
                    continue;
                }
                if (property.NameEquals("customDomains"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ContainerAppCustomDomain> array = new List<ContainerAppCustomDomain>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppCustomDomain.DeserializeContainerAppCustomDomain(item));
                    }
                    customDomains = array;
                    continue;
                }
                if (property.NameEquals("allowInsecure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allowInsecure = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ipSecurityRestrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ContainerAppIPSecurityRestrictionRule> array = new List<ContainerAppIPSecurityRestrictionRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppIPSecurityRestrictionRule.DeserializeContainerAppIPSecurityRestrictionRule(item));
                    }
                    ipSecurityRestrictions = array;
                    continue;
                }
                if (property.NameEquals("clientCertificateMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clientCertificateMode = new ContainerAppIngressClientCertificateMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("corsPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    corsPolicy = ContainerAppCorsPolicy.DeserializeContainerAppCorsPolicy(property.Value);
                    continue;
                }
            }
            return new ContainerAppIngressConfiguration(fqdn.Value, Optional.ToNullable(external), Optional.ToNullable(targetPort), Optional.ToNullable(exposedPort), Optional.ToNullable(transport), Optional.ToList(traffic), Optional.ToList(customDomains), Optional.ToNullable(allowInsecure), Optional.ToList(ipSecurityRestrictions), Optional.ToNullable(clientCertificateMode), corsPolicy.Value);
        }
    }
}
