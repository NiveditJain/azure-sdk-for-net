// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The UnknownProtectionContainer. </summary>
    internal partial class UnknownProtectionContainer : ProtectionContainer
    {
        /// <summary> Initializes a new instance of UnknownProtectionContainer. </summary>
        /// <param name="friendlyName"> Friendly name of the container. </param>
        /// <param name="backupManagementType"> Type of backup management for the container. </param>
        /// <param name="registrationStatus"> Status of registration of the container with the Recovery Services Vault. </param>
        /// <param name="healthStatus"> Status of health of the container. </param>
        /// <param name="containerType">
        /// Type of the container. The value of this property for: 1. Compute Azure VM is Microsoft.Compute/virtualMachines 2.
        /// Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like MAB, DPM etc) is
        /// Windows 4. Azure SQL instance is AzureSqlContainer. 5. Storage containers is StorageContainer. 6. Azure workload
        /// Backup is VMAppContainer
        /// </param>
        /// <param name="protectableObjectType"> Type of the protectable object associated with this container. </param>
        internal UnknownProtectionContainer(string friendlyName, BackupManagementType? backupManagementType, string registrationStatus, string healthStatus, ProtectableContainerType containerType, string protectableObjectType) : base(friendlyName, backupManagementType, registrationStatus, healthStatus, containerType, protectableObjectType)
        {
            ContainerType = containerType;
        }
    }
}
