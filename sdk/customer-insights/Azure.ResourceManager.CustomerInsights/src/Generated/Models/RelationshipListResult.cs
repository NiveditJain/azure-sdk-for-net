// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The response of list relationship operation. </summary>
    internal partial class RelationshipListResult
    {
        /// <summary> Initializes a new instance of RelationshipListResult. </summary>
        internal RelationshipListResult()
        {
            Value = new ChangeTrackingList<RelationshipResourceFormatData>();
        }

        /// <summary> Initializes a new instance of RelationshipListResult. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal RelationshipListResult(IReadOnlyList<RelationshipResourceFormatData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<RelationshipResourceFormatData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
