// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Settings.Service.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Enhance.Client.Settings.Service
{
    /// <summary>
    /// Builds and executes requests for operations under \settings\service
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ServiceRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Enhance.Client.settings.service.item collection</summary>
        /// <param name="position">The type of setting being applied</param>
        /// <returns>A <see cref="global::Enhance.Client.Settings.Service.Item.WithSetting_kindItemRequestBuilder"/></returns>
        public global::Enhance.Client.Settings.Service.Item.WithSetting_kindItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("setting_kind", position);
                return new global::Enhance.Client.Settings.Service.Item.WithSetting_kindItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Settings.Service.ServiceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ServiceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/settings/service", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Settings.Service.ServiceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ServiceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/settings/service", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
