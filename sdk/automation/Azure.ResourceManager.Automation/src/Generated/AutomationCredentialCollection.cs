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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomationCredentialResource" /> and their operations.
    /// Each <see cref="AutomationCredentialResource" /> in the collection will belong to the same instance of <see cref="AutomationAccountResource" />.
    /// To get an <see cref="AutomationCredentialCollection" /> instance call the GetAutomationCredentials method from an instance of <see cref="AutomationAccountResource" />.
    /// </summary>
    public partial class AutomationCredentialCollection : ArmCollection, IEnumerable<AutomationCredentialResource>, IAsyncEnumerable<AutomationCredentialResource>
    {
        private readonly ClientDiagnostics _automationCredentialCredentialClientDiagnostics;
        private readonly CredentialRestOperations _automationCredentialCredentialRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationCredentialCollection"/> class for mocking. </summary>
        protected AutomationCredentialCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationCredentialCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationCredentialCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationCredentialCredentialClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationCredentialResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationCredentialResource.ResourceType, out string automationCredentialCredentialApiVersion);
            _automationCredentialCredentialRestClient = new CredentialRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationCredentialCredentialApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Credential_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="credentialName"> The parameters supplied to the create or update credential operation. </param>
        /// <param name="content"> The parameters supplied to the create or update credential operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationCredentialResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string credentialName, AutomationCredentialCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationCredentialCredentialClientDiagnostics.CreateScope("AutomationCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationCredentialCredentialRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationCredentialResource>(Response.FromValue(new AutomationCredentialResource(Client, response), response.GetRawResponse()));
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
        /// Create a credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Credential_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="credentialName"> The parameters supplied to the create or update credential operation. </param>
        /// <param name="content"> The parameters supplied to the create or update credential operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationCredentialResource> CreateOrUpdate(WaitUntil waitUntil, string credentialName, AutomationCredentialCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationCredentialCredentialClientDiagnostics.CreateScope("AutomationCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationCredentialCredentialRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, content, cancellationToken);
                var operation = new AutomationArmOperation<AutomationCredentialResource>(Response.FromValue(new AutomationCredentialResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the credential identified by credential name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Credential_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> The name of credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual async Task<Response<AutomationCredentialResource>> GetAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _automationCredentialCredentialClientDiagnostics.CreateScope("AutomationCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationCredentialCredentialRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the credential identified by credential name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Credential_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> The name of credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<AutomationCredentialResource> Get(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _automationCredentialCredentialClientDiagnostics.CreateScope("AutomationCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = _automationCredentialCredentialRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of credentials.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/credentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Credential_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationCredentialResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationCredentialResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationCredentialCredentialRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationCredentialCredentialRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AutomationCredentialResource(Client, AutomationCredentialData.DeserializeAutomationCredentialData(e)), _automationCredentialCredentialClientDiagnostics, Pipeline, "AutomationCredentialCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of credentials.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/credentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Credential_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationCredentialResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationCredentialResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationCredentialCredentialRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationCredentialCredentialRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AutomationCredentialResource(Client, AutomationCredentialData.DeserializeAutomationCredentialData(e)), _automationCredentialCredentialClientDiagnostics, Pipeline, "AutomationCredentialCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Credential_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> The name of credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _automationCredentialCredentialClientDiagnostics.CreateScope("AutomationCredentialCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationCredentialCredentialRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Credential_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> The name of credential. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<bool> Exists(string credentialName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _automationCredentialCredentialClientDiagnostics.CreateScope("AutomationCredentialCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationCredentialCredentialRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationCredentialResource> IEnumerable<AutomationCredentialResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationCredentialResource> IAsyncEnumerable<AutomationCredentialResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
