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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Summary of a Operations Insights Warehouse resource.
    /// </summary>
    public class OperationsInsightsWarehouseSummary 
    {
        
        /// <value>
        /// OPSI Warehouse OCID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// User-friedly name of Operations Insights Warehouse that does not have to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Number of OCPUs allocated to OPSI Warehouse ADW.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuAllocated is required.")]
        [JsonProperty(PropertyName = "cpuAllocated")]
        public System.Double CpuAllocated { get; set; }
        
        /// <value>
        /// Number of OCPUs used by OPSI Warehouse ADW. Can be fractional.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cpuUsed")]
        public System.Double CpuUsed { get; set; }
        
        /// <value>
        /// Storage allocated to OPSI Warehouse ADW.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "storageAllocatedInGBs")]
        public System.Double StorageAllocatedInGBs { get; set; }
        
        /// <value>
        /// Storage by OPSI Warehouse ADW in GB.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "storageUsedInGBs")]
        public System.Double StorageUsedInGBs { get; set; }
        
        /// <value>
        /// OCID of the dynamic group created for the warehouse
        /// </value>
        [JsonProperty(PropertyName = "dynamicGroupId")]
        public string DynamicGroupId { get; set; }
        
        /// <value>
        /// Tenancy Identifier of Operations Insights service
        /// </value>
        [JsonProperty(PropertyName = "operationsInsightsTenancyId")]
        public string OperationsInsightsTenancyId { get; set; }
        
        /// <value>
        /// The time at which the ADW wallet was last rotated for the Operations Insights Warehouse. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeLastWalletRotated")]
        public System.Nullable<System.DateTime> TimeLastWalletRotated { get; set; }
        
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
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// The time at which the resource was first created. An RFC3339 formatted datetime string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time at which the resource was last updated. An RFC3339 formatted datetime string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Possible lifecycle states
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperationsInsightsWarehouseLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
    }
}
