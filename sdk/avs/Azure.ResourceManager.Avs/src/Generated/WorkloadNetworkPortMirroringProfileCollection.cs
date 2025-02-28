// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkloadNetworkPortMirroringProfileResource" /> and their operations.
    /// Each <see cref="WorkloadNetworkPortMirroringProfileResource" /> in the collection will belong to the same instance of <see cref="AvsPrivateCloudResource" />.
    /// To get a <see cref="WorkloadNetworkPortMirroringProfileCollection" /> instance call the GetWorkloadNetworkPortMirroringProfiles method from an instance of <see cref="AvsPrivateCloudResource" />.
    /// </summary>
    public partial class WorkloadNetworkPortMirroringProfileCollection : ArmCollection, IEnumerable<WorkloadNetworkPortMirroringProfileResource>, IAsyncEnumerable<WorkloadNetworkPortMirroringProfileResource>
    {
        private readonly ClientDiagnostics _workloadNetworkPortMirroringProfileWorkloadNetworksClientDiagnostics;
        private readonly WorkloadNetworksRestOperations _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkPortMirroringProfileCollection"/> class for mocking. </summary>
        protected WorkloadNetworkPortMirroringProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkPortMirroringProfileCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkloadNetworkPortMirroringProfileCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadNetworkPortMirroringProfileWorkloadNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", WorkloadNetworkPortMirroringProfileResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkloadNetworkPortMirroringProfileResource.ResourceType, out string workloadNetworkPortMirroringProfileWorkloadNetworksApiVersion);
            _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient = new WorkloadNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadNetworkPortMirroringProfileWorkloadNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AvsPrivateCloudResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AvsPrivateCloudResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a port mirroring profile by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/portMirroringProfiles/{portMirroringId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreatePortMirroring</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="portMirroringId"> NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name. </param>
        /// <param name="data"> NSX port mirroring. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portMirroringId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portMirroringId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkloadNetworkPortMirroringProfileResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string portMirroringId, WorkloadNetworkPortMirroringProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portMirroringId, nameof(portMirroringId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkPortMirroringProfileWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPortMirroringProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient.CreatePortMirroringAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portMirroringId, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<WorkloadNetworkPortMirroringProfileResource>(new WorkloadNetworkPortMirroringProfileOperationSource(Client), _workloadNetworkPortMirroringProfileWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient.CreateCreatePortMirroringRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portMirroringId, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a port mirroring profile by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/portMirroringProfiles/{portMirroringId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreatePortMirroring</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="portMirroringId"> NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name. </param>
        /// <param name="data"> NSX port mirroring. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portMirroringId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portMirroringId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkloadNetworkPortMirroringProfileResource> CreateOrUpdate(WaitUntil waitUntil, string portMirroringId, WorkloadNetworkPortMirroringProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portMirroringId, nameof(portMirroringId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkPortMirroringProfileWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPortMirroringProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient.CreatePortMirroring(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portMirroringId, data, cancellationToken);
                var operation = new AvsArmOperation<WorkloadNetworkPortMirroringProfileResource>(new WorkloadNetworkPortMirroringProfileOperationSource(Client), _workloadNetworkPortMirroringProfileWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient.CreateCreatePortMirroringRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portMirroringId, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a port mirroring profile by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/portMirroringProfiles/{portMirroringId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetPortMirroring</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portMirroringId"> NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portMirroringId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portMirroringId"/> is null. </exception>
        public virtual async Task<Response<WorkloadNetworkPortMirroringProfileResource>> GetAsync(string portMirroringId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portMirroringId, nameof(portMirroringId));

            using var scope = _workloadNetworkPortMirroringProfileWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPortMirroringProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient.GetPortMirroringAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portMirroringId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkPortMirroringProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a port mirroring profile by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/portMirroringProfiles/{portMirroringId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetPortMirroring</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portMirroringId"> NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portMirroringId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portMirroringId"/> is null. </exception>
        public virtual Response<WorkloadNetworkPortMirroringProfileResource> Get(string portMirroringId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portMirroringId, nameof(portMirroringId));

            using var scope = _workloadNetworkPortMirroringProfileWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPortMirroringProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient.GetPortMirroring(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portMirroringId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkPortMirroringProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of port mirroring profiles in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/portMirroringProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListPortMirroring</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadNetworkPortMirroringProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadNetworkPortMirroringProfileResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient.CreateListPortMirroringRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient.CreateListPortMirroringNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WorkloadNetworkPortMirroringProfileResource(Client, WorkloadNetworkPortMirroringProfileData.DeserializeWorkloadNetworkPortMirroringProfileData(e)), _workloadNetworkPortMirroringProfileWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkPortMirroringProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of port mirroring profiles in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/portMirroringProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListPortMirroring</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadNetworkPortMirroringProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadNetworkPortMirroringProfileResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient.CreateListPortMirroringRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient.CreateListPortMirroringNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WorkloadNetworkPortMirroringProfileResource(Client, WorkloadNetworkPortMirroringProfileData.DeserializeWorkloadNetworkPortMirroringProfileData(e)), _workloadNetworkPortMirroringProfileWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkPortMirroringProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/portMirroringProfiles/{portMirroringId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetPortMirroring</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portMirroringId"> NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portMirroringId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portMirroringId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string portMirroringId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portMirroringId, nameof(portMirroringId));

            using var scope = _workloadNetworkPortMirroringProfileWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPortMirroringProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient.GetPortMirroringAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portMirroringId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/portMirroringProfiles/{portMirroringId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetPortMirroring</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portMirroringId"> NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portMirroringId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portMirroringId"/> is null. </exception>
        public virtual Response<bool> Exists(string portMirroringId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portMirroringId, nameof(portMirroringId));

            using var scope = _workloadNetworkPortMirroringProfileWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPortMirroringProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = _workloadNetworkPortMirroringProfileWorkloadNetworksRestClient.GetPortMirroring(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portMirroringId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkloadNetworkPortMirroringProfileResource> IEnumerable<WorkloadNetworkPortMirroringProfileResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadNetworkPortMirroringProfileResource> IAsyncEnumerable<WorkloadNetworkPortMirroringProfileResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
