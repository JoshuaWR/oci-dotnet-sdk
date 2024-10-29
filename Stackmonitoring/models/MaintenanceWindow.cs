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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// Maintenance Window object. It contains all the information of the Maintenance window.
    /// Used in the Create and Get operations.
    /// 
    /// </summary>
    public class MaintenanceWindow 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of maintenance window.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Maintenance Window name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Maintenance Window description.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Compartment Identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// List of resource Ids which are part of the Maintenance Window
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.List<CreateMaintenanceWindowResourceDetails> Resources { get; set; }
        
        /// <value>
        /// List of resource details that are part of the Maintenance Window.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resourcesDetails")]
        public System.Collections.Generic.List<MonitoredResourceDetails> ResourcesDetails { get; set; }
        
        /// <value>
        /// Lifecycle state of the monitored resource.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MaintenanceWindowLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Lifecycle Details of the Maintenance Window.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MaintenanceWindowLifecycleDetails> LifecycleDetails { get; set; }
        
        [JsonProperty(PropertyName = "schedule")]
        public MaintenanceWindowSchedule Schedule { get; set; }
        
        /// <value>
        /// The time the the maintenance window was created. An RFC3339 formatted datetime string
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the the mainteance window was updated. An RFC3339 formatted datetime string
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
    }
}