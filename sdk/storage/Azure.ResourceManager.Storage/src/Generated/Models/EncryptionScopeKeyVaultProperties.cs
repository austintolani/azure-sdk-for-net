// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The key vault properties for the encryption scope. This is a required field if encryption scope 'source' attribute is set to 'Microsoft.KeyVault'. </summary>
    public partial class EncryptionScopeKeyVaultProperties
    {
        /// <summary> Initializes a new instance of EncryptionScopeKeyVaultProperties. </summary>
        public EncryptionScopeKeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of EncryptionScopeKeyVaultProperties. </summary>
        /// <param name="keyUri"> The object identifier for a key vault key object. When applied, the encryption scope will use the key referenced by the identifier to enable customer-managed key support on this encryption scope. </param>
        /// <param name="currentVersionedKeyIdentifier"> The object identifier of the current versioned Key Vault Key in use. </param>
        /// <param name="lastKeyRotationTimestamp"> Timestamp of last rotation of the Key Vault Key. </param>
        internal EncryptionScopeKeyVaultProperties(Uri keyUri, string currentVersionedKeyIdentifier, DateTimeOffset? lastKeyRotationTimestamp)
        {
            KeyUri = keyUri;
            CurrentVersionedKeyIdentifier = currentVersionedKeyIdentifier;
            LastKeyRotationTimestamp = lastKeyRotationTimestamp;
        }

        /// <summary> The object identifier for a key vault key object. When applied, the encryption scope will use the key referenced by the identifier to enable customer-managed key support on this encryption scope. </summary>
        public Uri KeyUri { get; set; }
        /// <summary> The object identifier of the current versioned Key Vault Key in use. </summary>
        public string CurrentVersionedKeyIdentifier { get; }
        /// <summary> Timestamp of last rotation of the Key Vault Key. </summary>
        public DateTimeOffset? LastKeyRotationTimestamp { get; }
    }
}
