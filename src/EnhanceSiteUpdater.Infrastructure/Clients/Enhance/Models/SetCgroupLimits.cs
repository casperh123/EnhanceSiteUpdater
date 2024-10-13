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
    public partial class SetCgroupLimits : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ioBandwidth property</summary>
        public double? IoBandwidth { get; set; }
        /// <summary>The iops property</summary>
        public double? Iops { get; set; }
        /// <summary>The memoryLimit property</summary>
        public double? MemoryLimit { get; set; }
        /// <summary>The nproc property</summary>
        public double? Nproc { get; set; }
        /// <summary>The virtualCpus property</summary>
        public double? VirtualCpus { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.SetCgroupLimits"/> and sets the default values.
        /// </summary>
        public SetCgroupLimits()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.SetCgroupLimits"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.SetCgroupLimits CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.SetCgroupLimits();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ioBandwidth", n => { IoBandwidth = n.GetDoubleValue(); } },
                { "iops", n => { Iops = n.GetDoubleValue(); } },
                { "memoryLimit", n => { MemoryLimit = n.GetDoubleValue(); } },
                { "nproc", n => { Nproc = n.GetDoubleValue(); } },
                { "virtualCpus", n => { VirtualCpus = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("ioBandwidth", IoBandwidth);
            writer.WriteDoubleValue("iops", Iops);
            writer.WriteDoubleValue("memoryLimit", MemoryLimit);
            writer.WriteDoubleValue("nproc", Nproc);
            writer.WriteDoubleValue("virtualCpus", VirtualCpus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
