// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AbstractiveSummarizationResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("errors"u8);
            writer.WriteStartArray();
            foreach (var item in Errors)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics"u8);
                writer.WriteObjectValue(Statistics);
            }
            writer.WritePropertyName("modelVersion"u8);
            writer.WriteStringValue(ModelVersion);
            writer.WritePropertyName("documents"u8);
            writer.WriteStartArray();
            foreach (var item in Documents)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static AbstractiveSummarizationResult DeserializeAbstractiveSummarizationResult(JsonElement element)
        {
            IList<InputError> errors = default;
            Optional<TextDocumentBatchStatistics> statistics = default;
            string modelVersion = default;
            IList<AbstractiveSummaryDocumentResultWithDetectedLanguage> documents = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errors"u8))
                {
                    List<InputError> array = new List<InputError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputError.DeserializeInputError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statistics = TextDocumentBatchStatistics.DeserializeTextDocumentBatchStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documents"u8))
                {
                    List<AbstractiveSummaryDocumentResultWithDetectedLanguage> array = new List<AbstractiveSummaryDocumentResultWithDetectedLanguage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AbstractiveSummaryDocumentResultWithDetectedLanguage.DeserializeAbstractiveSummaryDocumentResultWithDetectedLanguage(item));
                    }
                    documents = array;
                    continue;
                }
            }
            return new AbstractiveSummarizationResult(documents, errors, statistics.Value, modelVersion);
        }
    }
}
