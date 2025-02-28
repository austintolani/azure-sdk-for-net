// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> An AML file system update instance. </summary>
    public partial class AmlFileSystemPatch
    {
        /// <summary> Initializes a new instance of AmlFileSystemPatch. </summary>
        public AmlFileSystemPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Specifies encryption settings of the AML file system. </summary>
        internal AmlFileSystemEncryptionSettings EncryptionSettings { get; set; }
        /// <summary> Specifies the location of the encryption key in Key Vault. </summary>
        public StorageCacheEncryptionKeyVaultKeyReference KeyEncryptionKey
        {
            get => EncryptionSettings is null ? default : EncryptionSettings.KeyEncryptionKey;
            set
            {
                if (EncryptionSettings is null)
                    EncryptionSettings = new AmlFileSystemEncryptionSettings();
                EncryptionSettings.KeyEncryptionKey = value;
            }
        }

        /// <summary> Start time of a 30-minute weekly maintenance window. </summary>
        public AmlFileSystemUpdatePropertiesMaintenanceWindow MaintenanceWindow { get; set; }
    }
}
