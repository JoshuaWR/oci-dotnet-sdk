/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.PsqlService.Models
{
    /// <summary>
    /// The information about new database system.
    /// </summary>
    public class CreateDbSystemDetails 
    {
        
        /// <value>
        /// A user-friendly display name for the database system. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A user-provided description of a database system.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that contains the database system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Type of the database system.
        /// </value>
        [JsonProperty(PropertyName = "systemType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DbSystem.SystemTypeEnum> SystemType { get; set; }
        
        /// <value>
        /// Version of database system software.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbVersion is required.")]
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the configuration associated with the database system.
        /// </value>
        [JsonProperty(PropertyName = "configId")]
        public string ConfigId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StorageDetails is required.")]
        [JsonProperty(PropertyName = "storageDetails")]
        public StorageDetails StorageDetails { get; set; }
        
        /// <value>
        /// The name of the shape for the database instance node. Use the /shapes API for accepted shapes.
        /// Example: VM.Standard.E4.Flex
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The total number of OCPUs available to each database instance node.
        /// </value>
        [JsonProperty(PropertyName = "instanceOcpuCount")]
        public System.Nullable<int> InstanceOcpuCount { get; set; }
        
        /// <value>
        /// The total amount of memory available to each database instance node, in gigabytes.
        /// </value>
        [JsonProperty(PropertyName = "instanceMemorySizeInGBs")]
        public System.Nullable<int> InstanceMemorySizeInGBs { get; set; }
        
        /// <value>
        /// Count of database instances nodes to be created in the database system.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "instanceCount")]
        public System.Nullable<int> InstanceCount { get; set; }
        
        /// <value>
        /// Details of database instances nodes to be created. This parameter is optional.
        /// If specified, its size must match `instanceCount`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "instancesDetails")]
        public System.Collections.Generic.List<CreateDbInstanceDetails> InstancesDetails { get; set; }
        
        [JsonProperty(PropertyName = "credentials")]
        public Credentials Credentials { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NetworkDetails is required.")]
        [JsonProperty(PropertyName = "networkDetails")]
        public NetworkDetails NetworkDetails { get; set; }
        
        [JsonProperty(PropertyName = "managementPolicy")]
        public ManagementPolicyDetails ManagementPolicy { get; set; }
        
        [JsonProperty(PropertyName = "source")]
        public SourceDetails Source { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}