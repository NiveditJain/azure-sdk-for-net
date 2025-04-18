// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ElasticSan.Models;

namespace Azure.ResourceManager.ElasticSan
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _skusClientDiagnostics;
        private SkusRestOperations _skusRestClient;
        private ClientDiagnostics _elasticSanClientDiagnostics;
        private ElasticSansRestOperations _elasticSanRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SkusClientDiagnostics => _skusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ElasticSan", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SkusRestOperations SkusRestClient => _skusRestClient ??= new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ElasticSanClientDiagnostics => _elasticSanClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ElasticSan", ElasticSanResource.ResourceType.Namespace, Diagnostics);
        private ElasticSansRestOperations ElasticSanRestClient => _elasticSanRestClient ??= new ElasticSansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ElasticSanResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all the available Skus in the region and information related to them
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ElasticSan/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Specify $filter=&apos;location eq &lt;location&gt;&apos; to filter on location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticSanSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticSanSkuInformation> GetSkusAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId, filter);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, ElasticSanSkuInformation.DeserializeElasticSanSkuInformation, SkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the available Skus in the region and information related to them
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ElasticSan/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Specify $filter=&apos;location eq &lt;location&gt;&apos; to filter on location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticSanSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticSanSkuInformation> GetSkus(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId, filter);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, ElasticSanSkuInformation.DeserializeElasticSanSkuInformation, SkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets a list of ElasticSans in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ElasticSan/elasticSans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticSans_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticSanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticSanResource> GetElasticSansAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ElasticSanRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ElasticSanRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ElasticSanResource(Client, ElasticSanData.DeserializeElasticSanData(e)), ElasticSanClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetElasticSans", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of ElasticSans in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ElasticSan/elasticSans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticSans_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticSanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticSanResource> GetElasticSans(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ElasticSanRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ElasticSanRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ElasticSanResource(Client, ElasticSanData.DeserializeElasticSanData(e)), ElasticSanClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetElasticSans", "value", "nextLink", cancellationToken);
        }
    }
}
