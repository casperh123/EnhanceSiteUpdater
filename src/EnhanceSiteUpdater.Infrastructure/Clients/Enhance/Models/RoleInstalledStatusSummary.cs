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
    public partial class RoleInstalledStatusSummary : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The application property</summary>
        public global::Enhance.Client.Models.RoleInstallationState? Application { get; set; }
        /// <summary>The backup property</summary>
        public global::Enhance.Client.Models.RoleInstallationState? Backup { get; set; }
        /// <summary>The database property</summary>
        public global::Enhance.Client.Models.RoleInstallationState? Database { get; set; }
        /// <summary>The dns property</summary>
        public global::Enhance.Client.Models.RoleInstallationState? Dns { get; set; }
        /// <summary>The email property</summary>
        public global::Enhance.Client.Models.RoleInstallationState? Email { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.RoleInstalledStatusSummary"/> and sets the default values.
        /// </summary>
        public RoleInstalledStatusSummary()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.RoleInstalledStatusSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.RoleInstalledStatusSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.RoleInstalledStatusSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "application", n => { Application = n.GetEnumValue<global::Enhance.Client.Models.RoleInstallationState>(); } },
                { "backup", n => { Backup = n.GetEnumValue<global::Enhance.Client.Models.RoleInstallationState>(); } },
                { "database", n => { Database = n.GetEnumValue<global::Enhance.Client.Models.RoleInstallationState>(); } },
                { "dns", n => { Dns = n.GetEnumValue<global::Enhance.Client.Models.RoleInstallationState>(); } },
                { "email", n => { Email = n.GetEnumValue<global::Enhance.Client.Models.RoleInstallationState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Enhance.Client.Models.RoleInstallationState>("application", Application);
            writer.WriteEnumValue<global::Enhance.Client.Models.RoleInstallationState>("backup", Backup);
            writer.WriteEnumValue<global::Enhance.Client.Models.RoleInstallationState>("database", Database);
            writer.WriteEnumValue<global::Enhance.Client.Models.RoleInstallationState>("dns", Dns);
            writer.WriteEnumValue<global::Enhance.Client.Models.RoleInstallationState>("email", Email);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
