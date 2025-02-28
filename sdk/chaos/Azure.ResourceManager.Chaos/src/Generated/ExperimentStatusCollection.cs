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

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A class representing a collection of <see cref="ExperimentStatusResource" /> and their operations.
    /// Each <see cref="ExperimentStatusResource" /> in the collection will belong to the same instance of <see cref="ExperimentResource" />.
    /// To get an <see cref="ExperimentStatusCollection" /> instance call the GetExperimentStatuses method from an instance of <see cref="ExperimentResource" />.
    /// </summary>
    public partial class ExperimentStatusCollection : ArmCollection, IEnumerable<ExperimentStatusResource>, IAsyncEnumerable<ExperimentStatusResource>
    {
        private readonly ClientDiagnostics _experimentStatusExperimentsClientDiagnostics;
        private readonly ExperimentsRestOperations _experimentStatusExperimentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExperimentStatusCollection"/> class for mocking. </summary>
        protected ExperimentStatusCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExperimentStatusCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExperimentStatusCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _experimentStatusExperimentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Chaos", ExperimentStatusResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExperimentStatusResource.ResourceType, out string experimentStatusExperimentsApiVersion);
            _experimentStatusExperimentsRestClient = new ExperimentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, experimentStatusExperimentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExperimentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExperimentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a status of a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/statuses/{statusId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_GetStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="statusId"> GUID that represents a Experiment status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="statusId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="statusId"/> is null. </exception>
        public virtual async Task<Response<ExperimentStatusResource>> GetAsync(string statusId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(statusId, nameof(statusId));

            using var scope = _experimentStatusExperimentsClientDiagnostics.CreateScope("ExperimentStatusCollection.Get");
            scope.Start();
            try
            {
                var response = await _experimentStatusExperimentsRestClient.GetStatusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, statusId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExperimentStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a status of a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/statuses/{statusId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_GetStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="statusId"> GUID that represents a Experiment status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="statusId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="statusId"/> is null. </exception>
        public virtual Response<ExperimentStatusResource> Get(string statusId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(statusId, nameof(statusId));

            using var scope = _experimentStatusExperimentsClientDiagnostics.CreateScope("ExperimentStatusCollection.Get");
            scope.Start();
            try
            {
                var response = _experimentStatusExperimentsRestClient.GetStatus(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, statusId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExperimentStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of statuses of a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/statuses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_ListAllStatuses</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExperimentStatusResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExperimentStatusResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _experimentStatusExperimentsRestClient.CreateListAllStatusesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _experimentStatusExperimentsRestClient.CreateListAllStatusesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExperimentStatusResource(Client, ExperimentStatusData.DeserializeExperimentStatusData(e)), _experimentStatusExperimentsClientDiagnostics, Pipeline, "ExperimentStatusCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of statuses of a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/statuses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_ListAllStatuses</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExperimentStatusResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExperimentStatusResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _experimentStatusExperimentsRestClient.CreateListAllStatusesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _experimentStatusExperimentsRestClient.CreateListAllStatusesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExperimentStatusResource(Client, ExperimentStatusData.DeserializeExperimentStatusData(e)), _experimentStatusExperimentsClientDiagnostics, Pipeline, "ExperimentStatusCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/statuses/{statusId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_GetStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="statusId"> GUID that represents a Experiment status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="statusId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="statusId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string statusId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(statusId, nameof(statusId));

            using var scope = _experimentStatusExperimentsClientDiagnostics.CreateScope("ExperimentStatusCollection.Exists");
            scope.Start();
            try
            {
                var response = await _experimentStatusExperimentsRestClient.GetStatusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, statusId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/statuses/{statusId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_GetStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="statusId"> GUID that represents a Experiment status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="statusId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="statusId"/> is null. </exception>
        public virtual Response<bool> Exists(string statusId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(statusId, nameof(statusId));

            using var scope = _experimentStatusExperimentsClientDiagnostics.CreateScope("ExperimentStatusCollection.Exists");
            scope.Start();
            try
            {
                var response = _experimentStatusExperimentsRestClient.GetStatus(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, statusId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExperimentStatusResource> IEnumerable<ExperimentStatusResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExperimentStatusResource> IAsyncEnumerable<ExperimentStatusResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
