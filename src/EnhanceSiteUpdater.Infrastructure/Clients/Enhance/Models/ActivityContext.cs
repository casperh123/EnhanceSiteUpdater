// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Enhance.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ActivityContext : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The actor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.ActivityContext.ActivityContext_actor? Actor { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.ActivityContext.ActivityContext_actor Actor { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The domain property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.ActivityDomainEntity? Domain { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.ActivityDomainEntity Domain { get; set; }
#endif
        /// <summary>The error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.ActivityErrorEntity? Error { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.ActivityErrorEntity Error { get; set; }
#endif
        /// <summary>The org property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.ActivityOrgEntity? Org { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.ActivityOrgEntity Org { get; set; }
#endif
        /// <summary>The server property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.ActivityServerEntity? Server { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.ActivityServerEntity Server { get; set; }
#endif
        /// <summary>The website property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.ActivityWebsiteEntity? Website { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.ActivityWebsiteEntity Website { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.ActivityContext"/> and sets the default values.
        /// </summary>
        public ActivityContext()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.ActivityContext"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.ActivityContext CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.ActivityContext();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "actor", n => { Actor = n.GetObjectValue<global::Enhance.Client.Models.ActivityContext.ActivityContext_actor>(global::Enhance.Client.Models.ActivityContext.ActivityContext_actor.CreateFromDiscriminatorValue); } },
                { "domain", n => { Domain = n.GetObjectValue<global::Enhance.Client.Models.ActivityDomainEntity>(global::Enhance.Client.Models.ActivityDomainEntity.CreateFromDiscriminatorValue); } },
                { "error", n => { Error = n.GetObjectValue<global::Enhance.Client.Models.ActivityErrorEntity>(global::Enhance.Client.Models.ActivityErrorEntity.CreateFromDiscriminatorValue); } },
                { "org", n => { Org = n.GetObjectValue<global::Enhance.Client.Models.ActivityOrgEntity>(global::Enhance.Client.Models.ActivityOrgEntity.CreateFromDiscriminatorValue); } },
                { "server", n => { Server = n.GetObjectValue<global::Enhance.Client.Models.ActivityServerEntity>(global::Enhance.Client.Models.ActivityServerEntity.CreateFromDiscriminatorValue); } },
                { "website", n => { Website = n.GetObjectValue<global::Enhance.Client.Models.ActivityWebsiteEntity>(global::Enhance.Client.Models.ActivityWebsiteEntity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Enhance.Client.Models.ActivityContext.ActivityContext_actor>("actor", Actor);
            writer.WriteObjectValue<global::Enhance.Client.Models.ActivityDomainEntity>("domain", Domain);
            writer.WriteObjectValue<global::Enhance.Client.Models.ActivityErrorEntity>("error", Error);
            writer.WriteObjectValue<global::Enhance.Client.Models.ActivityOrgEntity>("org", Org);
            writer.WriteObjectValue<global::Enhance.Client.Models.ActivityServerEntity>("server", Server);
            writer.WriteObjectValue<global::Enhance.Client.Models.ActivityWebsiteEntity>("website", Website);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Enhance.Client.Models.ActivityAccessTokenEntity"/>, <see cref="global::Enhance.Client.Models.ActivityLoginEntity"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ActivityContext_actor : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Enhance.Client.Models.ActivityAccessTokenEntity"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Enhance.Client.Models.ActivityAccessTokenEntity? ActivityAccessTokenEntity { get; set; }
#nullable restore
#else
            public global::Enhance.Client.Models.ActivityAccessTokenEntity ActivityAccessTokenEntity { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Enhance.Client.Models.ActivityLoginEntity"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Enhance.Client.Models.ActivityLoginEntity? ActivityLoginEntity { get; set; }
#nullable restore
#else
            public global::Enhance.Client.Models.ActivityLoginEntity ActivityLoginEntity { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Enhance.Client.Models.ActivityContext.ActivityContext_actor"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Enhance.Client.Models.ActivityContext.ActivityContext_actor CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Enhance.Client.Models.ActivityContext.ActivityContext_actor();
                if("ActivityAccessTokenEntity".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ActivityAccessTokenEntity = new global::Enhance.Client.Models.ActivityAccessTokenEntity();
                }
                else if("ActivityLoginEntity".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ActivityLoginEntity = new global::Enhance.Client.Models.ActivityLoginEntity();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(ActivityAccessTokenEntity != null)
                {
                    return ActivityAccessTokenEntity.GetFieldDeserializers();
                }
                else if(ActivityLoginEntity != null)
                {
                    return ActivityLoginEntity.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(ActivityAccessTokenEntity != null)
                {
                    writer.WriteObjectValue<global::Enhance.Client.Models.ActivityAccessTokenEntity>(null, ActivityAccessTokenEntity);
                }
                else if(ActivityLoginEntity != null)
                {
                    writer.WriteObjectValue<global::Enhance.Client.Models.ActivityLoginEntity>(null, ActivityLoginEntity);
                }
            }
        }
    }
}
#pragma warning restore CS0618
