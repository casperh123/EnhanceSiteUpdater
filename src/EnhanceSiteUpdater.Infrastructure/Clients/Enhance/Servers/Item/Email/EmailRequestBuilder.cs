// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Servers.Item.Email.Hostname_override;
using Enhance.Client.Servers.Item.Email.Spam;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.Servers.Item.Email
{
    /// <summary>
    /// Builds and executes requests for operations under \servers\{server_id}\email
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class EmailRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The hostname_override property</summary>
        public global::Enhance.Client.Servers.Item.Email.Hostname_override.Hostname_overrideRequestBuilder Hostname_override
        {
            get => new global::Enhance.Client.Servers.Item.Email.Hostname_override.Hostname_overrideRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The spam property</summary>
        public global::Enhance.Client.Servers.Item.Email.Spam.SpamRequestBuilder Spam
        {
            get => new global::Enhance.Client.Servers.Item.Email.Spam.SpamRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Email.EmailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/email", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Email.EmailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/email", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
