// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Servers.Item.Spam.Ip_whitelist;
using Enhance.Client.Servers.Item.Spam.Smtp_rate_limit_hourly;
using Enhance.Client.Servers.Item.Spam.Website_generated_rate_limit_hourly;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.Servers.Item.Spam
{
    /// <summary>
    /// Builds and executes requests for operations under \servers\{server_id}\spam
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SpamRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The ip_whitelist property</summary>
        public global::Enhance.Client.Servers.Item.Spam.Ip_whitelist.Ip_whitelistRequestBuilder Ip_whitelist
        {
            get => new global::Enhance.Client.Servers.Item.Spam.Ip_whitelist.Ip_whitelistRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The smtp_rate_limit_hourly property</summary>
        public global::Enhance.Client.Servers.Item.Spam.Smtp_rate_limit_hourly.Smtp_rate_limit_hourlyRequestBuilder Smtp_rate_limit_hourly
        {
            get => new global::Enhance.Client.Servers.Item.Spam.Smtp_rate_limit_hourly.Smtp_rate_limit_hourlyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The website_generated_rate_limit_hourly property</summary>
        public global::Enhance.Client.Servers.Item.Spam.Website_generated_rate_limit_hourly.Website_generated_rate_limit_hourlyRequestBuilder Website_generated_rate_limit_hourly
        {
            get => new global::Enhance.Client.Servers.Item.Spam.Website_generated_rate_limit_hourly.Website_generated_rate_limit_hourlyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Spam.SpamRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SpamRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/spam", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Spam.SpamRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SpamRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/spam", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
