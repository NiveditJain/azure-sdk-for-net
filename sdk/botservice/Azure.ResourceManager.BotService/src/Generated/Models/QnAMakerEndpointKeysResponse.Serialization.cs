// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class QnAMakerEndpointKeysResponse
    {
        internal static QnAMakerEndpointKeysResponse DeserializeQnAMakerEndpointKeysResponse(JsonElement element)
        {
            Optional<string> primaryEndpointKey = default;
            Optional<string> secondaryEndpointKey = default;
            Optional<string> installedVersion = default;
            Optional<string> lastStableVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryEndpointKey"u8))
                {
                    primaryEndpointKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryEndpointKey"u8))
                {
                    secondaryEndpointKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("installedVersion"u8))
                {
                    installedVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastStableVersion"u8))
                {
                    lastStableVersion = property.Value.GetString();
                    continue;
                }
            }
            return new QnAMakerEndpointKeysResponse(primaryEndpointKey.Value, secondaryEndpointKey.Value, installedVersion.Value, lastStableVersion.Value);
        }
    }
}
