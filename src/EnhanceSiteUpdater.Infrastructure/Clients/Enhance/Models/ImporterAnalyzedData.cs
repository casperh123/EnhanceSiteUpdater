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
    public partial class ImporterAnalyzedData : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The crontabs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_crontabs>? Crontabs { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_crontabs> Crontabs { get; set; }
#endif
        /// <summary>The domains property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_domains>? Domains { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_domains> Domains { get; set; }
#endif
        /// <summary>The ftps property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_ftps>? Ftps { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_ftps> Ftps { get; set; }
#endif
        /// <summary>The mailboxes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_mailboxes>? Mailboxes { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_mailboxes> Mailboxes { get; set; }
#endif
        /// <summary>The mysqlDatabases property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_mysqlDatabases>? MysqlDatabases { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_mysqlDatabases> MysqlDatabases { get; set; }
#endif
        /// <summary>The mysqlGrants property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_mysqlGrants>? MysqlGrants { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_mysqlGrants> MysqlGrants { get; set; }
#endif
        /// <summary>The mysqlUsers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_mysqlUsers>? MysqlUsers { get; set; }
#nullable restore
#else
        public List<global::Enhance.Client.Models.ImporterAnalyzedData_mysqlUsers> MysqlUsers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Models.ImporterAnalyzedData"/> and sets the default values.
        /// </summary>
        public ImporterAnalyzedData()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.ImporterAnalyzedData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Enhance.Client.Models.ImporterAnalyzedData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Enhance.Client.Models.ImporterAnalyzedData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "crontabs", n => { Crontabs = n.GetCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_crontabs>(global::Enhance.Client.Models.ImporterAnalyzedData_crontabs.CreateFromDiscriminatorValue)?.AsList(); } },
                { "domains", n => { Domains = n.GetCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_domains>(global::Enhance.Client.Models.ImporterAnalyzedData_domains.CreateFromDiscriminatorValue)?.AsList(); } },
                { "ftps", n => { Ftps = n.GetCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_ftps>(global::Enhance.Client.Models.ImporterAnalyzedData_ftps.CreateFromDiscriminatorValue)?.AsList(); } },
                { "mailboxes", n => { Mailboxes = n.GetCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_mailboxes>(global::Enhance.Client.Models.ImporterAnalyzedData_mailboxes.CreateFromDiscriminatorValue)?.AsList(); } },
                { "mysqlDatabases", n => { MysqlDatabases = n.GetCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_mysqlDatabases>(global::Enhance.Client.Models.ImporterAnalyzedData_mysqlDatabases.CreateFromDiscriminatorValue)?.AsList(); } },
                { "mysqlGrants", n => { MysqlGrants = n.GetCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_mysqlGrants>(global::Enhance.Client.Models.ImporterAnalyzedData_mysqlGrants.CreateFromDiscriminatorValue)?.AsList(); } },
                { "mysqlUsers", n => { MysqlUsers = n.GetCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_mysqlUsers>(global::Enhance.Client.Models.ImporterAnalyzedData_mysqlUsers.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_crontabs>("crontabs", Crontabs);
            writer.WriteCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_domains>("domains", Domains);
            writer.WriteCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_ftps>("ftps", Ftps);
            writer.WriteCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_mailboxes>("mailboxes", Mailboxes);
            writer.WriteCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_mysqlDatabases>("mysqlDatabases", MysqlDatabases);
            writer.WriteCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_mysqlGrants>("mysqlGrants", MysqlGrants);
            writer.WriteCollectionOfObjectValues<global::Enhance.Client.Models.ImporterAnalyzedData_mysqlUsers>("mysqlUsers", MysqlUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
