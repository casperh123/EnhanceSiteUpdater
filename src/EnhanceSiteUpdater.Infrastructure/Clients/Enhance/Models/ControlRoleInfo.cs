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
    public partial class ControlRoleInfo : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The authd property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.CoreServiceInfo? Authd { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.CoreServiceInfo Authd { get; set; }
#endif
        /// <summary>The logd property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.CoreServiceInfo? Logd { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.CoreServiceInfo Logd { get; set; }
#endif
        /// <summary>The sged property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.CoreServiceInfo? Sged { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.CoreServiceInfo Sged { get; set; }
#endif
        /// <summary>The usage property</summary>
        public int? Usage { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.ControlRoleInfo"/> and sets the default values.
        /// </summary>
        public ControlRoleInfo()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.ControlRoleInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.ControlRoleInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.ControlRoleInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "authd", n => { Authd = n.GetObjectValue<global::Enhance.Client.Models.CoreServiceInfo>(global::Enhance.Client.Models.CoreServiceInfo.CreateFromDiscriminatorValue); } },
                { "logd", n => { Logd = n.GetObjectValue<global::Enhance.Client.Models.CoreServiceInfo>(global::Enhance.Client.Models.CoreServiceInfo.CreateFromDiscriminatorValue); } },
                { "sged", n => { Sged = n.GetObjectValue<global::Enhance.Client.Models.CoreServiceInfo>(global::Enhance.Client.Models.CoreServiceInfo.CreateFromDiscriminatorValue); } },
                { "usage", n => { Usage = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Enhance.Client.Models.CoreServiceInfo>("authd", Authd);
            writer.WriteObjectValue<global::Enhance.Client.Models.CoreServiceInfo>("logd", Logd);
            writer.WriteObjectValue<global::Enhance.Client.Models.CoreServiceInfo>("sged", Sged);
            writer.WriteIntValue("usage", Usage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
