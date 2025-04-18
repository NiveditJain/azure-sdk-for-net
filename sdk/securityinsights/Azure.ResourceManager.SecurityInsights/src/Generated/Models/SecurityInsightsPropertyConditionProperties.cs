// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes an automation rule condition that evaluates a property&apos;s value. </summary>
    public partial class SecurityInsightsPropertyConditionProperties : SecurityInsightsAutomationRuleCondition
    {
        /// <summary> Initializes a new instance of SecurityInsightsPropertyConditionProperties. </summary>
        public SecurityInsightsPropertyConditionProperties()
        {
            ConditionType = ConditionType.Property;
        }

        /// <summary> Initializes a new instance of SecurityInsightsPropertyConditionProperties. </summary>
        /// <param name="conditionType"></param>
        /// <param name="conditionProperties"></param>
        internal SecurityInsightsPropertyConditionProperties(ConditionType conditionType, AutomationRulePropertyValuesCondition conditionProperties) : base(conditionType)
        {
            ConditionProperties = conditionProperties;
            ConditionType = conditionType;
        }

        /// <summary> Gets or sets the condition properties. </summary>
        public AutomationRulePropertyValuesCondition ConditionProperties { get; set; }
    }
}
