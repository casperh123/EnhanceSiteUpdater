// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.V2.Apps.Item.Wordpress;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.V2.Apps.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\apps\{app_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithApp_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The wordpress property</summary>
        public global::Enhance.Client.V2.Apps.Item.Wordpress.WordpressRequestBuilder Wordpress
        {
            get => new global::Enhance.Client.V2.Apps.Item.Wordpress.WordpressRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.V2.Apps.Item.WithApp_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithApp_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/apps/{app_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.V2.Apps.Item.WithApp_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithApp_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/apps/{app_id}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
