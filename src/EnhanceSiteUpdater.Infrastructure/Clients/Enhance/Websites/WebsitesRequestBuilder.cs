// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Websites.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.Websites
{
    /// <summary>
    /// Builds and executes requests for operations under \websites
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WebsitesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Enhance.Client.websites.item collection</summary>
        /// <param name="position">The id of the website.</param>
        /// <returns>A <see cref="global::Enhance.Client.Websites.Item.WithWebsite_ItemRequestBuilder"/></returns>
        public global::Enhance.Client.Websites.Item.WithWebsite_ItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("website_id", position);
                return new global::Enhance.Client.Websites.Item.WithWebsite_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Enhance.Client.websites.item collection</summary>
        /// <param name="position">The id of the website.</param>
        /// <returns>A <see cref="global::Enhance.Client.Websites.Item.WithWebsite_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Enhance.Client.Websites.Item.WithWebsite_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("website_id", position);
                return new global::Enhance.Client.Websites.Item.WithWebsite_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Websites.WebsitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WebsitesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/websites", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Websites.WebsitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WebsitesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/websites", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
