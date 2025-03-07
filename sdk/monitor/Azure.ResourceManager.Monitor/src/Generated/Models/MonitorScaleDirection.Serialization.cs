// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    internal static partial class MonitorScaleDirectionExtensions
    {
        public static string ToSerialString(this MonitorScaleDirection value) => value switch
        {
            MonitorScaleDirection.None => "None",
            MonitorScaleDirection.Increase => "Increase",
            MonitorScaleDirection.Decrease => "Decrease",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MonitorScaleDirection value.")
        };

        public static MonitorScaleDirection ToMonitorScaleDirection(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return MonitorScaleDirection.None;
            if (string.Equals(value, "Increase", StringComparison.InvariantCultureIgnoreCase)) return MonitorScaleDirection.Increase;
            if (string.Equals(value, "Decrease", StringComparison.InvariantCultureIgnoreCase)) return MonitorScaleDirection.Decrease;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MonitorScaleDirection value.");
        }
    }
}
