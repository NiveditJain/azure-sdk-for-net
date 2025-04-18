// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeDeviceUpdateSummary : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceVersionNumber))
            {
                writer.WritePropertyName("deviceVersionNumber"u8);
                writer.WriteStringValue(DeviceVersionNumber);
            }
            if (Optional.IsDefined(FriendlyDeviceVersionName))
            {
                writer.WritePropertyName("friendlyDeviceVersionName"u8);
                writer.WriteStringValue(FriendlyDeviceVersionName);
            }
            if (Optional.IsDefined(DeviceLastScannedOn))
            {
                writer.WritePropertyName("deviceLastScannedDateTime"u8);
                writer.WriteStringValue(DeviceLastScannedOn.Value, "O");
            }
            if (Optional.IsDefined(LastCompletedScanJobOn))
            {
                writer.WritePropertyName("lastCompletedScanJobDateTime"u8);
                writer.WriteStringValue(LastCompletedScanJobOn.Value, "O");
            }
            if (Optional.IsDefined(LastSuccessfulScanJobOn))
            {
                writer.WritePropertyName("lastSuccessfulScanJobTime"u8);
                writer.WriteStringValue(LastSuccessfulScanJobOn.Value, "O");
            }
            if (Optional.IsDefined(LastSuccessfulInstallJobOn))
            {
                writer.WritePropertyName("lastSuccessfulInstallJobDateTime"u8);
                writer.WriteStringValue(LastSuccessfulInstallJobOn.Value, "O");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataBoxEdgeDeviceUpdateSummary DeserializeDataBoxEdgeDeviceUpdateSummary(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> deviceVersionNumber = default;
            Optional<string> friendlyDeviceVersionName = default;
            Optional<DateTimeOffset> deviceLastScannedDateTime = default;
            Optional<DateTimeOffset> lastCompletedScanJobDateTime = default;
            Optional<DateTimeOffset> lastSuccessfulScanJobTime = default;
            Optional<DateTimeOffset> lastCompletedDownloadJobDateTime = default;
            Optional<ResourceIdentifier> lastCompletedDownloadJobId = default;
            Optional<DataBoxEdgeJobStatus> lastDownloadJobStatus = default;
            Optional<DateTimeOffset> lastSuccessfulInstallJobDateTime = default;
            Optional<DateTimeOffset> lastCompletedInstallJobDateTime = default;
            Optional<ResourceIdentifier> lastCompletedInstallJobId = default;
            Optional<DataBoxEdgeJobStatus> lastInstallJobStatus = default;
            Optional<int> totalNumberOfUpdatesAvailable = default;
            Optional<int> totalNumberOfUpdatesPendingDownload = default;
            Optional<int> totalNumberOfUpdatesPendingInstall = default;
            Optional<InstallRebootBehavior> rebootBehavior = default;
            Optional<DataBoxEdgeUpdateOperation> ongoingUpdateOperation = default;
            Optional<ResourceIdentifier> inProgressDownloadJobId = default;
            Optional<ResourceIdentifier> inProgressInstallJobId = default;
            Optional<DateTimeOffset> inProgressDownloadJobStartedDateTime = default;
            Optional<DateTimeOffset> inProgressInstallJobStartedDateTime = default;
            Optional<IReadOnlyList<string>> updateTitles = default;
            Optional<IReadOnlyList<DataBoxEdgeUpdateDetails>> updates = default;
            Optional<double> totalUpdateSizeInBytes = default;
            Optional<int> totalTimeInMinutes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("deviceVersionNumber"u8))
                        {
                            deviceVersionNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyDeviceVersionName"u8))
                        {
                            friendlyDeviceVersionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceLastScannedDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deviceLastScannedDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastCompletedScanJobDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastCompletedScanJobDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastSuccessfulScanJobTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastSuccessfulScanJobTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastCompletedDownloadJobDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastCompletedDownloadJobDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastCompletedDownloadJobId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastCompletedDownloadJobId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastDownloadJobStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastDownloadJobStatus = new DataBoxEdgeJobStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastSuccessfulInstallJobDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastSuccessfulInstallJobDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastCompletedInstallJobDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastCompletedInstallJobDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastCompletedInstallJobId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastCompletedInstallJobId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastInstallJobStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastInstallJobStatus = new DataBoxEdgeJobStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("totalNumberOfUpdatesAvailable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            totalNumberOfUpdatesAvailable = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("totalNumberOfUpdatesPendingDownload"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            totalNumberOfUpdatesPendingDownload = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("totalNumberOfUpdatesPendingInstall"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            totalNumberOfUpdatesPendingInstall = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rebootBehavior"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            rebootBehavior = new InstallRebootBehavior(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ongoingUpdateOperation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ongoingUpdateOperation = new DataBoxEdgeUpdateOperation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("inProgressDownloadJobId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            inProgressDownloadJobId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("inProgressInstallJobId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            inProgressInstallJobId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("inProgressDownloadJobStartedDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            inProgressDownloadJobStartedDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("inProgressInstallJobStartedDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            inProgressInstallJobStartedDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updateTitles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            updateTitles = array;
                            continue;
                        }
                        if (property0.NameEquals("updates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DataBoxEdgeUpdateDetails> array = new List<DataBoxEdgeUpdateDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeUpdateDetails.DeserializeDataBoxEdgeUpdateDetails(item));
                            }
                            updates = array;
                            continue;
                        }
                        if (property0.NameEquals("totalUpdateSizeInBytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            totalUpdateSizeInBytes = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("totalTimeInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            totalTimeInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataBoxEdgeDeviceUpdateSummary(id, name, type, systemData.Value, deviceVersionNumber.Value, friendlyDeviceVersionName.Value, Optional.ToNullable(deviceLastScannedDateTime), Optional.ToNullable(lastCompletedScanJobDateTime), Optional.ToNullable(lastSuccessfulScanJobTime), Optional.ToNullable(lastCompletedDownloadJobDateTime), lastCompletedDownloadJobId.Value, Optional.ToNullable(lastDownloadJobStatus), Optional.ToNullable(lastSuccessfulInstallJobDateTime), Optional.ToNullable(lastCompletedInstallJobDateTime), lastCompletedInstallJobId.Value, Optional.ToNullable(lastInstallJobStatus), Optional.ToNullable(totalNumberOfUpdatesAvailable), Optional.ToNullable(totalNumberOfUpdatesPendingDownload), Optional.ToNullable(totalNumberOfUpdatesPendingInstall), Optional.ToNullable(rebootBehavior), Optional.ToNullable(ongoingUpdateOperation), inProgressDownloadJobId.Value, inProgressInstallJobId.Value, Optional.ToNullable(inProgressDownloadJobStartedDateTime), Optional.ToNullable(inProgressInstallJobStartedDateTime), Optional.ToList(updateTitles), Optional.ToList(updates), Optional.ToNullable(totalUpdateSizeInBytes), Optional.ToNullable(totalTimeInMinutes));
        }
    }
}
