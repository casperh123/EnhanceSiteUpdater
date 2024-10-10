// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.V2.Settings.Backup;
using Enhance.Client.V2.Settings.Demo_mode;
using Enhance.Client.V2.Settings.Dns;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.V2.Settings
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\settings
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class SettingsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The backup property</summary>
        public global::Enhance.Client.V2.Settings.Backup.BackupRequestBuilder Backup
        {
            get => new global::Enhance.Client.V2.Settings.Backup.BackupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The demo_mode property</summary>
        public global::Enhance.Client.V2.Settings.Demo_mode.Demo_modeRequestBuilder Demo_mode
        {
            get => new global::Enhance.Client.V2.Settings.Demo_mode.Demo_modeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dns property</summary>
        public global::Enhance.Client.V2.Settings.Dns.DnsRequestBuilder Dns
        {
            get => new global::Enhance.Client.V2.Settings.Dns.DnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.V2.Settings.SettingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SettingsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/settings", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.V2.Settings.SettingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SettingsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/settings", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
