// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class RoleAssignmentResourceFormatData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStartObject();
                foreach (var item in Description)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(Principals))
            {
                writer.WritePropertyName("principals"u8);
                writer.WriteStartArray();
                foreach (var item in Principals)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Profiles))
            {
                writer.WritePropertyName("profiles"u8);
                writer.WriteObjectValue(Profiles);
            }
            if (Optional.IsDefined(Interactions))
            {
                writer.WritePropertyName("interactions"u8);
                writer.WriteObjectValue(Interactions);
            }
            if (Optional.IsDefined(Links))
            {
                writer.WritePropertyName("links"u8);
                writer.WriteObjectValue(Links);
            }
            if (Optional.IsDefined(Kpis))
            {
                writer.WritePropertyName("kpis"u8);
                writer.WriteObjectValue(Kpis);
            }
            if (Optional.IsDefined(SasPolicies))
            {
                writer.WritePropertyName("sasPolicies"u8);
                writer.WriteObjectValue(SasPolicies);
            }
            if (Optional.IsDefined(Connectors))
            {
                writer.WritePropertyName("connectors"u8);
                writer.WriteObjectValue(Connectors);
            }
            if (Optional.IsDefined(Views))
            {
                writer.WritePropertyName("views"u8);
                writer.WriteObjectValue(Views);
            }
            if (Optional.IsDefined(RelationshipLinks))
            {
                writer.WritePropertyName("relationshipLinks"u8);
                writer.WriteObjectValue(RelationshipLinks);
            }
            if (Optional.IsDefined(Relationships))
            {
                writer.WritePropertyName("relationships"u8);
                writer.WriteObjectValue(Relationships);
            }
            if (Optional.IsDefined(WidgetTypes))
            {
                writer.WritePropertyName("widgetTypes"u8);
                writer.WriteObjectValue(WidgetTypes);
            }
            if (Optional.IsDefined(RoleAssignments))
            {
                writer.WritePropertyName("roleAssignments"u8);
                writer.WriteObjectValue(RoleAssignments);
            }
            if (Optional.IsDefined(ConflationPolicies))
            {
                writer.WritePropertyName("conflationPolicies"u8);
                writer.WriteObjectValue(ConflationPolicies);
            }
            if (Optional.IsDefined(Segments))
            {
                writer.WritePropertyName("segments"u8);
                writer.WriteObjectValue(Segments);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RoleAssignmentResourceFormatData DeserializeRoleAssignmentResourceFormatData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> tenantId = default;
            Optional<string> assignmentName = default;
            Optional<IDictionary<string, string>> displayName = default;
            Optional<IDictionary<string, string>> description = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<RoleType> role = default;
            Optional<IList<AssignmentPrincipal>> principals = default;
            Optional<ResourceSetDescription> profiles = default;
            Optional<ResourceSetDescription> interactions = default;
            Optional<ResourceSetDescription> links = default;
            Optional<ResourceSetDescription> kpis = default;
            Optional<ResourceSetDescription> sasPolicies = default;
            Optional<ResourceSetDescription> connectors = default;
            Optional<ResourceSetDescription> views = default;
            Optional<ResourceSetDescription> relationshipLinks = default;
            Optional<ResourceSetDescription> relationships = default;
            Optional<ResourceSetDescription> widgetTypes = default;
            Optional<ResourceSetDescription> roleAssignments = default;
            Optional<ResourceSetDescription> conflationPolicies = default;
            Optional<ResourceSetDescription> segments = default;
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
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("assignmentName"u8))
                        {
                            assignmentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            displayName = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            description = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("role"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            role = property0.Value.GetString().ToRoleType();
                            continue;
                        }
                        if (property0.NameEquals("principals"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AssignmentPrincipal> array = new List<AssignmentPrincipal>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AssignmentPrincipal.DeserializeAssignmentPrincipal(item));
                            }
                            principals = array;
                            continue;
                        }
                        if (property0.NameEquals("profiles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            profiles = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("interactions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            interactions = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("links"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            links = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("kpis"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            kpis = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sasPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sasPolicies = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("connectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            connectors = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("views"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            views = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("relationshipLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            relationshipLinks = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("relationships"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            relationships = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("widgetTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            widgetTypes = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("roleAssignments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            roleAssignments = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("conflationPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            conflationPolicies = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("segments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            segments = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RoleAssignmentResourceFormatData(id, name, type, systemData.Value, Optional.ToNullable(tenantId), assignmentName.Value, Optional.ToDictionary(displayName), Optional.ToDictionary(description), Optional.ToNullable(provisioningState), Optional.ToNullable(role), Optional.ToList(principals), profiles.Value, interactions.Value, links.Value, kpis.Value, sasPolicies.Value, connectors.Value, views.Value, relationshipLinks.Value, relationships.Value, widgetTypes.Value, roleAssignments.Value, conflationPolicies.Value, segments.Value);
        }
    }
}
