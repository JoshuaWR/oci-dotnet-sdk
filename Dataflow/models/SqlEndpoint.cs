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


namespace Oci.DataflowService.Models
{
    /// <summary>
    /// The description of a SQL Endpoint.
    /// </summary>
    public class SqlEndpoint 
    {
        
        /// <value>
        /// The provision identifier that is immutable on creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The SQL Endpoint name, which can be changed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of a compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The JDBC URL field. For example, jdbc:spark://{serviceFQDN}:443/default;SparkServerType=DFI
        /// </value>
        [JsonProperty(PropertyName = "jdbcEndpointUrl")]
        public string JdbcEndpointUrl { get; set; }
        
        /// <value>
        /// The time the Sql Endpoint was created. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the Sql Endpoint was updated. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the Sql Endpoint.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SqlEndpointLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the reason why the resource is in it's current state. Helps bubble up errors in state changes. For example, it can be used to provide actionable information for a resource in the Failed state.
        /// </value>
        [JsonProperty(PropertyName = "stateMessage")]
        public string StateMessage { get; set; }
        
        /// <value>
        /// The version of SQL Endpoint.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlEndpointVersion is required.")]
        [JsonProperty(PropertyName = "sqlEndpointVersion")]
        public string SqlEndpointVersion { get; set; }
        
        /// <value>
        /// The shape of the SQL Endpoint driver instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DriverShape is required.")]
        [JsonProperty(PropertyName = "driverShape")]
        public string DriverShape { get; set; }
        
        [JsonProperty(PropertyName = "driverShapeConfig")]
        public ShapeConfig DriverShapeConfig { get; set; }
        
        /// <value>
        /// The shape of the SQL Endpoint executor instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExecutorShape is required.")]
        [JsonProperty(PropertyName = "executorShape")]
        public string ExecutorShape { get; set; }
        
        [JsonProperty(PropertyName = "executorShapeConfig")]
        public ShapeConfig ExecutorShapeConfig { get; set; }
        
        /// <value>
        /// The minimum number of executors.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MinExecutorCount is required.")]
        [JsonProperty(PropertyName = "minExecutorCount")]
        public System.Nullable<int> MinExecutorCount { get; set; }
        
        /// <value>
        /// The maximum number of executors.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaxExecutorCount is required.")]
        [JsonProperty(PropertyName = "maxExecutorCount")]
        public System.Nullable<int> MaxExecutorCount { get; set; }
        
        /// <value>
        /// The OCID of OCI Hive Metastore.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetastoreId is required.")]
        [JsonProperty(PropertyName = "metastoreId")]
        public string MetastoreId { get; set; }
        
        /// <value>
        /// The OCID of OCI Lake.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LakeId is required.")]
        [JsonProperty(PropertyName = "lakeId")]
        public string LakeId { get; set; }
        
        /// <value>
        /// The warehouse bucket URI. It is a Oracle Cloud Infrastructure Object Storage bucket URI as defined here https://docs.oracle.com/en/cloud/paas/atp-cloud/atpud/object-storage-uris.html
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WarehouseBucketUri is required.")]
        [JsonProperty(PropertyName = "warehouseBucketUri")]
        public string WarehouseBucketUri { get; set; }
        
        /// <value>
        /// The description of the SQL Endpoint.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// This token is used by Splat, and indicates that the service accepts the request, and that the request is currently being processed.
        /// </value>
        [JsonProperty(PropertyName = "lastAcceptedRequestToken")]
        public string LastAcceptedRequestToken { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The system tags associated with this resource, if any. The system tags are set by Oracle cloud infrastructure services. Each key is predefined and scoped to namespaces.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {orcl-cloud: {free-tier-retain: true}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// The Spark configuration passed to the running process.
        /// See https://spark.apache.org/docs/latest/configuration.html#available-properties.
        /// Example: { &quot;spark.app.name&quot; : &quot;My App Name&quot;, &quot;spark.shuffle.io.maxRetries&quot; : &quot;4&quot; }Note: Not all Spark properties are permitted to be set.  Attempting to set a property that isnot allowed to be overwritten will cause a 400 status to be returned.
        /// </value>
        [JsonProperty(PropertyName = "sparkAdvancedConfigurations")]
        public System.Collections.Generic.Dictionary<string, string> SparkAdvancedConfigurations { get; set; }
        
        [JsonProperty(PropertyName = "networkConfiguration")]
        public SqlEndpointNetworkConfiguration NetworkConfiguration { get; set; }
        
    }
}
