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
    public partial class AppPlatformConfigServerGitProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Repositories))
            {
                writer.WritePropertyName("repositories"u8);
                writer.WriteStartArray();
                foreach (var item in Repositories)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("uri"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (Optional.IsCollectionDefined(SearchPaths))
            {
                writer.WritePropertyName("searchPaths"u8);
                writer.WriteStartArray();
                foreach (var item in SearchPaths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(HostKey))
            {
                writer.WritePropertyName("hostKey"u8);
                writer.WriteStringValue(HostKey);
            }
            if (Optional.IsDefined(HostKeyAlgorithm))
            {
                writer.WritePropertyName("hostKeyAlgorithm"u8);
                writer.WriteStringValue(HostKeyAlgorithm);
            }
            if (Optional.IsDefined(PrivateKey))
            {
                writer.WritePropertyName("privateKey"u8);
                writer.WriteStringValue(PrivateKey);
            }
            if (Optional.IsDefined(IsHostKeyCheckingStrict))
            {
                writer.WritePropertyName("strictHostKeyChecking"u8);
                writer.WriteBooleanValue(IsHostKeyCheckingStrict.Value);
            }
            writer.WriteEndObject();
        }

        internal static AppPlatformConfigServerGitProperty DeserializeAppPlatformConfigServerGitProperty(JsonElement element)
        {
            Optional<IList<ConfigServerGitPatternRepository>> repositories = default;
            Uri uri = default;
            Optional<string> label = default;
            Optional<IList<string>> searchPaths = default;
            Optional<string> username = default;
            Optional<string> password = default;
            Optional<string> hostKey = default;
            Optional<string> hostKeyAlgorithm = default;
            Optional<string> privateKey = default;
            Optional<bool> strictHostKeyChecking = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("repositories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConfigServerGitPatternRepository> array = new List<ConfigServerGitPatternRepository>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConfigServerGitPatternRepository.DeserializeConfigServerGitPatternRepository(item));
                    }
                    repositories = array;
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchPaths"u8))
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
                    searchPaths = array;
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostKey"u8))
                {
                    hostKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostKeyAlgorithm"u8))
                {
                    hostKeyAlgorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateKey"u8))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("strictHostKeyChecking"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    strictHostKeyChecking = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AppPlatformConfigServerGitProperty(Optional.ToList(repositories), uri, label.Value, Optional.ToList(searchPaths), username.Value, password.Value, hostKey.Value, hostKeyAlgorithm.Value, privateKey.Value, Optional.ToNullable(strictHostKeyChecking));
        }
    }
}
