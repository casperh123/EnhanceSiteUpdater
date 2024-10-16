// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.Activate;
using Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.Auto_update;
using Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.Update;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org_id}\websites\{website_id}\apps\{app_id}\wordpress\themes\{theme}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithThemeItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The activate property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.Activate.ActivateRequestBuilder Activate
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.Activate.ActivateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The auto_update property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.Auto_update.Auto_updateRequestBuilder Auto_update
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.Auto_update.Auto_updateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The update property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.Update.UpdateRequestBuilder Update
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.Update.UpdateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.WithThemeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithThemeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/websites/{website_id}/apps/{app_id}/wordpress/themes/{theme}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.WithThemeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithThemeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/websites/{website_id}/apps/{app_id}/wordpress/themes/{theme}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a WordPress theme
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a WordPress theme
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.WithThemeItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.WithThemeItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.Themes.Item.WithThemeItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithThemeItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
