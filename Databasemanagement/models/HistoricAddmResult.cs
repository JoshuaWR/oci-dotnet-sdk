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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of the historic ADDM task.
    /// 
    /// </summary>
    public class HistoricAddmResult 
    {
        
        /// <value>
        /// Specifies whether the ADDM task returned had already existed or was newly created by the api call.
        /// </value>
        [JsonProperty(PropertyName = "isNewlyCreated")]
        public System.Nullable<bool> IsNewlyCreated { get; set; }
        
        /// <value>
        /// The name of the historic ADDM task.
        /// </value>
        [JsonProperty(PropertyName = "taskName")]
        public string TaskName { get; set; }
        
        /// <value>
        /// The ID of the historic ADDM task.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TaskId is required.")]
        [JsonProperty(PropertyName = "taskId")]
        public System.Nullable<long> TaskId { get; set; }
        
        /// <value>
        /// The description of the ADDM task.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The database user who owns the historic ADDM task.
        /// </value>
        [JsonProperty(PropertyName = "dbUser")]
        public string DbUser { get; set; }
                ///
        /// <value>
        /// The status of the ADDM task.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "INITIAL")]
            Initial,
            [EnumMember(Value = "EXECUTING")]
            Executing,
            [EnumMember(Value = "INTERRUPTED")]
            Interrupted,
            [EnumMember(Value = "COMPLETED")]
            Completed,
            [EnumMember(Value = "ERROR")]
            Error
        };

        /// <value>
        /// The status of the ADDM task.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The creation date of the ADDM task.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// A description of how the task was created.
        /// </value>
        ///
        public enum HowCreatedEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AUTO")]
            Auto,
            [EnumMember(Value = "MANUAL")]
            Manual
        };

        /// <value>
        /// A description of how the task was created.
        /// </value>
        [JsonProperty(PropertyName = "howCreated")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<HowCreatedEnum> HowCreated { get; set; }
        
        /// <value>
        /// The timestamp of the beginning AWR snapshot used in the ADDM task as defined by date-time RFC3339 format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "startSnapshotTime")]
        public System.Nullable<System.DateTime> StartSnapshotTime { get; set; }
        
        /// <value>
        /// The timestamp of the ending AWR snapshot used in the ADDM task as defined by date-time RFC3339 format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "endSnapshotTime")]
        public System.Nullable<System.DateTime> EndSnapshotTime { get; set; }
        
        /// <value>
        /// The ID number of the beginning AWR snapshot.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "beginSnapshotId")]
        public System.Nullable<long> BeginSnapshotId { get; set; }
        
        /// <value>
        /// The ID number of the ending AWR snapshot.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "endSnapshotId")]
        public System.Nullable<long> EndSnapshotId { get; set; }
        
        /// <value>
        /// The number of ADDM findings.
        /// </value>
        [JsonProperty(PropertyName = "findings")]
        public System.Nullable<long> Findings { get; set; }
        
    }
}
