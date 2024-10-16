// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.V2.Servers.Item.DatabaseRole;
using Enhance.Client.V2.Servers.Item.Modsec_conf;
using Enhance.Client.V2.Servers.Item.Modsec_status;
using Enhance.Client.V2.Servers.Item.MyCnf;
using Enhance.Client.V2.Servers.Item.Owasp;
using Enhance.Client.V2.Servers.Item.PrimaryIpv6;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.V2.Servers.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\servers\{server_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithServer_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The databaseRole property</summary>
        public global::Enhance.Client.V2.Servers.Item.DatabaseRole.DatabaseRoleRequestBuilder DatabaseRole
        {
            get => new global::Enhance.Client.V2.Servers.Item.DatabaseRole.DatabaseRoleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The modsec_conf property</summary>
        public global::Enhance.Client.V2.Servers.Item.Modsec_conf.Modsec_confRequestBuilder Modsec_conf
        {
            get => new global::Enhance.Client.V2.Servers.Item.Modsec_conf.Modsec_confRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The modsec_status property</summary>
        public global::Enhance.Client.V2.Servers.Item.Modsec_status.Modsec_statusRequestBuilder Modsec_status
        {
            get => new global::Enhance.Client.V2.Servers.Item.Modsec_status.Modsec_statusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The myCnf property</summary>
        public global::Enhance.Client.V2.Servers.Item.MyCnf.MyCnfRequestBuilder MyCnf
        {
            get => new global::Enhance.Client.V2.Servers.Item.MyCnf.MyCnfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The owasp property</summary>
        public global::Enhance.Client.V2.Servers.Item.Owasp.OwaspRequestBuilder Owasp
        {
            get => new global::Enhance.Client.V2.Servers.Item.Owasp.OwaspRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The primaryIpv6 property</summary>
        public global::Enhance.Client.V2.Servers.Item.PrimaryIpv6.PrimaryIpv6RequestBuilder PrimaryIpv6
        {
            get => new global::Enhance.Client.V2.Servers.Item.PrimaryIpv6.PrimaryIpv6RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.V2.Servers.Item.WithServer_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithServer_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/servers/{server_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.V2.Servers.Item.WithServer_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithServer_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/servers/{server_id}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
