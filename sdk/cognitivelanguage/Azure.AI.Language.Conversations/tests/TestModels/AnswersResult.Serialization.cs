// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    public partial class AnswersResult
    {
        internal static AnswersResult DeserializeAnswersResult(JsonElement element)
        {
            Optional<IReadOnlyList<KnowledgeBaseAnswer>> answers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("answers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KnowledgeBaseAnswer> array = new List<KnowledgeBaseAnswer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KnowledgeBaseAnswer.DeserializeKnowledgeBaseAnswer(item));
                    }
                    answers = array;
                    continue;
                }
            }
            return new AnswersResult(Optional.ToList(answers));
        }
    }
}
