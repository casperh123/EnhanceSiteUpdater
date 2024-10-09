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
    public partial class ActivityObjectMember1 : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The from property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.ActivityObjectEntity? From { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.ActivityObjectEntity From { get; set; }
#endif
        /// <summary>The to property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.ActivityObjectEntity? To { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.ActivityObjectEntity To { get; set; }
#endif
        /// <summary>The type property</summary>
        public global::Enhance.Client.Models.ActivityObjectMember1_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.ActivityObjectMember1"/> and sets the default values.
        /// </summary>
        public ActivityObjectMember1()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.ActivityObjectMember1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.ActivityObjectMember1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.ActivityObjectMember1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "from", n => { From = n.GetObjectValue<global::Enhance.Client.Models.ActivityObjectEntity>(global::Enhance.Client.Models.ActivityObjectEntity.CreateFromDiscriminatorValue); } },
                { "to", n => { To = n.GetObjectValue<global::Enhance.Client.Models.ActivityObjectEntity>(global::Enhance.Client.Models.ActivityObjectEntity.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<global::Enhance.Client.Models.ActivityObjectMember1_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Enhance.Client.Models.ActivityObjectEntity>("from", From);
            writer.WriteObjectValue<global::Enhance.Client.Models.ActivityObjectEntity>("to", To);
            writer.WriteEnumValue<global::Enhance.Client.Models.ActivityObjectMember1_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
