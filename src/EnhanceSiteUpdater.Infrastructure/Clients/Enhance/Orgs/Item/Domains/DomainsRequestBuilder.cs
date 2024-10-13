// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Models;
using Enhance.Client.Orgs.Item.Domains.Check;
using Enhance.Client.Orgs.Item.Domains.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Orgs.Item.Domains
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org_id}\domains
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DomainsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The check property</summary>
        public global::Enhance.Client.Orgs.Item.Domains.Check.CheckRequestBuilder Check
        {
            get => new global::Enhance.Client.Orgs.Item.Domains.Check.CheckRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Enhance.Client.orgs.item.domains.item collection</summary>
        /// <param name="position">The id of the domain.</param>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Domains.Item.WithDomain_ItemRequestBuilder"/></returns>
        public global::Enhance.Client.Orgs.Item.Domains.Item.WithDomain_ItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("domain_id", position);
                return new global::Enhance.Client.Orgs.Item.Domains.Item.WithDomain_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Enhance.Client.orgs.item.domains.item collection</summary>
        /// <param name="position">The id of the domain.</param>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Domains.Item.WithDomain_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Enhance.Client.Orgs.Item.Domains.Item.WithDomain_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("domain_id", position);
                return new global::Enhance.Client.Orgs.Item.Domains.Item.WithDomain_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Domains.DomainsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DomainsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/domains{?limit*,offset*,sortBy*,sortOrder*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Domains.DomainsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DomainsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/domains{?limit*,offset*,sortBy*,sortOrder*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists the domains belonging to this organization.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.DomainsListing"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.DomainsListing?> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Domains.DomainsRequestBuilder.DomainsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.DomainsListing> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Domains.DomainsRequestBuilder.DomainsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.DomainsListing>(requestInfo, global::Enhance.Client.Models.DomainsListing.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The MO may create domains without a subscription but all other customers need to pass with this request an id of one of their subscriptions to a plan that allows creating domain names.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.NewResourceUuid"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.NewResourceUuid?> PostAsync(global::Enhance.Client.Models.NewDomain body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.NewResourceUuid> PostAsync(global::Enhance.Client.Models.NewDomain body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.NewResourceUuid>(requestInfo, global::Enhance.Client.Models.NewResourceUuid.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the domains belonging to this organization.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Domains.DomainsRequestBuilder.DomainsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Domains.DomainsRequestBuilder.DomainsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The MO may create domains without a subscription but all other customers need to pass with this request an id of one of their subscriptions to a plan that allows creating domain names.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Enhance.Client.Models.NewDomain body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Enhance.Client.Models.NewDomain body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Domains.DomainsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Orgs.Item.Domains.DomainsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Orgs.Item.Domains.DomainsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the domains belonging to this organization.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DomainsRequestBuilderGetQueryParameters 
        {
            /// <summary>The maximum number of items to return.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>The offset from which to return items.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>The field by which to sort.</summary>
            [Obsolete("This property is deprecated, use SortByAsGetSortByQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortBy")]
            public string? SortBy { get; set; }
#nullable restore
#else
            [QueryParameter("sortBy")]
            public string SortBy { get; set; }
#endif
            /// <summary>The field by which to sort.</summary>
            [QueryParameter("sortBy")]
            public global::Enhance.Client.Orgs.Item.Domains.GetSortByQueryParameterType? SortByAsGetSortByQueryParameterType { get; set; }
            /// <summary>The direction in which to sort. Possible values are &apos;asc&apos; and &apos;desc&apos;, defaulting to &apos;asc&apos;.</summary>
            [Obsolete("This property is deprecated, use SortOrderAsGetSortOrderQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortOrder")]
            public string? SortOrder { get; set; }
#nullable restore
#else
            [QueryParameter("sortOrder")]
            public string SortOrder { get; set; }
#endif
            /// <summary>The direction in which to sort. Possible values are &apos;asc&apos; and &apos;desc&apos;, defaulting to &apos;asc&apos;.</summary>
            [QueryParameter("sortOrder")]
            public global::Enhance.Client.Orgs.Item.Domains.GetSortOrderQueryParameterType? SortOrderAsGetSortOrderQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DomainsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Enhance.Client.Orgs.Item.Domains.DomainsRequestBuilder.DomainsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DomainsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
