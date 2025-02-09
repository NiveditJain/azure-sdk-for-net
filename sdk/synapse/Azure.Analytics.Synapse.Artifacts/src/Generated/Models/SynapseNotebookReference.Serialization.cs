// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SynapseNotebookReferenceConverter))]
    public partial class SynapseNotebookReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("referenceName"u8);
            writer.WriteObjectValue(ReferenceName);
            writer.WriteEndObject();
        }

        internal static SynapseNotebookReference DeserializeSynapseNotebookReference(JsonElement element)
        {
            NotebookReferenceType type = default;
            object referenceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new NotebookReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"u8))
                {
                    referenceName = property.Value.GetObject();
                    continue;
                }
            }
            return new SynapseNotebookReference(type, referenceName);
        }

        internal partial class SynapseNotebookReferenceConverter : JsonConverter<SynapseNotebookReference>
        {
            public override void Write(Utf8JsonWriter writer, SynapseNotebookReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SynapseNotebookReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSynapseNotebookReference(document.RootElement);
            }
        }
    }
}
