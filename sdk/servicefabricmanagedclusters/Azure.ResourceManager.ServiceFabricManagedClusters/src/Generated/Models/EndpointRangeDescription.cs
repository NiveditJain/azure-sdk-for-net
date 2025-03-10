// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Port range details. </summary>
    public partial class EndpointRangeDescription
    {
        /// <summary> Initializes a new instance of EndpointRangeDescription. </summary>
        /// <param name="startPort"> Starting port of a range of ports. </param>
        /// <param name="endPort"> End port of a range of ports. </param>
        public EndpointRangeDescription(int startPort, int endPort)
        {
            StartPort = startPort;
            EndPort = endPort;
        }

        /// <summary> Starting port of a range of ports. </summary>
        public int StartPort { get; set; }
        /// <summary> End port of a range of ports. </summary>
        public int EndPort { get; set; }
    }
}
