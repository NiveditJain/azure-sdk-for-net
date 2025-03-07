// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ColumnTransformer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Fields))
            {
                if (Fields != null)
                {
                    writer.WritePropertyName("fields"u8);
                    writer.WriteStartArray();
                    foreach (var item in Fields)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("fields");
                }
            }
            if (Optional.IsDefined(Parameters))
            {
                if (Parameters != null)
                {
                    writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(Parameters.ToString()).RootElement);
#endif
                }
                else
                {
                    writer.WriteNull("parameters");
                }
            }
            writer.WriteEndObject();
        }

        internal static ColumnTransformer DeserializeColumnTransformer(JsonElement element)
        {
            Optional<IList<string>> fields = default;
            Optional<BinaryData> parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fields = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fields = array;
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        parameters = null;
                        continue;
                    }
                    parameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new ColumnTransformer(Optional.ToList(fields), parameters.Value);
        }
    }
}
