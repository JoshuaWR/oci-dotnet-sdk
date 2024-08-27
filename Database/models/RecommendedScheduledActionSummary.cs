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
    /// Details of the scheduled action that is used in getRecommendedScheduledActions.
    /// 
    /// </summary>
    public class RecommendedScheduledActionSummary 
    {
        
        /// <value>
        /// The order of the scheduled action.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionOrder is required.")]
        [JsonProperty(PropertyName = "actionOrder")]
        public System.Nullable<int> ActionOrder { get; set; }
                ///
        /// <value>
        /// The type of the scheduled action being performed
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
        /// The type of the scheduled action being performed
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionType is required.")]
        [JsonProperty(PropertyName = "actionType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActionTypeEnum> ActionType { get; set; }
        
        /// <value>
        /// Description of the scheduled action being performed, i.e. apply full update to DB Servers 1,2,3,4.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The id of the scheduling window this scheduled action belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SchedulingWindowId is required.")]
        [JsonProperty(PropertyName = "schedulingWindowId")]
        public string SchedulingWindowId { get; set; }
        
        /// <value>
        /// The estimated patching time in minutes for the entire scheduled action.
        /// </value>
        [JsonProperty(PropertyName = "estimatedTimeInMins")]
        public System.Nullable<int> EstimatedTimeInMins { get; set; }
        
        /// <value>
        /// The list of action members in a scheduled action.
        /// </value>
        [JsonProperty(PropertyName = "actionMembers")]
        public System.Collections.Generic.List<ActionMember> ActionMembers { get; set; }
        
        /// <value>
        /// Map<ParamName, ParamValue> where a key value pair describes the specific action parameter.
        /// Example: {&quot;count&quot;: &quot;3&quot;}
        /// </value>
        [JsonProperty(PropertyName = "actionParams")]
        public System.Collections.Generic.Dictionary<string, string> ActionParams { get; set; }
        
    }
}
