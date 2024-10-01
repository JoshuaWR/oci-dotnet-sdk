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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Definition of a Schedule.
    /// </summary>
    public class SchedulerDefinition 
    {
        
        /// <value>
        /// The OCID of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: My new resource
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A user-friendly description. To provide some insight about the resource.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Tenancy OCID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Associated region
        /// </value>
        [JsonProperty(PropertyName = "resourceRegion")]
        public string ResourceRegion { get; set; }
        
        /// <value>
        /// The time this resource was created. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time this resource was last updated. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Scheduled date for the next run of the Job.
        /// </value>
        [JsonProperty(PropertyName = "timeOfNextRun")]
        public System.Nullable<System.DateTime> TimeOfNextRun { get; set; }
        
        /// <value>
        /// Activity Initiation Cut Off
        /// </value>
        [JsonProperty(PropertyName = "activityInitiationCutOff")]
        public System.Nullable<int> ActivityInitiationCutOff { get; set; }
        
        [JsonProperty(PropertyName = "schedule")]
        public Schedule Schedule { get; set; }
        
        /// <value>
        /// Count of Action Groups affected by the Schedule.
        /// </value>
        [JsonProperty(PropertyName = "countOfAffectedActionGroups")]
        public System.Nullable<int> CountOfAffectedActionGroups { get; set; }
        
        /// <value>
        /// Count of Resources affected by the Schedule
        /// </value>
        [JsonProperty(PropertyName = "countOfAffectedResources")]
        public System.Nullable<int> CountOfAffectedResources { get; set; }
        
        /// <value>
        /// Count of Targets affected by the Schedule
        /// </value>
        [JsonProperty(PropertyName = "countOfAffectedTargets")]
        public System.Nullable<int> CountOfAffectedTargets { get; set; }
        
        /// <value>
        /// All ActionGroup Types part of the schedule.
        /// </value>
        [JsonProperty(PropertyName = "actionGroupTypes", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<LifeCycleActionGroupType> ActionGroupTypes { get; set; }
        
        /// <value>
        /// All application types part of the schedule for ENVIRONMENT ActionGroup Type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "applicationTypes")]
        public System.Collections.Generic.List<string> ApplicationTypes { get; set; }
        
        /// <value>
        /// All products part of the schedule for PRODUCT ActionGroup Type.
        /// </value>
        [JsonProperty(PropertyName = "products")]
        public System.Collections.Generic.List<string> Products { get; set; }
        
        /// <value>
        /// All LifeCycle Operations part of the schedule
        /// </value>
        [JsonProperty(PropertyName = "lifecycleOperations")]
        public System.Collections.Generic.List<string> LifecycleOperations { get; set; }
        
        /// <value>
        /// Action Groups associated with the Schedule.
        /// </value>
        [JsonProperty(PropertyName = "actionGroups")]
        public System.Collections.Generic.List<ActionGroup> ActionGroups { get; set; }
        
        /// <value>
        /// Runbooks.
        /// </value>
        [JsonProperty(PropertyName = "runBooks")]
        public System.Collections.Generic.List<OperationRunbook> RunBooks { get; set; }
                ///
        /// <value>
        /// The current state of the SchedulerDefinition.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
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
            Failed,
            [EnumMember(Value = "INACTIVE")]
            Inactive
        };

        /// <value>
        /// The current state of the SchedulerDefinition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
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
        
    }
}