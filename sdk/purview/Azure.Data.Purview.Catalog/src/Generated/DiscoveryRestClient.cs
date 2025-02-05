// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

#pragma warning disable AZC0007

namespace Azure.Data.Purview.Catalog
{
    /// <summary> The DiscoveryRest service client. </summary>
    public partial class DiscoveryRestClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://purview.azure.net/.default" };
        private Uri endpoint;
        private readonly string apiVersion;

        /// <summary> Initializes a new instance of DiscoveryRestClient for mocking. </summary>
        protected DiscoveryRestClient()
        {
        }

        /// <summary> Initializes a new instance of DiscoveryRestClient. </summary>
        /// <param name="endpoint"> The catalog endpoint of your Purview account. Example: https://{accountName}.catalog.purview.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public DiscoveryRestClient(Uri endpoint, TokenCredential credential, CatalogClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new CatalogClientOptions();
            Pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, AuthorizationScopes));
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Gets data using search. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> SearchAdvancedAsync(RequestContent requestBody, CancellationToken cancellationToken = default)
        {
            Request req = CreateSearchAdvancedRequest(requestBody);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets data using search. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response SearchAdvanced(RequestContent requestBody, CancellationToken cancellationToken = default)
        {
            Request req = CreateSearchAdvancedRequest(requestBody);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="SearchAdvanced"/> and <see cref="SearchAdvancedAsync"/> operations. </summary>
        /// <param name="requestBody"> The request body. </param>
        private Request CreateSearchAdvancedRequest(RequestContent requestBody)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/search/query", false);
            if (apiVersion != null)
            {
                uri.AppendQuery("api-version", apiVersion, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = requestBody;
            return request;
        }

        /// <summary> Get search suggestions by query criteria. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> SuggestAsync(RequestContent requestBody, CancellationToken cancellationToken = default)
        {
            Request req = CreateSuggestRequest(requestBody);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Get search suggestions by query criteria. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Suggest(RequestContent requestBody, CancellationToken cancellationToken = default)
        {
            Request req = CreateSuggestRequest(requestBody);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="Suggest"/> and <see cref="SuggestAsync"/> operations. </summary>
        /// <param name="requestBody"> The request body. </param>
        private Request CreateSuggestRequest(RequestContent requestBody)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/search/suggest", false);
            if (apiVersion != null)
            {
                uri.AppendQuery("api-version", apiVersion, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = requestBody;
            return request;
        }

        /// <summary> Get auto complete options. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AutoCompleteAsync(RequestContent requestBody, CancellationToken cancellationToken = default)
        {
            Request req = CreateAutoCompleteRequest(requestBody);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Get auto complete options. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AutoComplete(RequestContent requestBody, CancellationToken cancellationToken = default)
        {
            Request req = CreateAutoCompleteRequest(requestBody);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="AutoComplete"/> and <see cref="AutoCompleteAsync"/> operations. </summary>
        /// <param name="requestBody"> The request body. </param>
        private Request CreateAutoCompleteRequest(RequestContent requestBody)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/search/autocomplete", false);
            if (apiVersion != null)
            {
                uri.AppendQuery("api-version", apiVersion, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = requestBody;
            return request;
        }
    }
}
