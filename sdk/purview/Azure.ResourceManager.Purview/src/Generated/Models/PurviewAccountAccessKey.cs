// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The Account access keys. </summary>
    public partial class PurviewAccountAccessKey
    {
        /// <summary> Initializes a new instance of PurviewAccountAccessKey. </summary>
        internal PurviewAccountAccessKey()
        {
        }

        /// <summary> Initializes a new instance of PurviewAccountAccessKey. </summary>
        /// <param name="atlasKafkaPrimaryEndpoint"> Gets or sets the primary connection string. </param>
        /// <param name="atlasKafkaSecondaryEndpoint"> Gets or sets the secondary connection string. </param>
        internal PurviewAccountAccessKey(string atlasKafkaPrimaryEndpoint, string atlasKafkaSecondaryEndpoint)
        {
            AtlasKafkaPrimaryEndpoint = atlasKafkaPrimaryEndpoint;
            AtlasKafkaSecondaryEndpoint = atlasKafkaSecondaryEndpoint;
        }

        /// <summary> Gets or sets the primary connection string. </summary>
        public string AtlasKafkaPrimaryEndpoint { get; }
        /// <summary> Gets or sets the secondary connection string. </summary>
        public string AtlasKafkaSecondaryEndpoint { get; }
    }
}
