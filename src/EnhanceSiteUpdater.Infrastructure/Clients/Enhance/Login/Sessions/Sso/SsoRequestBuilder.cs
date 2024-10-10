// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Login.Sessions.Sso
{
    /// <summary>
    /// Builds and executes requests for operations under \login\sessions\sso
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class SsoRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Login.Sessions.Sso.SsoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SsoRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/login/sessions/sso?otp={otp}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Login.Sessions.Sso.SsoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SsoRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/login/sessions/sso?otp={otp}", rawUrl)
        {
        }
        /// <summary>
        /// Creates a new session for the login in a specific login realm, using a short lived one time password.This creates a session as well, with the difference that realmId is required and any 2FA will be bypassed.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.LoginMemberships"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.LoginMemberships?> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Login.Sessions.Sso.SsoRequestBuilder.SsoRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.LoginMemberships> GetAsync(Action<RequestConfiguration<global::Enhance.Client.Login.Sessions.Sso.SsoRequestBuilder.SsoRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.LoginMemberships>(requestInfo, global::Enhance.Client.Models.LoginMemberships.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new session for the login in a specific login realm, using a short lived one time password.This creates a session as well, with the difference that realmId is required and any 2FA will be bypassed.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Login.Sessions.Sso.SsoRequestBuilder.SsoRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Login.Sessions.Sso.SsoRequestBuilder.SsoRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Login.Sessions.Sso.SsoRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Login.Sessions.Sso.SsoRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Login.Sessions.Sso.SsoRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Creates a new session for the login in a specific login realm, using a short lived one time password.This creates a session as well, with the difference that realmId is required and any 2FA will be bypassed.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class SsoRequestBuilderGetQueryParameters 
        {
            /// <summary>Contains a short lived otp for direct login bypassing any 2FA.</summary>
            [QueryParameter("otp")]
            public Guid? Otp { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class SsoRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Enhance.Client.Login.Sessions.Sso.SsoRequestBuilder.SsoRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
