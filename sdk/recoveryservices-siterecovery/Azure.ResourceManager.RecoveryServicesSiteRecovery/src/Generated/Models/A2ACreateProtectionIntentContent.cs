// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A create protection intent input. </summary>
    public partial class A2ACreateProtectionIntentContent : SiteRecoveryCreateProtectionIntentProviderDetail
    {
        /// <summary> Initializes a new instance of A2ACreateProtectionIntentContent. </summary>
        /// <param name="fabricObjectId"> The fabric specific object Id of the virtual machine. </param>
        /// <param name="primaryLocation"> The primary location for the virtual machine. </param>
        /// <param name="recoveryLocation"> The recovery location for the virtual machine. </param>
        /// <param name="recoverySubscriptionId"> The recovery subscription Id of the virtual machine. </param>
        /// <param name="recoveryAvailabilityType"> The recovery availability type of the virtual machine. </param>
        /// <param name="recoveryResourceGroupId"> The recovery resource group Id. Valid for V2 scenarios. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricObjectId"/>, <paramref name="recoverySubscriptionId"/> or <paramref name="recoveryResourceGroupId"/> is null. </exception>
        public A2ACreateProtectionIntentContent(ResourceIdentifier fabricObjectId, AzureLocation primaryLocation, AzureLocation recoveryLocation, string recoverySubscriptionId, A2ARecoveryAvailabilityType recoveryAvailabilityType, ResourceIdentifier recoveryResourceGroupId)
        {
            Argument.AssertNotNull(fabricObjectId, nameof(fabricObjectId));
            Argument.AssertNotNull(recoverySubscriptionId, nameof(recoverySubscriptionId));
            Argument.AssertNotNull(recoveryResourceGroupId, nameof(recoveryResourceGroupId));

            FabricObjectId = fabricObjectId;
            PrimaryLocation = primaryLocation;
            RecoveryLocation = recoveryLocation;
            RecoverySubscriptionId = recoverySubscriptionId;
            RecoveryAvailabilityType = recoveryAvailabilityType;
            RecoveryResourceGroupId = recoveryResourceGroupId;
            VmDisks = new ChangeTrackingList<A2AProtectionIntentDiskDetails>();
            VmManagedDisks = new ChangeTrackingList<A2AProtectionIntentManagedDiskDetails>();
            InstanceType = "A2A";
        }

        /// <summary> The fabric specific object Id of the virtual machine. </summary>
        public ResourceIdentifier FabricObjectId { get; }
        /// <summary> The primary location for the virtual machine. </summary>
        public AzureLocation PrimaryLocation { get; }
        /// <summary> The recovery location for the virtual machine. </summary>
        public AzureLocation RecoveryLocation { get; }
        /// <summary> The recovery subscription Id of the virtual machine. </summary>
        public string RecoverySubscriptionId { get; }
        /// <summary> The recovery availability type of the virtual machine. </summary>
        public A2ARecoveryAvailabilityType RecoveryAvailabilityType { get; }
        /// <summary>
        /// The protection profile custom inputs.
        /// Please note <see cref="ProtectionProfileCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingProtectionProfile"/> and <see cref="NewProtectionProfile"/>.
        /// </summary>
        public ProtectionProfileCustomDetails ProtectionProfileCustomContent { get; set; }
        /// <summary> The recovery resource group Id. Valid for V2 scenarios. </summary>
        public ResourceIdentifier RecoveryResourceGroupId { get; }
        /// <summary>
        /// The primary staging storage account input.
        /// Please note <see cref="StorageAccountCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingStorageAccount"/>.
        /// </summary>
        public StorageAccountCustomDetails PrimaryStagingStorageAccountCustomContent { get; set; }
        /// <summary>
        /// The recovery availability set input.
        /// Please note <see cref="RecoveryAvailabilitySetCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingRecoveryAvailabilitySet"/>.
        /// </summary>
        public RecoveryAvailabilitySetCustomDetails RecoveryAvailabilitySetCustomContent { get; set; }
        /// <summary>
        /// The recovery virtual network input.
        /// Please note <see cref="RecoveryVirtualNetworkCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingRecoveryVirtualNetwork"/> and <see cref="NewRecoveryVirtualNetwork"/>.
        /// </summary>
        public RecoveryVirtualNetworkCustomDetails RecoveryVirtualNetworkCustomContent { get; set; }
        /// <summary>
        /// The recovery proximity placement group custom input.
        /// Please note <see cref="RecoveryProximityPlacementGroupCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingRecoveryProximityPlacementGroup"/>.
        /// </summary>
        public RecoveryProximityPlacementGroupCustomDetails RecoveryProximityPlacementGroupCustomContent { get; set; }
        /// <summary> A value indicating whether the auto protection is enabled. </summary>
        public AutoProtectionOfDataDisk? AutoProtectionOfDataDisk { get; set; }
        /// <summary> The list of vm disk inputs. </summary>
        public IList<A2AProtectionIntentDiskDetails> VmDisks { get; }
        /// <summary> The list of vm managed disk inputs. </summary>
        public IList<A2AProtectionIntentManagedDiskDetails> VmManagedDisks { get; }
        /// <summary> The multi vm group name. </summary>
        public string MultiVmGroupName { get; set; }
        /// <summary> The multi vm group id. </summary>
        public string MultiVmGroupId { get; set; }
        /// <summary>
        /// The boot diagnostic storage account.
        /// Please note <see cref="StorageAccountCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingStorageAccount"/>.
        /// </summary>
        public StorageAccountCustomDetails RecoveryBootDiagStorageAccount { get; set; }
        /// <summary> The recovery disk encryption information (for two pass flows). </summary>
        public SiteRecoveryDiskEncryptionInfo DiskEncryptionInfo { get; set; }
        /// <summary> The recovery availability zone. </summary>
        public string RecoveryAvailabilityZone { get; set; }
        /// <summary> A value indicating whether the auto update is enabled. </summary>
        public SiteRecoveryAgentAutoUpdateStatus? AgentAutoUpdateStatus { get; set; }
        /// <summary> A value indicating the authentication type for automation account. The default value is "RunAsAccount". </summary>
        public AutomationAccountAuthenticationType? AutomationAccountAuthenticationType { get; set; }
        /// <summary> The automation account arm id. </summary>
        public ResourceIdentifier AutomationAccountArmId { get; set; }
    }
}
