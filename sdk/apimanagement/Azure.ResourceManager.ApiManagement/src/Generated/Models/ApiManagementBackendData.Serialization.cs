// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementBackendData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ResourceUri))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
            }
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials);
            }
            if (Optional.IsDefined(Proxy))
            {
                writer.WritePropertyName("proxy"u8);
                writer.WriteObjectValue(Proxy);
            }
            if (Optional.IsDefined(Tls))
            {
                writer.WritePropertyName("tls"u8);
                writer.WriteObjectValue(Tls);
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApiManagementBackendData DeserializeApiManagementBackendData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> title = default;
            Optional<string> description = default;
            Optional<Uri> resourceId = default;
            Optional<BackendProperties> properties = default;
            Optional<BackendCredentialsContract> credentials = default;
            Optional<BackendProxyContract> proxy = default;
            Optional<BackendTlsProperties> tls = default;
            Optional<Uri> uri = default;
            Optional<BackendProtocol> protocol = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("title"u8))
                        {
                            title = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                resourceId = null;
                                continue;
                            }
                            resourceId = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("properties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            properties = BackendProperties.DeserializeBackendProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("credentials"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            credentials = BackendCredentialsContract.DeserializeBackendCredentialsContract(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("proxy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            proxy = BackendProxyContract.DeserializeBackendProxyContract(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("tls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tls = BackendTlsProperties.DeserializeBackendTlsProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("url"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                uri = null;
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            protocol = new BackendProtocol(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApiManagementBackendData(id, name, type, systemData.Value, title.Value, description.Value, resourceId.Value, properties.Value, credentials.Value, proxy.Value, tls.Value, uri.Value, Optional.ToNullable(protocol));
        }
    }
}
