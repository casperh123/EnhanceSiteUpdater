// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Orgs.Item.Websites.Item.Apps.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org_id}\websites\{website_id}\apps\{app_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithApp_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The wordpress property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.WordpressRequestBuilder Wordpress
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.Wordpress.WordpressRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.WithApp_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithApp_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/websites/{website_id}/apps/{app_id}{?backupBeforeOperation*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.WithApp_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithApp_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/websites/{website_id}/apps/{app_id}{?backupBeforeOperation*}", rawUrl)
        {
        }
        /// <summary>
        /// Deletes an existing website app. Unless `backupBeforeOperation=false` query param is sent, it runs a website backup before deleting the app.Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.WithApp_ItemRequestBuilder.WithApp_ItemRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.WithApp_ItemRequestBuilder.WithApp_ItemRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes an existing website app. Unless `backupBeforeOperation=false` query param is sent, it runs a website backup before deleting the app.Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.WithApp_ItemRequestBuilder.WithApp_ItemRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.WithApp_ItemRequestBuilder.WithApp_ItemRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.WithApp_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.WithApp_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.WithApp_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Deletes an existing website app. Unless `backupBeforeOperation=false` query param is sent, it runs a website backup before deleting the app.Session holder must be at least a `SuperAdmin` in this org or a parent org, or be a member in this org that has access to the website.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithApp_ItemRequestBuilderDeleteQueryParameters 
        {
            /// <summary>Whether a backup should be ran before the endpoint operation is executed.</summary>
            [QueryParameter("backupBeforeOperation")]
            public bool? BackupBeforeOperation { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithApp_ItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.Apps.Item.WithApp_ItemRequestBuilder.WithApp_ItemRequestBuilderDeleteQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
