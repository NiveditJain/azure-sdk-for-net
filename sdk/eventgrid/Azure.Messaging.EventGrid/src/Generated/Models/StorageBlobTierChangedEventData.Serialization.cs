// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(StorageBlobTierChangedEventDataConverter))]
    public partial class StorageBlobTierChangedEventData
    {
        internal static StorageBlobTierChangedEventData DeserializeStorageBlobTierChangedEventData(JsonElement element)
        {
            Optional<string> api = default;
            Optional<string> clientRequestId = default;
            Optional<string> requestId = default;
            Optional<string> contentType = default;
            Optional<long> contentLength = default;
            Optional<string> blobType = default;
            Optional<string> url = default;
            Optional<string> sequencer = default;
            Optional<string> identity = default;
            Optional<object> storageDiagnostics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("api"u8))
                {
                    api = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"u8))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    contentLength = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("blobType"u8))
                {
                    blobType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequencer"u8))
                {
                    sequencer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageDiagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageDiagnostics = property.Value.GetObject();
                    continue;
                }
            }
            return new StorageBlobTierChangedEventData(api.Value, clientRequestId.Value, requestId.Value, contentType.Value, Optional.ToNullable(contentLength), blobType.Value, url.Value, sequencer.Value, identity.Value, storageDiagnostics.Value);
        }

        internal partial class StorageBlobTierChangedEventDataConverter : JsonConverter<StorageBlobTierChangedEventData>
        {
            public override void Write(Utf8JsonWriter writer, StorageBlobTierChangedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override StorageBlobTierChangedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStorageBlobTierChangedEventData(document.RootElement);
            }
        }
    }
}
