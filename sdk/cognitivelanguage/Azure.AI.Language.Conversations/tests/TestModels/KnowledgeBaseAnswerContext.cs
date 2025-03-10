// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.AI.Language.Conversations
{
    /// <summary> Context object with previous QnA&apos;s information. </summary>
    public partial class KnowledgeBaseAnswerContext
    {
        /// <summary> Initializes a new instance of KnowledgeBaseAnswerContext. </summary>
        /// <param name="previousQnaId"> Previous turn top answer result QnA ID. </param>
        public KnowledgeBaseAnswerContext(int previousQnaId)
        {
            PreviousQnaId = previousQnaId;
        }

        /// <summary> Previous turn top answer result QnA ID. </summary>
        public int PreviousQnaId { get; }
        /// <summary> Previous user query. </summary>
        public string PreviousQuestion { get; set; }
    }
}
