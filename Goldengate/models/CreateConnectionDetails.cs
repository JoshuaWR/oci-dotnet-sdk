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
    /// The information about a new Connection.
    /// 
    /// </summary>
    [JsonConverter(typeof(CreateConnectionDetailsModelConverter))]
    public class CreateConnectionDetails 
    {
        
        
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
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the customer vault being
        /// referenced.
        /// If provided, this will reference a vault which the customer will be required to ensure
        /// the policies are established to permit the GoldenGate Service to manage secrets contained
        /// within this vault.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the customer \"Master\" key being
        /// referenced.
        /// If provided, this will reference a key which the customer will be required to ensure
        /// the policies are established to permit the GoldenGate Service to utilize this key to
        /// manage secrets.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet being referenced.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// An array of Network Security Group OCIDs used to define network access for either Deployments or Connections.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
    }

    public class CreateConnectionDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateConnectionDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateConnectionDetails);
            var discriminator = jsonObject["connectionType"].Value<string>();
            switch (discriminator)
            {
                case "POSTGRESQL":
                    obj = new CreatePostgresqlConnectionDetails();
                    break;
                case "KAFKA_SCHEMA_REGISTRY":
                    obj = new CreateKafkaSchemaRegistryConnectionDetails();
                    break;
                case "AZURE_SYNAPSE_ANALYTICS":
                    obj = new CreateAzureSynapseConnectionDetails();
                    break;
                case "AZURE_DATA_LAKE_STORAGE":
                    obj = new CreateAzureDataLakeStorageConnectionDetails();
                    break;
                case "MYSQL":
                    obj = new CreateMysqlConnectionDetails();
                    break;
                case "OCI_OBJECT_STORAGE":
                    obj = new CreateOciObjectStorageConnectionDetails();
                    break;
                case "KAFKA":
                    obj = new CreateKafkaConnectionDetails();
                    break;
                case "ORACLE":
                    obj = new CreateOracleConnectionDetails();
                    break;
                case "GOLDENGATE":
                    obj = new CreateGoldenGateConnectionDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
