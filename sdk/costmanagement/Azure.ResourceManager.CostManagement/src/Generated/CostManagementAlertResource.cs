// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.CostManagement.Models;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// A Class representing a CostManagementAlert along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CostManagementAlertResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCostManagementAlertResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetCostManagementAlert method.
    /// </summary>
    public partial class CostManagementAlertResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CostManagementAlertResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string alertId)
        {
            var resourceId = $"{scope}/providers/Microsoft.CostManagement/alerts/{alertId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _costManagementAlertAlertsClientDiagnostics;
        private readonly AlertsRestOperations _costManagementAlertAlertsRestClient;
        private readonly CostManagementAlertData _data;

        /// <summary> Initializes a new instance of the <see cref="CostManagementAlertResource"/> class for mocking. </summary>
        protected CostManagementAlertResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CostManagementAlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CostManagementAlertResource(ArmClient client, CostManagementAlertData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CostManagementAlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CostManagementAlertResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _costManagementAlertAlertsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CostManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string costManagementAlertAlertsApiVersion);
            _costManagementAlertAlertsRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, costManagementAlertAlertsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.CostManagement/alerts";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CostManagementAlertData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the alert for the scope by alert ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CostManagementAlertResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _costManagementAlertAlertsClientDiagnostics.CreateScope("CostManagementAlertResource.Get");
            scope.Start();
            try
            {
                var response = await _costManagementAlertAlertsRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CostManagementAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the alert for the scope by alert ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CostManagementAlertResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _costManagementAlertAlertsClientDiagnostics.CreateScope("CostManagementAlertResource.Get");
            scope.Start();
            try
            {
                var response = _costManagementAlertAlertsRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CostManagementAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Dismisses the specified alert
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_Dismiss</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Parameters supplied to the Dismiss Alert operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<CostManagementAlertResource>> UpdateAsync(CostManagementAlertPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _costManagementAlertAlertsClientDiagnostics.CreateScope("CostManagementAlertResource.Update");
            scope.Start();
            try
            {
                var response = await _costManagementAlertAlertsRestClient.DismissAsync(Id.Parent, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CostManagementAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Dismisses the specified alert
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/alerts/{alertId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_Dismiss</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Parameters supplied to the Dismiss Alert operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<CostManagementAlertResource> Update(CostManagementAlertPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _costManagementAlertAlertsClientDiagnostics.CreateScope("CostManagementAlertResource.Update");
            scope.Start();
            try
            {
                var response = _costManagementAlertAlertsRestClient.Dismiss(Id.Parent, Id.Name, patch, cancellationToken);
                return Response.FromValue(new CostManagementAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
