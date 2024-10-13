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
    public partial class SubscriptionDedicatedServersInfo : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The appServer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.SubscriptionDedicatedServer? AppServer { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.SubscriptionDedicatedServer AppServer { get; set; }
#endif
        /// <summary>The backupServer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.SubscriptionDedicatedServer? BackupServer { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.SubscriptionDedicatedServer BackupServer { get; set; }
#endif
        /// <summary>The dbServer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.SubscriptionDedicatedServer? DbServer { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.SubscriptionDedicatedServer DbServer { get; set; }
#endif
        /// <summary>The emailServer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.SubscriptionDedicatedServer? EmailServer { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.SubscriptionDedicatedServer EmailServer { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.SubscriptionDedicatedServersInfo"/> and sets the default values.
        /// </summary>
        public SubscriptionDedicatedServersInfo()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.SubscriptionDedicatedServersInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.SubscriptionDedicatedServersInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.SubscriptionDedicatedServersInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "appServer", n => { AppServer = n.GetObjectValue<global::Enhance.Client.Models.SubscriptionDedicatedServer>(global::Enhance.Client.Models.SubscriptionDedicatedServer.CreateFromDiscriminatorValue); } },
                { "backupServer", n => { BackupServer = n.GetObjectValue<global::Enhance.Client.Models.SubscriptionDedicatedServer>(global::Enhance.Client.Models.SubscriptionDedicatedServer.CreateFromDiscriminatorValue); } },
                { "dbServer", n => { DbServer = n.GetObjectValue<global::Enhance.Client.Models.SubscriptionDedicatedServer>(global::Enhance.Client.Models.SubscriptionDedicatedServer.CreateFromDiscriminatorValue); } },
                { "emailServer", n => { EmailServer = n.GetObjectValue<global::Enhance.Client.Models.SubscriptionDedicatedServer>(global::Enhance.Client.Models.SubscriptionDedicatedServer.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Enhance.Client.Models.SubscriptionDedicatedServer>("appServer", AppServer);
            writer.WriteObjectValue<global::Enhance.Client.Models.SubscriptionDedicatedServer>("backupServer", BackupServer);
            writer.WriteObjectValue<global::Enhance.Client.Models.SubscriptionDedicatedServer>("dbServer", DbServer);
            writer.WriteObjectValue<global::Enhance.Client.Models.SubscriptionDedicatedServer>("emailServer", EmailServer);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
