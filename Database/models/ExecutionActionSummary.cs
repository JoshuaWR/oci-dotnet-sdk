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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details of an execution action.
    /// 
    /// </summary>
    public class ExecutionActionSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the execution action.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the execution window resource the execution action belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExecutionWindowId is required.")]
        [JsonProperty(PropertyName = "executionWindowId")]
        public string ExecutionWindowId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The user-friendly name for the execution action. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the execution action.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
                ///
        /// <value>
        /// The current state of the execution action. Valid states are SCHEDULED, IN_PROGRESS, FAILED, CANCELED,
        /// UPDATING, DELETED, SUCCEEDED and PARTIAL_SUCCESS.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SCHEDULED")]
            Scheduled,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "CANCELED")]
            Canceled,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "PARTIAL_SUCCESS")]
            PartialSuccess
        };

        /// <value>
        /// The current state of the execution action. Valid states are SCHEDULED, IN_PROGRESS, FAILED, CANCELED,
        /// UPDATING, DELETED, SUCCEEDED and PARTIAL_SUCCESS.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
                ///
        /// <value>
        /// The current sub-state of the execution action. Valid states are DURATION_EXCEEDED, MAINTENANCE_IN_PROGRESS and WAITING.
        /// 
        /// </value>
        ///
        public enum LifecycleSubstateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DURATION_EXCEEDED")]
            DurationExceeded,
            [EnumMember(Value = "MAINTENANCE_IN_PROGRESS")]
            MaintenanceInProgress,
            [EnumMember(Value = "WAITING")]
            Waiting,
            [EnumMember(Value = "RESCHEDULED")]
            Rescheduled
        };

        /// <value>
        /// The current sub-state of the execution action. Valid states are DURATION_EXCEEDED, MAINTENANCE_IN_PROGRESS and WAITING.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleSubstate")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleSubstateEnum> LifecycleSubstate { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The date and time the execution action was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The last date and time that the execution action was updated.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The estimated time of the execution action in minutes.
        /// </value>
        [JsonProperty(PropertyName = "estimatedTimeInMins")]
        public System.Nullable<int> EstimatedTimeInMins { get; set; }
        
        /// <value>
        /// The total time taken by corresponding resource activity in minutes.
        /// </value>
        [JsonProperty(PropertyName = "totalTimeTakenInMins")]
        public System.Nullable<int> TotalTimeTakenInMins { get; set; }
        
        /// <value>
        /// The priority order of the execution action.
        /// </value>
        [JsonProperty(PropertyName = "executionActionOrder")]
        public System.Nullable<int> ExecutionActionOrder { get; set; }
                ///
        /// <value>
        /// The action type of the execution action being performed
        /// </value>
        ///
        public enum ActionTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DB_SERVER_FULL_SOFTWARE_UPDATE")]
            DbServerFullSoftwareUpdate,
            [EnumMember(Value = "STORAGE_SERVER_FULL_SOFTWARE_UPDATE")]
            StorageServerFullSoftwareUpdate,
            [EnumMember(Value = "NETWORK_SWITCH_FULL_SOFTWARE_UPDATE")]
            NetworkSwitchFullSoftwareUpdate
        };

        /// <value>
        /// The action type of the execution action being performed
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionType is required.")]
        [JsonProperty(PropertyName = "actionType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActionTypeEnum> ActionType { get; set; }
        
        /// <value>
        /// Map<ParamName, ParamValue> where a key value pair describes the specific action parameter.
        /// Example: {&quot;count&quot;: &quot;3&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionParams is required.")]
        [JsonProperty(PropertyName = "actionParams")]
        public System.Collections.Generic.Dictionary<string, string> ActionParams { get; set; }
        
        /// <value>
        /// List of action members of this execution action.
        /// </value>
        [JsonProperty(PropertyName = "actionMembers")]
        public System.Collections.Generic.List<ExecutionActionMember> ActionMembers { get; set; }
        
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
