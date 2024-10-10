// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Emails.Item.Spam_thresholds;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.Emails.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \emails\{email_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class WithEmail_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The spam_thresholds property</summary>
        public global::Enhance.Client.Emails.Item.Spam_thresholds.Spam_thresholdsRequestBuilder Spam_thresholds
        {
            get => new global::Enhance.Client.Emails.Item.Spam_thresholds.Spam_thresholdsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Emails.Item.WithEmail_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEmail_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/emails/{email_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Emails.Item.WithEmail_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEmail_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/emails/{email_id}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
