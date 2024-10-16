// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Orgs.Item.Import.Server.Item.Account;
using Enhance.Client.Orgs.Item.Import.Server.Item.CachedDomains;
using Enhance.Client.Orgs.Item.Import.Server.Item.PullDomains;
using Enhance.Client.Orgs.Item.Import.Server.Item.Settings;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.Orgs.Item.Import.Server.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org_id}\import\server\{server_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithServer_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The account property</summary>
        public global::Enhance.Client.Orgs.Item.Import.Server.Item.Account.AccountRequestBuilder Account
        {
            get => new global::Enhance.Client.Orgs.Item.Import.Server.Item.Account.AccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cachedDomains property</summary>
        public global::Enhance.Client.Orgs.Item.Import.Server.Item.CachedDomains.CachedDomainsRequestBuilder CachedDomains
        {
            get => new global::Enhance.Client.Orgs.Item.Import.Server.Item.CachedDomains.CachedDomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pullDomains property</summary>
        public global::Enhance.Client.Orgs.Item.Import.Server.Item.PullDomains.PullDomainsRequestBuilder PullDomains
        {
            get => new global::Enhance.Client.Orgs.Item.Import.Server.Item.PullDomains.PullDomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public global::Enhance.Client.Orgs.Item.Import.Server.Item.Settings.SettingsRequestBuilder Settings
        {
            get => new global::Enhance.Client.Orgs.Item.Import.Server.Item.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Import.Server.Item.WithServer_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithServer_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/import/server/{server_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Import.Server.Item.WithServer_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithServer_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/import/server/{server_id}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
