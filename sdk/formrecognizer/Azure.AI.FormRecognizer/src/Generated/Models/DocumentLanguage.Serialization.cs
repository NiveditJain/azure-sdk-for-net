// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentLanguage
    {
        internal static DocumentLanguage DeserializeDocumentLanguage(JsonElement element)
        {
            string locale = default;
            IReadOnlyList<DocumentSpan> spans = default;
            float confidence = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("locale"u8))
                {
                    locale = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("spans"u8))
                {
                    List<DocumentSpan> array = new List<DocumentSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item));
                    }
                    spans = array;
                    continue;
                }
                if (property.NameEquals("confidence"u8))
                {
                    confidence = property.Value.GetSingle();
                    continue;
                }
            }
            return new DocumentLanguage(locale, spans, confidence);
        }
    }
}
