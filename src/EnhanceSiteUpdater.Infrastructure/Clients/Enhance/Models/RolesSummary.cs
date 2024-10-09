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
    public partial class RolesSummary : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The application property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.RoleSummary? Application { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.RoleSummary Application { get; set; }
#endif
        /// <summary>The backup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.RoleSummary? Backup { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.RoleSummary Backup { get; set; }
#endif
        /// <summary>The controlPanel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.RoleSummary? ControlPanel { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.RoleSummary ControlPanel { get; set; }
#endif
        /// <summary>The database property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.RoleSummary? Database { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.RoleSummary Database { get; set; }
#endif
        /// <summary>The dns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.RoleSummary? Dns { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.RoleSummary Dns { get; set; }
#endif
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.RoleSummary? Email { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.RoleSummary Email { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.RolesSummary"/> and sets the default values.
        /// </summary>
        public RolesSummary()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.RolesSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.RolesSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.RolesSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "application", n => { Application = n.GetObjectValue<global::Enhance.Client.Models.RoleSummary>(global::Enhance.Client.Models.RoleSummary.CreateFromDiscriminatorValue); } },
                { "backup", n => { Backup = n.GetObjectValue<global::Enhance.Client.Models.RoleSummary>(global::Enhance.Client.Models.RoleSummary.CreateFromDiscriminatorValue); } },
                { "controlPanel", n => { ControlPanel = n.GetObjectValue<global::Enhance.Client.Models.RoleSummary>(global::Enhance.Client.Models.RoleSummary.CreateFromDiscriminatorValue); } },
                { "database", n => { Database = n.GetObjectValue<global::Enhance.Client.Models.RoleSummary>(global::Enhance.Client.Models.RoleSummary.CreateFromDiscriminatorValue); } },
                { "dns", n => { Dns = n.GetObjectValue<global::Enhance.Client.Models.RoleSummary>(global::Enhance.Client.Models.RoleSummary.CreateFromDiscriminatorValue); } },
                { "email", n => { Email = n.GetObjectValue<global::Enhance.Client.Models.RoleSummary>(global::Enhance.Client.Models.RoleSummary.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Enhance.Client.Models.RoleSummary>("application", Application);
            writer.WriteObjectValue<global::Enhance.Client.Models.RoleSummary>("backup", Backup);
            writer.WriteObjectValue<global::Enhance.Client.Models.RoleSummary>("controlPanel", ControlPanel);
            writer.WriteObjectValue<global::Enhance.Client.Models.RoleSummary>("database", Database);
            writer.WriteObjectValue<global::Enhance.Client.Models.RoleSummary>("dns", Dns);
            writer.WriteObjectValue<global::Enhance.Client.Models.RoleSummary>("email", Email);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
