// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary> A class representing the DataBoxEdgeAlert data model. </summary>
    public partial class DataBoxEdgeAlertData : ResourceData
    {
        /// <summary> Initializes a new instance of DataBoxEdgeAlertData. </summary>
        public DataBoxEdgeAlertData()
        {
            DetailedInformation = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DataBoxEdgeAlertData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="title"> Alert title. </param>
        /// <param name="alertType"> Alert type. </param>
        /// <param name="appearedOn"> UTC time when the alert appeared. </param>
        /// <param name="recommendation"> Alert recommendation. </param>
        /// <param name="severity"> Severity of the alert. </param>
        /// <param name="errorDetails"> Error details of the alert. </param>
        /// <param name="detailedInformation"> Alert details. </param>
        internal DataBoxEdgeAlertData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string title, string alertType, DateTimeOffset? appearedOn, string recommendation, DataBoxEdgeAlertSeverity? severity, DataBoxEdgeAlertErrorDetails errorDetails, IReadOnlyDictionary<string, string> detailedInformation) : base(id, name, resourceType, systemData)
        {
            Title = title;
            AlertType = alertType;
            AppearedOn = appearedOn;
            Recommendation = recommendation;
            Severity = severity;
            ErrorDetails = errorDetails;
            DetailedInformation = detailedInformation;
        }

        /// <summary> Alert title. </summary>
        public string Title { get; }
        /// <summary> Alert type. </summary>
        public string AlertType { get; }
        /// <summary> UTC time when the alert appeared. </summary>
        public DateTimeOffset? AppearedOn { get; }
        /// <summary> Alert recommendation. </summary>
        public string Recommendation { get; }
        /// <summary> Severity of the alert. </summary>
        public DataBoxEdgeAlertSeverity? Severity { get; }
        /// <summary> Error details of the alert. </summary>
        public DataBoxEdgeAlertErrorDetails ErrorDetails { get; }
        /// <summary> Alert details. </summary>
        public IReadOnlyDictionary<string, string> DetailedInformation { get; }
    }
}
