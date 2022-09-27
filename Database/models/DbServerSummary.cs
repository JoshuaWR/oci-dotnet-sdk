/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details of the Exadata Cloud@Customer Db server.
    /// 
    /// </summary>
    public class DbServerSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Exacc Db server.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The user-friendly name for the Db server. The name does not need to be unique.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "exadataInfrastructureId")]
        public string ExadataInfrastructureId { get; set; }
        
        /// <value>
        /// The number of CPU cores enabled on the Db server.
        /// </value>
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// The allocated memory in GBs on the Db server.
        /// </value>
        [JsonProperty(PropertyName = "memorySizeInGBs")]
        public System.Nullable<int> MemorySizeInGBs { get; set; }
        
        /// <value>
        /// The allocated local node storage in GBs on the Db server.
        /// </value>
        [JsonProperty(PropertyName = "dbNodeStorageSizeInGBs")]
        public System.Nullable<int> DbNodeStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VM Clusters associated with the Db server.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vmClusterIds")]
        public System.Collections.Generic.List<string> VmClusterIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Db nodes associated with the Db server.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbNodeIds")]
        public System.Collections.Generic.List<string> DbNodeIds { get; set; }
        
        /// <value>
        /// The shape of the Db server. The shape determines the amount of CPU, storage, and memory resources available.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
                ///
        /// <value>
        /// The current state of the Db server.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "UNAVAILABLE")]
            Unavailable,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "MAINTENANCE_IN_PROGRESS")]
            MaintenanceInProgress
        };

        /// <value>
        /// The current state of the Db server.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The total number of CPU cores available.
        /// </value>
        [JsonProperty(PropertyName = "maxCpuCount")]
        public System.Nullable<int> MaxCpuCount { get; set; }
        
        /// <value>
        /// The total memory available in GBs.
        /// </value>
        [JsonProperty(PropertyName = "maxMemoryInGBs")]
        public System.Nullable<int> MaxMemoryInGBs { get; set; }
        
        /// <value>
        /// The total local node storage available in GBs.
        /// </value>
        [JsonProperty(PropertyName = "maxDbNodeStorageInGBs")]
        public System.Nullable<int> MaxDbNodeStorageInGBs { get; set; }
        
        /// <value>
        /// The date and time that the Db Server was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        [JsonProperty(PropertyName = "dbServerPatchingDetails")]
        public DbServerPatchingDetails DbServerPatchingDetails { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
