/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Represents the metadata description of a connection used by deployments in the same compartment.
    /// 
    /// </summary>
    [JsonConverter(typeof(ConnectionModelConverter))]
    public class Connection 
    {
        
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the connection being
        /// referenced.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// An object's Display Name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Metadata about this specific object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment being referenced.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A simple key-value pair that is applied without any predefined name, type, or scope. Exists
        /// for cross-compatibility only.
        /// <br/>
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Tags defined for this resource. Each key is predefined and scoped to a namespace.
        /// <br/>
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The system tags associated with this resource, if any. The system tags are set by Oracle
        /// Cloud Infrastructure services. Each key is predefined and scoped to namespaces.  For more
        /// information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {orcl-cloud: {free-tier-retain: true}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
                ///
        /// <value>
        /// Possible lifecycle states for connection.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// Possible lifecycle states for connection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Describes the object's current state in detail. For example, it can be used to provide
        /// actionable information for a resource in a Failed state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The time the resource was created. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the resource was last updated. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Refers to the customer's vault OCID. 
        /// If provided, it references a vault where GoldenGate can manage secrets. Customers must add policies to permit GoldenGate
        /// to manage secrets contained within this vault.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        
        /// <value>
        /// Refers to the customer's master key OCID. 
        /// If provided, it references a key to manage secrets. Customers must add policies to permit GoldenGate to use this key.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }
        
        /// <value>
        /// List of ingress IP addresses from where the GoldenGate deployment connects to this connection's privateIp. 
        /// Customers may optionally set up ingress security rules to restrict traffic from these IP addresses.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ingressIps")]
        public System.Collections.Generic.List<IngressIpDetails> IngressIps { get; set; }
        
        /// <value>
        /// An array of Network Security Group OCIDs used to define network access for either Deployments or Connections.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the target subnet of the dedicated connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// Controls the network traffic direction to the target:
        /// SHARED_SERVICE_ENDPOINT: Traffic flows through the Goldengate Service's network to public hosts. Cannot be used for private targets. 
        /// SHARED_DEPLOYMENT_ENDPOINT: Network traffic flows from the assigned deployment's private endpoint through the deployment's subnet.
        /// DEDICATED_ENDPOINT: A dedicated private endpoint is created in the target VCN subnet for the connection. The subnetId is required when DEDICATED_ENDPOINT networking is selected.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routingMethod")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RoutingMethod> RoutingMethod { get; set; }
        
    }

    public class ConnectionModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(Connection);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(Connection);
            var discriminator = jsonObject["connectionType"].Value<string>();
            switch (discriminator)
            {
                case "KAFKA":
                    obj = new KafkaConnection();
                    break;
                case "POSTGRESQL":
                    obj = new PostgresqlConnection();
                    break;
                case "JAVA_MESSAGE_SERVICE":
                    obj = new JavaMessageServiceConnection();
                    break;
                case "ELASTICSEARCH":
                    obj = new ElasticsearchConnection();
                    break;
                case "AMAZON_REDSHIFT":
                    obj = new AmazonRedshiftConnection();
                    break;
                case "SNOWFLAKE":
                    obj = new SnowflakeConnection();
                    break;
                case "GOLDENGATE":
                    obj = new GoldenGateConnection();
                    break;
                case "MYSQL":
                    obj = new MysqlConnection();
                    break;
                case "AMAZON_S3":
                    obj = new AmazonS3Connection();
                    break;
                case "GOOGLE_BIGQUERY":
                    obj = new GoogleBigQueryConnection();
                    break;
                case "ORACLE":
                    obj = new OracleConnection();
                    break;
                case "AZURE_DATA_LAKE_STORAGE":
                    obj = new AzureDataLakeStorageConnection();
                    break;
                case "MONGODB":
                    obj = new MongoDbConnection();
                    break;
                case "HDFS":
                    obj = new HdfsConnection();
                    break;
                case "GOOGLE_CLOUD_STORAGE":
                    obj = new GoogleCloudStorageConnection();
                    break;
                case "OCI_OBJECT_STORAGE":
                    obj = new OciObjectStorageConnection();
                    break;
                case "KAFKA_SCHEMA_REGISTRY":
                    obj = new KafkaSchemaRegistryConnection();
                    break;
                case "MICROSOFT_SQLSERVER":
                    obj = new MicrosoftSqlserverConnection();
                    break;
                case "AMAZON_KINESIS":
                    obj = new AmazonKinesisConnection();
                    break;
                case "GENERIC":
                    obj = new GenericConnection();
                    break;
                case "ORACLE_NOSQL":
                    obj = new OracleNosqlConnection();
                    break;
                case "AZURE_SYNAPSE_ANALYTICS":
                    obj = new AzureSynapseConnection();
                    break;
                case "REDIS":
                    obj = new RedisConnection();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under Connection! Returning null value.");
            }
            return obj;
        }
    }
}
