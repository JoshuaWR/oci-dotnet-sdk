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


namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Details of a target member of a Exadata Fleet Update Collection.
    /// 
    /// </summary>
    public class TargetSummary 
    {
        
        [JsonProperty(PropertyName = "target")]
        public TargetDetails Target { get; set; }
        
        /// <value>
        /// Current version of the target
        /// 
        /// </value>
        [JsonProperty(PropertyName = "currentVersion")]
        public string CurrentVersion { get; set; }
                ///
        /// <value>
        /// Status of the target in the Exadata Fleet Update Collection.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "IDLE")]
            Idle,
            [EnumMember(Value = "EXECUTING_JOB")]
            ExecutingJob,
            [EnumMember(Value = "JOB_FAILED")]
            JobFailed
        };

        /// <value>
        /// Status of the target in the Exadata Fleet Update Collection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// Exadata Fleet Update Job OCID executing an action in the target. Null if no job is being executed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "executingFsuJobId")]
        public string ExecutingFsuJobId { get; set; }
        
        /// <value>
        /// Active Exadata Fleet Update Cycle OCID. Null if no Cycle is active that has this target as member.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "activeFsuCycleId")]
        public string ActiveFsuCycleId { get; set; }
        
        [JsonProperty(PropertyName = "progress")]
        public TargetProgressSummary Progress { get; set; }
        
    }
}
