// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSchemaSqlServerSqlDBDatabaseInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(TargetDatabaseName))
            {
                writer.WritePropertyName("targetDatabaseName"u8);
                writer.WriteStringValue(TargetDatabaseName);
            }
            if (Optional.IsDefined(SchemaSetting))
            {
                writer.WritePropertyName("schemaSetting"u8);
                writer.WriteObjectValue(SchemaSetting);
            }
            writer.WriteEndObject();
        }

        internal static MigrateSchemaSqlServerSqlDBDatabaseInput DeserializeMigrateSchemaSqlServerSqlDBDatabaseInput(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<string> targetDatabaseName = default;
            Optional<SchemaMigrationSetting> schemaSetting = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDatabaseName"u8))
                {
                    targetDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schemaSetting = SchemaMigrationSetting.DeserializeSchemaMigrationSetting(property.Value);
                    continue;
                }
            }
            return new MigrateSchemaSqlServerSqlDBDatabaseInput(name.Value, id.Value, targetDatabaseName.Value, schemaSetting.Value);
        }
    }
}
