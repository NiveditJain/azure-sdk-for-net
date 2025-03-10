// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Result of the schedule list operation. </summary>
    internal partial class ScheduleListResult
    {
        /// <summary> Initializes a new instance of ScheduleListResult. </summary>
        internal ScheduleListResult()
        {
            Value = new ChangeTrackingList<ScheduleData>();
        }

        /// <summary> Initializes a new instance of ScheduleListResult. </summary>
        /// <param name="value"> Current page of results. </param>
        /// <param name="nextLink"> URL to get the next set of results if there are any. </param>
        internal ScheduleListResult(IReadOnlyList<ScheduleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Current page of results. </summary>
        public IReadOnlyList<ScheduleData> Value { get; }
        /// <summary> URL to get the next set of results if there are any. </summary>
        public string NextLink { get; }
    }
}
