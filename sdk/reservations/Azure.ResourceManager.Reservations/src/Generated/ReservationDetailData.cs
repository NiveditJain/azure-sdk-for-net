// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Reservations.Models;

namespace Azure.ResourceManager.Reservations
{
    /// <summary> A class representing the ReservationDetail data model. </summary>
    public partial class ReservationDetailData : ResourceData
    {
        /// <summary> Initializes a new instance of ReservationDetailData. </summary>
        internal ReservationDetailData()
        {
        }

        /// <summary> Initializes a new instance of ReservationDetailData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The Azure Region where the reserved resource lives. </param>
        /// <param name="version"></param>
        /// <param name="sku"> The sku information associated to this reservation. </param>
        /// <param name="properties"> The properties associated to this reservation. </param>
        /// <param name="kind"> Resource Provider type to be reserved. </param>
        internal ReservationDetailData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, int? version, ReservationsSkuName sku, ReservationProperties properties, ReservationKind? kind) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Version = version;
            Sku = sku;
            Properties = properties;
            Kind = kind;
        }

        /// <summary> The Azure Region where the reserved resource lives. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Gets the version. </summary>
        public int? Version { get; }
        /// <summary> The sku information associated to this reservation. </summary>
        internal ReservationsSkuName Sku { get; }
        /// <summary> Gets the sku name. </summary>
        public string SkuName
        {
            get => Sku?.Name;
        }

        /// <summary> The properties associated to this reservation. </summary>
        public ReservationProperties Properties { get; }
        /// <summary> Resource Provider type to be reserved. </summary>
        public ReservationKind? Kind { get; }
    }
}
