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
    public partial class LoginMembership : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The isMasterOrg property</summary>
        public bool? IsMasterOrg { get; set; }
        /// <summary>The memberId property</summary>
        public Guid? MemberId { get; set; }
        /// <summary>The orgId property</summary>
        public Guid? OrgId { get; set; }
        /// <summary>The orgName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrgName { get; set; }
#nullable restore
#else
        public string OrgName { get; set; }
#endif
        /// <summary>The roles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.Role?>? Roles { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.Role?> Roles { get; set; }
#endif
        /// <summary>The siteAccessCount property</summary>
        public double? SiteAccessCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.LoginMembership"/> and sets the default values.
        /// </summary>
        public LoginMembership()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.LoginMembership"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.LoginMembership CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.LoginMembership();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "isMasterOrg", n => { IsMasterOrg = n.GetBoolValue(); } },
                { "memberId", n => { MemberId = n.GetGuidValue(); } },
                { "orgId", n => { OrgId = n.GetGuidValue(); } },
                { "orgName", n => { OrgName = n.GetStringValue(); } },
                { "roles", n => { Roles = n.GetCollectionOfEnumValues<global::Enhance.Client.Models.Role>()?.AsList(); } },
                { "siteAccessCount", n => { SiteAccessCount = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isMasterOrg", IsMasterOrg);
            writer.WriteGuidValue("memberId", MemberId);
            writer.WriteGuidValue("orgId", OrgId);
            writer.WriteStringValue("orgName", OrgName);
            writer.WriteCollectionOfEnumValues<global::Enhance.Client.Models.Role>("roles", Roles);
            writer.WriteDoubleValue("siteAccessCount", SiteAccessCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
