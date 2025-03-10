// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    public partial class UnivariateLastDetectionResult
    {
        internal static UnivariateLastDetectionResult DeserializeUnivariateLastDetectionResult(JsonElement element)
        {
            int period = default;
            int suggestedWindow = default;
            float expectedValue = default;
            float upperMargin = default;
            float lowerMargin = default;
            bool isAnomaly = default;
            bool isNegativeAnomaly = default;
            bool isPositiveAnomaly = default;
            Optional<float?> severity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("period"u8))
                {
                    period = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("suggestedWindow"u8))
                {
                    suggestedWindow = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("expectedValue"u8))
                {
                    expectedValue = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("upperMargin"u8))
                {
                    upperMargin = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("lowerMargin"u8))
                {
                    lowerMargin = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("isAnomaly"u8))
                {
                    isAnomaly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isNegativeAnomaly"u8))
                {
                    isNegativeAnomaly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isPositiveAnomaly"u8))
                {
                    isPositiveAnomaly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        severity = null;
                        continue;
                    }
                    severity = property.Value.GetSingle();
                    continue;
                }
            }
            return new UnivariateLastDetectionResult(period, suggestedWindow, expectedValue, upperMargin, lowerMargin, isAnomaly, isNegativeAnomaly, isPositiveAnomaly, Optional.ToNullable(severity));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static UnivariateLastDetectionResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnivariateLastDetectionResult(document.RootElement);
        }
    }
}
