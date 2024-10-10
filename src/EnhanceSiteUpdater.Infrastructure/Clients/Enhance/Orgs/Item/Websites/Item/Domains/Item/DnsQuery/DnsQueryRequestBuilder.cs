// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Orgs.Item.Websites.Item.Domains.Item.DnsQuery
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org_id}\websites\{website_id}\domains\{domain_id}\dns-query
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class DnsQueryRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Domains.Item.DnsQuery.DnsQueryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DnsQueryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/websites/{website_id}/domains/{domain_id}/dns-query{?resolveDepth*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Domains.Item.DnsQuery.DnsQueryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DnsQueryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/websites/{website_id}/domains/{domain_id}/dns-query{?resolveDepth*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns details about the dns servers of given domain.Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.DnsQueryOutcome"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.DnsQueryOutcome?> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.Domains.Item.DnsQuery.DnsQueryRequestBuilder.DnsQueryRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.DnsQueryOutcome> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.Domains.Item.DnsQuery.DnsQueryRequestBuilder.DnsQueryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.DnsQueryOutcome>(requestInfo, global::Enhance.Client.Models.DnsQueryOutcome.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns details about the dns servers of given domain.Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.Domains.Item.DnsQuery.DnsQueryRequestBuilder.DnsQueryRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.Domains.Item.DnsQuery.DnsQueryRequestBuilder.DnsQueryRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Domains.Item.DnsQuery.DnsQueryRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Domains.Item.DnsQuery.DnsQueryRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Orgs.Item.Websites.Item.Domains.Item.DnsQuery.DnsQueryRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns details about the dns servers of given domain.Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class DnsQueryRequestBuilderGetQueryParameters 
        {
            /// <summary>DNS query resolve depth, defaults to `short` if not provided. `short` -&gt; takes the shortest path to resolve domain IP. `detailed` -&gt; queries and returns output from all found Authoritative name servers. `queryAllTldNs` -&gt; queries and returns results from all TLD name servers (very expensive).</summary>
            [Obsolete("This property is deprecated, use ResolveDepthAsGetResolveDepthQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("resolveDepth")]
            public string? ResolveDepth { get; set; }
#nullable restore
#else
            [QueryParameter("resolveDepth")]
            public string ResolveDepth { get; set; }
#endif
            /// <summary>DNS query resolve depth, defaults to `short` if not provided. `short` -&gt; takes the shortest path to resolve domain IP. `detailed` -&gt; queries and returns output from all found Authoritative name servers. `queryAllTldNs` -&gt; queries and returns results from all TLD name servers (very expensive).</summary>
            [QueryParameter("resolveDepth")]
            public global::Enhance.Client.Orgs.Item.Websites.Item.Domains.Item.DnsQuery.GetResolveDepthQueryParameterType? ResolveDepthAsGetResolveDepthQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class DnsQueryRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.Domains.Item.DnsQuery.DnsQueryRequestBuilder.DnsQueryRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
