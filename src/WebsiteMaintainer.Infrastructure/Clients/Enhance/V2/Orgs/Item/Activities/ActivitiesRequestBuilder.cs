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
namespace Enhance.Client.V2.Orgs.Item.Activities
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\orgs\{org_id}\activities
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ActivitiesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.V2.Orgs.Item.Activities.ActivitiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActivitiesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/orgs/{org_id}/activities{?activityKinds*,anyEntityId*,createdAfter*,createdBefore*,entityKind*,limit*,offset*,search*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.V2.Orgs.Item.Activities.ActivitiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActivitiesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/orgs/{org_id}/activities{?activityKinds*,anyEntityId*,createdAfter*,createdBefore*,entityKind*,limit*,offset*,search*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns organization&apos;s activity log which is a human readable list of events that happened in orchd.Only accessible to Owner, SuperAdmin and Sysadmin.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.ActivitiesListing"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.ActivitiesListing?> GetAsync(Action<RequestConfiguration<global::Enhance.Client.V2.Orgs.Item.Activities.ActivitiesRequestBuilder.ActivitiesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.ActivitiesListing> GetAsync(Action<RequestConfiguration<global::Enhance.Client.V2.Orgs.Item.Activities.ActivitiesRequestBuilder.ActivitiesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.ActivitiesListing>(requestInfo, global::Enhance.Client.Models.ActivitiesListing.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns organization&apos;s activity log which is a human readable list of events that happened in orchd.Only accessible to Owner, SuperAdmin and Sysadmin.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.V2.Orgs.Item.Activities.ActivitiesRequestBuilder.ActivitiesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Enhance.Client.V2.Orgs.Item.Activities.ActivitiesRequestBuilder.ActivitiesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Enhance.Client.V2.Orgs.Item.Activities.ActivitiesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.V2.Orgs.Item.Activities.ActivitiesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.V2.Orgs.Item.Activities.ActivitiesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns organization&apos;s activity log which is a human readable list of events that happened in orchd.Only accessible to Owner, SuperAdmin and Sysadmin.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ActivitiesRequestBuilderGetQueryParameters 
        {
            /// <summary>Select only activities matching the given kinds. If not provided or provided empty array, all kinds are selected as it makes no sense for an activity to not have a kind.</summary>
            [Obsolete("This property is deprecated, use ActivityKindsAsActivityKind instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("activityKinds")]
            public string[]? ActivityKinds { get; set; }
#nullable restore
#else
            [QueryParameter("activityKinds")]
            public string[] ActivityKinds { get; set; }
#endif
            /// <summary>Select only activities matching the given kinds. If not provided or provided empty array, all kinds are selected as it makes no sense for an activity to not have a kind.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("activityKinds")]
            public global::Enhance.Client.Models.ActivityKind[]? ActivityKindsAsActivityKind { get; set; }
#nullable restore
#else
            [QueryParameter("activityKinds")]
            public global::Enhance.Client.Models.ActivityKind[] ActivityKindsAsActivityKind { get; set; }
#endif
            /// <summary>Filter activities maching any of the provided uuids. Since an activity can have 0 or more entities, providing an empty array is not the same as not providing this parameter. An empty array will match activities with 0 entities, while not providing this parameter will ignore this filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("anyEntityId")]
            public Guid?[]? AnyEntityId { get; set; }
#nullable restore
#else
            [QueryParameter("anyEntityId")]
            public Guid?[] AnyEntityId { get; set; }
#endif
            /// <summary>Only return resources which have been created after provided date.</summary>
            [QueryParameter("createdAfter")]
            public Date? CreatedAfter { get; set; }
            /// <summary>Only return resources which have been created earlier than provided date.</summary>
            [QueryParameter("createdBefore")]
            public Date? CreatedBefore { get; set; }
            /// <summary>Activities which contain the given entity kind either as object or context entity.</summary>
            [Obsolete("This property is deprecated, use EntityKindAsGetEntityKindQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("entityKind")]
            public string? EntityKind { get; set; }
#nullable restore
#else
            [QueryParameter("entityKind")]
            public string EntityKind { get; set; }
#endif
            /// <summary>Activities which contain the given entity kind either as object or context entity.</summary>
            [QueryParameter("entityKind")]
            public global::Enhance.Client.V2.Orgs.Item.Activities.GetEntityKindQueryParameterType? EntityKindAsGetEntityKindQueryParameterType { get; set; }
            /// <summary>The maximum number of items to return.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>The offset from which to return items.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>Limit the result set to the resources whose names, partially and case insensitively, match the specified search term.E.g. for websites, this is their domain or tag, for databases the database name, for emails the email address or mailbox name, etc.A website will also be returned if the search term exactly matches the website&apos;s uuid.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("search")]
            public string Search { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ActivitiesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Enhance.Client.V2.Orgs.Item.Activities.ActivitiesRequestBuilder.ActivitiesRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
