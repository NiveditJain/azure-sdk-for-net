// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> Defines a specific step on a target service unit. </summary>
    public partial class RolloutStep
    {
        /// <summary> Initializes a new instance of RolloutStep. </summary>
        /// <param name="name"> Name of the step. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal RolloutStep(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceOperations = new ChangeTrackingList<ResourceOperation>();
            Messages = new ChangeTrackingList<Message>();
        }

        /// <summary> Initializes a new instance of RolloutStep. </summary>
        /// <param name="name"> Name of the step. </param>
        /// <param name="status"> Current state of the step. </param>
        /// <param name="stepGroup"> The step group the current step is part of. </param>
        /// <param name="operationInfo"> Detailed information of specific action execution. </param>
        /// <param name="resourceOperations"> Set of resource operations that were performed, if any, on an Azure resource. </param>
        /// <param name="messages"> Supplementary informative messages during rollout. </param>
        internal RolloutStep(string name, string status, string stepGroup, StepOperationInfo operationInfo, IReadOnlyList<ResourceOperation> resourceOperations, IReadOnlyList<Message> messages)
        {
            Name = name;
            Status = status;
            StepGroup = stepGroup;
            OperationInfo = operationInfo;
            ResourceOperations = resourceOperations;
            Messages = messages;
        }

        /// <summary> Name of the step. </summary>
        public string Name { get; }
        /// <summary> Current state of the step. </summary>
        public string Status { get; }
        /// <summary> The step group the current step is part of. </summary>
        public string StepGroup { get; }
        /// <summary> Detailed information of specific action execution. </summary>
        public StepOperationInfo OperationInfo { get; }
        /// <summary> Set of resource operations that were performed, if any, on an Azure resource. </summary>
        public IReadOnlyList<ResourceOperation> ResourceOperations { get; }
        /// <summary> Supplementary informative messages during rollout. </summary>
        public IReadOnlyList<Message> Messages { get; }
    }
}
