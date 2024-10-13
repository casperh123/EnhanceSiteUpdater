// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Servers.Item.Appcd.Screenshot.Config;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.Servers.Item.Appcd.Screenshot
{
    /// <summary>
    /// Builds and executes requests for operations under \servers\{server_id}\appcd\screenshot
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ScreenshotRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The config property</summary>
        public global::Enhance.Client.Servers.Item.Appcd.Screenshot.Config.ConfigRequestBuilder Config
        {
            get => new global::Enhance.Client.Servers.Item.Appcd.Screenshot.Config.ConfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Appcd.Screenshot.ScreenshotRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScreenshotRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/appcd/screenshot", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Appcd.Screenshot.ScreenshotRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScreenshotRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/appcd/screenshot", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
