// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> Job details. </summary>
    public partial class JobDetails
    {
        /// <summary> Initializes a new instance of JobDetails. </summary>
        /// <param name="containerUri"> The blob container SAS uri, the container is used to host job data. </param>
        /// <param name="inputDataFormat"> The format of the input data. </param>
        /// <param name="providerId"> The unique identifier for the provider. </param>
        /// <param name="target"> The target identifier to run the job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerUri"/>, <paramref name="inputDataFormat"/>, <paramref name="providerId"/> or <paramref name="target"/> is null. </exception>
        public JobDetails(string containerUri, string inputDataFormat, string providerId, string target)
        {
            Argument.AssertNotNull(containerUri, nameof(containerUri));
            Argument.AssertNotNull(inputDataFormat, nameof(inputDataFormat));
            Argument.AssertNotNull(providerId, nameof(providerId));
            Argument.AssertNotNull(target, nameof(target));

            ContainerUri = containerUri;
            InputDataFormat = inputDataFormat;
            ProviderId = providerId;
            Target = target;
            Metadata = new ChangeTrackingDictionary<string, string>();
            Tags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of JobDetails. </summary>
        /// <param name="id"> The job id. </param>
        /// <param name="name"> The job name. Is not required for the name to be unique and it&apos;s only used for display purposes. </param>
        /// <param name="containerUri"> The blob container SAS uri, the container is used to host job data. </param>
        /// <param name="inputDataUri"> The input blob SAS uri, if specified, it will override the default input blob in the container. </param>
        /// <param name="inputDataFormat"> The format of the input data. </param>
        /// <param name="inputParams"> The input parameters for the job. JSON object used by the target solver. It is expected that the size of this object is small and only used to specify parameters for the execution target, not the input data. </param>
        /// <param name="providerId"> The unique identifier for the provider. </param>
        /// <param name="target"> The target identifier to run the job. </param>
        /// <param name="metadata"> The job metadata. Metadata provides client the ability to store client-specific information. </param>
        /// <param name="outputDataUri"> The output blob SAS uri. When a job finishes successfully, results will be uploaded to this blob. </param>
        /// <param name="outputDataFormat"> The format of the output data. </param>
        /// <param name="status"> The job status. </param>
        /// <param name="creationTime"> The creation time of the job. </param>
        /// <param name="beginExecutionTime"> The time when the job began execution. </param>
        /// <param name="endExecutionTime"> The time when the job finished execution. </param>
        /// <param name="cancellationTime"> The time when a job was successfully cancelled. </param>
        /// <param name="costEstimate"> The job cost billed by the provider. The final cost on your bill might be slightly different due to added taxes and currency conversion rates. </param>
        /// <param name="errorData"> The error data for the job. This is expected only when Status &apos;Failed&apos;. </param>
        /// <param name="tags"> List of user-supplied tags associated with the job. </param>
        internal JobDetails(string id, string name, string containerUri, string inputDataUri, string inputDataFormat, object inputParams, string providerId, string target, IDictionary<string, string> metadata, string outputDataUri, string outputDataFormat, JobStatus? status, DateTimeOffset? creationTime, DateTimeOffset? beginExecutionTime, DateTimeOffset? endExecutionTime, DateTimeOffset? cancellationTime, CostEstimate costEstimate, ErrorData errorData, IList<string> tags)
        {
            Id = id;
            Name = name;
            ContainerUri = containerUri;
            InputDataUri = inputDataUri;
            InputDataFormat = inputDataFormat;
            InputParams = inputParams;
            ProviderId = providerId;
            Target = target;
            Metadata = metadata;
            OutputDataUri = outputDataUri;
            OutputDataFormat = outputDataFormat;
            Status = status;
            CreationTime = creationTime;
            BeginExecutionTime = beginExecutionTime;
            EndExecutionTime = endExecutionTime;
            CancellationTime = cancellationTime;
            CostEstimate = costEstimate;
            ErrorData = errorData;
            Tags = tags;
        }

        /// <summary> The job id. </summary>
        public string Id { get; set; }
        /// <summary> The job name. Is not required for the name to be unique and it&apos;s only used for display purposes. </summary>
        public string Name { get; set; }
        /// <summary> The blob container SAS uri, the container is used to host job data. </summary>
        public string ContainerUri { get; set; }
        /// <summary> The input blob SAS uri, if specified, it will override the default input blob in the container. </summary>
        public string InputDataUri { get; set; }
        /// <summary> The format of the input data. </summary>
        public string InputDataFormat { get; set; }
        /// <summary> The input parameters for the job. JSON object used by the target solver. It is expected that the size of this object is small and only used to specify parameters for the execution target, not the input data. </summary>
        public object InputParams { get; set; }
        /// <summary> The unique identifier for the provider. </summary>
        public string ProviderId { get; set; }
        /// <summary> The target identifier to run the job. </summary>
        public string Target { get; set; }
        /// <summary> The job metadata. Metadata provides client the ability to store client-specific information. </summary>
        public IDictionary<string, string> Metadata { get; set; }
        /// <summary> The output blob SAS uri. When a job finishes successfully, results will be uploaded to this blob. </summary>
        public string OutputDataUri { get; set; }
        /// <summary> The format of the output data. </summary>
        public string OutputDataFormat { get; set; }
        /// <summary> The job status. </summary>
        public JobStatus? Status { get; }
        /// <summary> The creation time of the job. </summary>
        public DateTimeOffset? CreationTime { get; }
        /// <summary> The time when the job began execution. </summary>
        public DateTimeOffset? BeginExecutionTime { get; }
        /// <summary> The time when the job finished execution. </summary>
        public DateTimeOffset? EndExecutionTime { get; }
        /// <summary> The time when a job was successfully cancelled. </summary>
        public DateTimeOffset? CancellationTime { get; }
        /// <summary> The job cost billed by the provider. The final cost on your bill might be slightly different due to added taxes and currency conversion rates. </summary>
        public CostEstimate CostEstimate { get; }
        /// <summary> The error data for the job. This is expected only when Status &apos;Failed&apos;. </summary>
        public ErrorData ErrorData { get; }
        /// <summary> List of user-supplied tags associated with the job. </summary>
        public IList<string> Tags { get; set; }
    }
}
