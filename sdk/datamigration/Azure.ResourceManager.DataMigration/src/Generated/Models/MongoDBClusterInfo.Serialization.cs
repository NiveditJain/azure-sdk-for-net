// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDBClusterInfo
    {
        internal static MongoDBClusterInfo DeserializeMongoDBClusterInfo(JsonElement element)
        {
            IReadOnlyList<MongoDBDatabaseInfo> databases = default;
            bool supportsSharding = default;
            MongoDBClusterType type = default;
            string version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databases"u8))
                {
                    List<MongoDBDatabaseInfo> array = new List<MongoDBDatabaseInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MongoDBDatabaseInfo.DeserializeMongoDBDatabaseInfo(item));
                    }
                    databases = array;
                    continue;
                }
                if (property.NameEquals("supportsSharding"u8))
                {
                    supportsSharding = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new MongoDBClusterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
            }
            return new MongoDBClusterInfo(databases, supportsSharding, type, version);
        }
    }
}
