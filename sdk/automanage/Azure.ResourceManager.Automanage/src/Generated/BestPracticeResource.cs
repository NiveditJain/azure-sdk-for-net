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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A Class representing a BestPractice along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="BestPracticeResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetBestPracticeResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetBestPractice method.
    /// </summary>
    public partial class BestPracticeResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BestPracticeResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string bestPracticeName)
        {
            var resourceId = $"/providers/Microsoft.Automanage/bestPractices/{bestPracticeName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _bestPracticeClientDiagnostics;
        private readonly BestPracticesRestOperations _bestPracticeRestClient;
        private readonly BestPracticeData _data;

        /// <summary> Initializes a new instance of the <see cref="BestPracticeResource"/> class for mocking. </summary>
        protected BestPracticeResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BestPracticeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BestPracticeResource(ArmClient client, BestPracticeData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BestPracticeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BestPracticeResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _bestPracticeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string bestPracticeApiVersion);
            _bestPracticeRestClient = new BestPracticesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, bestPracticeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Automanage/bestPractices";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BestPracticeData Data
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
        /// Get information about a Automanage best practice
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Automanage/bestPractices/{bestPracticeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BestPractices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BestPracticeResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _bestPracticeClientDiagnostics.CreateScope("BestPracticeResource.Get");
            scope.Start();
            try
            {
                var response = await _bestPracticeRestClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BestPracticeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a Automanage best practice
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Automanage/bestPractices/{bestPracticeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BestPractices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BestPracticeResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _bestPracticeClientDiagnostics.CreateScope("BestPracticeResource.Get");
            scope.Start();
            try
            {
                var response = _bestPracticeRestClient.Get(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BestPracticeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
