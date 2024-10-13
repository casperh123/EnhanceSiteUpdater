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
    public partial class BackupRoleInfo : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The bkupd property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.ServiceInfo? Bkupd { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.ServiceInfo Bkupd { get; set; }
#endif
        /// <summary>The last24hSnapshotsCount property</summary>
        public int? Last24hSnapshotsCount { get; set; }
        /// <summary>The snapshotsCount property</summary>
        public int? SnapshotsCount { get; set; }
        /// <summary>The state property</summary>
        public global::Enhance.Client.Models.ServerRoleState? State { get; set; }
        /// <summary>The usage property</summary>
        public int? Usage { get; set; }
        /// <summary>The number of websites whose backups are assigned to be on this backup role.</summary>
        public int? WebsitesCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.BackupRoleInfo"/> and sets the default values.
        /// </summary>
        public BackupRoleInfo()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.BackupRoleInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.BackupRoleInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.BackupRoleInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bkupd", n => { Bkupd = n.GetObjectValue<global::Enhance.Client.Models.ServiceInfo>(global::Enhance.Client.Models.ServiceInfo.CreateFromDiscriminatorValue); } },
                { "last24hSnapshotsCount", n => { Last24hSnapshotsCount = n.GetIntValue(); } },
                { "snapshotsCount", n => { SnapshotsCount = n.GetIntValue(); } },
                { "state", n => { State = n.GetEnumValue<global::Enhance.Client.Models.ServerRoleState>(); } },
                { "usage", n => { Usage = n.GetIntValue(); } },
                { "websitesCount", n => { WebsitesCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Enhance.Client.Models.ServiceInfo>("bkupd", Bkupd);
            writer.WriteIntValue("last24hSnapshotsCount", Last24hSnapshotsCount);
            writer.WriteIntValue("snapshotsCount", SnapshotsCount);
            writer.WriteEnumValue<global::Enhance.Client.Models.ServerRoleState>("state", State);
            writer.WriteIntValue("usage", Usage);
            writer.WriteIntValue("websitesCount", WebsitesCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
