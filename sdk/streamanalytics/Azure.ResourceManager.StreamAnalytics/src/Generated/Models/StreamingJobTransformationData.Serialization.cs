// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics
{
    public partial class StreamingJobTransformationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StreamingUnits))
            {
                writer.WritePropertyName("streamingUnits"u8);
                writer.WriteNumberValue(StreamingUnits.Value);
            }
            if (Optional.IsCollectionDefined(ValidStreamingUnits))
            {
                writer.WritePropertyName("validStreamingUnits"u8);
                writer.WriteStartArray();
                foreach (var item in ValidStreamingUnits)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StreamingJobTransformationData DeserializeStreamingJobTransformationData(JsonElement element)
        {
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<int> streamingUnits = default;
            Optional<IList<int>> validStreamingUnits = default;
            Optional<string> query = default;
            Optional<ETag> etag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("streamingUnits"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            streamingUnits = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("validStreamingUnits"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<int> array = new List<int>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetInt32());
                            }
                            validStreamingUnits = array;
                            continue;
                        }
                        if (property0.NameEquals("query"u8))
                        {
                            query = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("etag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            etag = new ETag(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StreamingJobTransformationData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(streamingUnits), Optional.ToList(validStreamingUnits), query.Value, Optional.ToNullable(etag));
        }
    }
}
