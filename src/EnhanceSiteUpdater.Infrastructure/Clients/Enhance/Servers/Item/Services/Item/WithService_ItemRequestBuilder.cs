// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Servers.Item.Services.Item.Status;
using Enhance.Client.Servers.Item.Services.Item.Update;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.Servers.Item.Services.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \servers\{server_id}\services\{service_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithService_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The status property</summary>
        public global::Enhance.Client.Servers.Item.Services.Item.Status.StatusRequestBuilder Status
        {
            get => new global::Enhance.Client.Servers.Item.Services.Item.Status.StatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The update property</summary>
        public global::Enhance.Client.Servers.Item.Services.Item.Update.UpdateRequestBuilder Update
        {
            get => new global::Enhance.Client.Servers.Item.Services.Item.Update.UpdateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Services.Item.WithService_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithService_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/services/{service_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Servers.Item.Services.Item.WithService_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithService_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servers/{server_id}/services/{service_id}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
