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
    public partial class ImportMigrationEntry : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The createdAt property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The filename property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Filename { get; set; }
#nullable restore
#else
        public string Filename { get; set; }
#endif
        /// <summary>The filesize property</summary>
        public int? Filesize { get; set; }
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The importType property</summary>
        public global::Enhance.Client.Models.ImportMigrationEntry_importType? ImportType { get; set; }
        /// <summary>The orgId property</summary>
        public Guid? OrgId { get; set; }
        /// <summary>The percentageComplete property</summary>
        public int? PercentageComplete { get; set; }
        /// <summary>The primaryDomain property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryDomain { get; set; }
#nullable restore
#else
        public string PrimaryDomain { get; set; }
#endif
        /// <summary>The status property</summary>
        public global::Enhance.Client.Models.ImportMigrationEntry_status? Status { get; set; }
        /// <summary>The updatedAt property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.ImportMigrationEntry"/> and sets the default values.
        /// </summary>
        public ImportMigrationEntry()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.ImportMigrationEntry"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.ImportMigrationEntry CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.ImportMigrationEntry();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "filename", n => { Filename = n.GetStringValue(); } },
                { "filesize", n => { Filesize = n.GetIntValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "importType", n => { ImportType = n.GetEnumValue<global::Enhance.Client.Models.ImportMigrationEntry_importType>(); } },
                { "orgId", n => { OrgId = n.GetGuidValue(); } },
                { "percentageComplete", n => { PercentageComplete = n.GetIntValue(); } },
                { "primaryDomain", n => { PrimaryDomain = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Enhance.Client.Models.ImportMigrationEntry_status>(); } },
                { "updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteStringValue("filename", Filename);
            writer.WriteIntValue("filesize", Filesize);
            writer.WriteGuidValue("id", Id);
            writer.WriteEnumValue<global::Enhance.Client.Models.ImportMigrationEntry_importType>("importType", ImportType);
            writer.WriteGuidValue("orgId", OrgId);
            writer.WriteIntValue("percentageComplete", PercentageComplete);
            writer.WriteStringValue("primaryDomain", PrimaryDomain);
            writer.WriteEnumValue<global::Enhance.Client.Models.ImportMigrationEntry_status>("status", Status);
            writer.WriteDateTimeOffsetValue("updatedAt", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
