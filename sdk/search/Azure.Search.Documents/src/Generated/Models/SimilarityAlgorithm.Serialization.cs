// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SimilarityAlgorithm : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WriteEndObject();
        }

        internal static SimilarityAlgorithm DeserializeSimilarityAlgorithm(JsonElement element)
        {
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Azure.Search.BM25Similarity": return BM25Similarity.DeserializeBM25Similarity(element);
                    case "#Microsoft.Azure.Search.ClassicSimilarity": return ClassicSimilarity.DeserializeClassicSimilarity(element);
                }
            }
            return UnknownSimilarity.DeserializeUnknownSimilarity(element);
        }
    }
}
