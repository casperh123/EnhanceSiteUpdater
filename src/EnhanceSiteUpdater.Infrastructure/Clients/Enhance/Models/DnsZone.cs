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
    public partial class DnsZone : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The dnssecDnskeyRecords property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DnssecDnskeyRecords { get; set; }
#nullable restore
#else
        public string DnssecDnskeyRecords { get; set; }
#endif
        /// <summary>The dnssecDsRecords property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DnssecDsRecords { get; set; }
#nullable restore
#else
        public string DnssecDsRecords { get; set; }
#endif
        /// <summary>The origin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Origin { get; set; }
#nullable restore
#else
        public string Origin { get; set; }
#endif
        /// <summary>The records property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.DnsRecord>? Records { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.DnsRecord> Records { get; set; }
#endif
        /// <summary>The soa property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Enhance.Client.Models.DnsSoa? Soa { get; set; }
#nullable restore
#else
        public global::Enhance.Client.Models.DnsSoa Soa { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.DnsZone"/> and sets the default values.
        /// </summary>
        public DnsZone()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.DnsZone"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.DnsZone CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.DnsZone();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "dnssecDnskeyRecords", n => { DnssecDnskeyRecords = n.GetStringValue(); } },
                { "dnssecDsRecords", n => { DnssecDsRecords = n.GetStringValue(); } },
                { "origin", n => { Origin = n.GetStringValue(); } },
                { "records", n => { Records = n.GetCollectionOfObjectValues<global::Enhance.Client.Models.DnsRecord>(global::Enhance.Client.Models.DnsRecord.CreateFromDiscriminatorValue)?.AsList(); } },
                { "soa", n => { Soa = n.GetObjectValue<global::Enhance.Client.Models.DnsSoa>(global::Enhance.Client.Models.DnsSoa.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("dnssecDnskeyRecords", DnssecDnskeyRecords);
            writer.WriteStringValue("dnssecDsRecords", DnssecDsRecords);
            writer.WriteStringValue("origin", Origin);
            writer.WriteCollectionOfObjectValues<global::Enhance.Client.Models.DnsRecord>("records", Records);
            writer.WriteObjectValue<global::Enhance.Client.Models.DnsSoa>("soa", Soa);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
