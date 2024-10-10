// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Enhance.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class SiteAccessMember : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The avatarPath property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AvatarPath { get; set; }
#nullable restore
#else
        public string AvatarPath { get; set; }
#endif
        /// <summary>The colorCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ColorCode { get; set; }
#nullable restore
#else
        public string ColorCode { get; set; }
#endif
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.SiteAccessMember"/> and sets the default values.
        /// </summary>
        public SiteAccessMember()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.SiteAccessMember"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.SiteAccessMember CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.SiteAccessMember();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "avatarPath", n => { AvatarPath = n.GetStringValue(); } },
                { "colorCode", n => { ColorCode = n.GetStringValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("avatarPath", AvatarPath);
            writer.WriteStringValue("colorCode", ColorCode);
            writer.WriteStringValue("email", Email);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
