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

namespace Azure.ResourceManager.Relay
{
    /// <summary>
    /// A class representing a collection of <see cref="RelayHybridConnectionResource" /> and their operations.
    /// Each <see cref="RelayHybridConnectionResource" /> in the collection will belong to the same instance of <see cref="RelayNamespaceResource" />.
    /// To get a <see cref="RelayHybridConnectionCollection" /> instance call the GetRelayHybridConnections method from an instance of <see cref="RelayNamespaceResource" />.
    /// </summary>
    public partial class RelayHybridConnectionCollection : ArmCollection, IEnumerable<RelayHybridConnectionResource>, IAsyncEnumerable<RelayHybridConnectionResource>
    {
        private readonly ClientDiagnostics _relayHybridConnectionHybridConnectionsClientDiagnostics;
        private readonly HybridConnectionsRestOperations _relayHybridConnectionHybridConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RelayHybridConnectionCollection"/> class for mocking. </summary>
        protected RelayHybridConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RelayHybridConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RelayHybridConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _relayHybridConnectionHybridConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Relay", RelayHybridConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RelayHybridConnectionResource.ResourceType, out string relayHybridConnectionHybridConnectionsApiVersion);
            _relayHybridConnectionHybridConnectionsRestClient = new HybridConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, relayHybridConnectionHybridConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RelayNamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RelayNamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a service hybrid connection. This operation is idempotent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hybridConnectionName"> The hybrid connection name. </param>
        /// <param name="data"> Parameters supplied to create a hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RelayHybridConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string hybridConnectionName, RelayHybridConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridConnectionName, nameof(hybridConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _relayHybridConnectionHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _relayHybridConnectionHybridConnectionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RelayArmOperation<RelayHybridConnectionResource>(Response.FromValue(new RelayHybridConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a service hybrid connection. This operation is idempotent.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hybridConnectionName"> The hybrid connection name. </param>
        /// <param name="data"> Parameters supplied to create a hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RelayHybridConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string hybridConnectionName, RelayHybridConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridConnectionName, nameof(hybridConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _relayHybridConnectionHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _relayHybridConnectionHybridConnectionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridConnectionName, data, cancellationToken);
                var operation = new RelayArmOperation<RelayHybridConnectionResource>(Response.FromValue(new RelayHybridConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Returns the description for the specified hybrid connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridConnectionName"> The hybrid connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridConnectionName"/> is null. </exception>
        public virtual async Task<Response<RelayHybridConnectionResource>> GetAsync(string hybridConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridConnectionName, nameof(hybridConnectionName));

            using var scope = _relayHybridConnectionHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _relayHybridConnectionHybridConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RelayHybridConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the description for the specified hybrid connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridConnectionName"> The hybrid connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridConnectionName"/> is null. </exception>
        public virtual Response<RelayHybridConnectionResource> Get(string hybridConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridConnectionName, nameof(hybridConnectionName));

            using var scope = _relayHybridConnectionHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _relayHybridConnectionHybridConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RelayHybridConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the hybrid connection within the namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RelayHybridConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RelayHybridConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _relayHybridConnectionHybridConnectionsRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _relayHybridConnectionHybridConnectionsRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RelayHybridConnectionResource(Client, RelayHybridConnectionData.DeserializeRelayHybridConnectionData(e)), _relayHybridConnectionHybridConnectionsClientDiagnostics, Pipeline, "RelayHybridConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the hybrid connection within the namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RelayHybridConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RelayHybridConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _relayHybridConnectionHybridConnectionsRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _relayHybridConnectionHybridConnectionsRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RelayHybridConnectionResource(Client, RelayHybridConnectionData.DeserializeRelayHybridConnectionData(e)), _relayHybridConnectionHybridConnectionsClientDiagnostics, Pipeline, "RelayHybridConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridConnectionName"> The hybrid connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string hybridConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridConnectionName, nameof(hybridConnectionName));

            using var scope = _relayHybridConnectionHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _relayHybridConnectionHybridConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridConnectionName"> The hybrid connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string hybridConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridConnectionName, nameof(hybridConnectionName));

            using var scope = _relayHybridConnectionHybridConnectionsClientDiagnostics.CreateScope("RelayHybridConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _relayHybridConnectionHybridConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hybridConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RelayHybridConnectionResource> IEnumerable<RelayHybridConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RelayHybridConnectionResource> IAsyncEnumerable<RelayHybridConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
