// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Dns.ThirdPartyProviders.Item;
using Enhance.Client.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Dns.ThirdPartyProviders
{
    /// <summary>
    /// Builds and executes requests for operations under \dns\third-party-providers
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ThirdPartyProvidersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Enhance.Client.dns.thirdPartyProviders.item collection</summary>
        /// <param name="position">The id of the third party provider which can be obtained by querying the GET /dns/third-party-providers endpoint.</param>
        /// <returns>A <see cref="global::Enhance.Client.Dns.ThirdPartyProviders.Item.WithProvider_ItemRequestBuilder"/></returns>
        public global::Enhance.Client.Dns.ThirdPartyProviders.Item.WithProvider_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("provider_id", position);
                return new global::Enhance.Client.Dns.ThirdPartyProviders.Item.WithProvider_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Enhance.Client.dns.thirdPartyProviders.item collection</summary>
        /// <param name="position">The id of the third party provider which can be obtained by querying the GET /dns/third-party-providers endpoint.</param>
        /// <returns>A <see cref="global::Enhance.Client.Dns.ThirdPartyProviders.Item.WithProvider_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Enhance.Client.Dns.ThirdPartyProviders.Item.WithProvider_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("provider_id", position);
                return new global::Enhance.Client.Dns.ThirdPartyProviders.Item.WithProvider_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Dns.ThirdPartyProviders.ThirdPartyProvidersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThirdPartyProvidersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/dns/third-party-providers", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Dns.ThirdPartyProviders.ThirdPartyProvidersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThirdPartyProvidersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/dns/third-party-providers", rawUrl)
        {
        }
        /// <summary>
        /// This operation can only be done by an MO admin.Third party providers are notified about changes to dns zones within Enhance. This endpoint lists all registered URLs which listen to these changes.
        /// </summary>
        /// <returns>A List&lt;global::Enhance.Client.Models.DnsThirdPartyProvider&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Enhance.Client.Models.DnsThirdPartyProvider>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Enhance.Client.Models.DnsThirdPartyProvider>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Enhance.Client.Models.DnsThirdPartyProvider>(requestInfo, global::Enhance.Client.Models.DnsThirdPartyProvider.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// This operation can only be done by an MO admin.Third party providers are notified about changes to dns zones within Enhance. This endpoint creates a new provider which is going to be notified on provided URL about dns updates.Please not that after adding a new provider using this endpoint, the provider will initially receive a request to delete all its current data and then Enhance will send a request with all existing dns zones.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PostAsync(global::Enhance.Client.Models.NewDnsThirdPartyProvider body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> PostAsync(global::Enhance.Client.Models.NewDnsThirdPartyProvider body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This operation can only be done by an MO admin.Third party providers are notified about changes to dns zones within Enhance. This endpoint lists all registered URLs which listen to these changes.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// This operation can only be done by an MO admin.Third party providers are notified about changes to dns zones within Enhance. This endpoint creates a new provider which is going to be notified on provided URL about dns updates.Please not that after adding a new provider using this endpoint, the provider will initially receive a request to delete all its current data and then Enhance will send a request with all existing dns zones.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Enhance.Client.Models.NewDnsThirdPartyProvider body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Enhance.Client.Models.NewDnsThirdPartyProvider body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Dns.ThirdPartyProviders.ThirdPartyProvidersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Dns.ThirdPartyProviders.ThirdPartyProvidersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Dns.ThirdPartyProviders.ThirdPartyProvidersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ThirdPartyProvidersRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ThirdPartyProvidersRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
