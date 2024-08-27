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


namespace Oci.KeymanagementService.Models
{
    /// <summary>
    /// The details of auto rotation schedule for the Key being create updated or imported.
    /// </summary>
    public class AutoKeyRotationDetails 
    {
        
        /// <value>
        /// The interval of auto key rotation. For auto key rotation the interval should between 60 day and 365 days (1 year). Note: User must specify this parameter when creating a new schedule.
        /// </value>
        [JsonProperty(PropertyName = "rotationIntervalInDays")]
        public System.Nullable<int> RotationIntervalInDays { get; set; }
        
        /// <value>
        /// A property indicating  scheduled start date expressed as date YYYY-MM-DD String. Example: 2023-04-04T00:00:00Z. The time has no significance when scheduling an auto key rotation as this can be done anytime approximately the scheduled day, KMS ignores the time and replaces it with 00:00, for example 2023-04-04T15:14:13Z will be used as 2023-04-04T00:00:00Z . Note : Today\u2019s date will be used if not specified by customer.
        /// </value>
        [JsonProperty(PropertyName = "timeOfScheduleStart")]
        public System.Nullable<System.DateTime> TimeOfScheduleStart { get; set; }
        
        /// <value>
        /// A property indicating Next estimated scheduled Time, as per the interval, expressed as date YYYY-MM-DD String. Example: 2023-04-04T00:00:00Z. The time has no significance when scheduling an auto key rotation as this can be done anytime approximately the scheduled day, KMS ignores the time and replaces it with 00:00, for example 2023-04-04T15:14:13Z will be used as 2023-04-04T00:00:00Z.
        /// </value>
        [JsonProperty(PropertyName = "timeOfNextRotation")]
        public System.Nullable<System.DateTime> TimeOfNextRotation { get; set; }
        
        /// <value>
        /// A property indicating Last rotation Date. Example: 2023-04-04T00:00:00Z.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastRotation")]
        public System.Nullable<System.DateTime> TimeOfLastRotation { get; set; }
                ///
        /// <value>
        /// The status of last execution of auto key rotation.
        /// </value>
        ///
        public enum LastRotationStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SUCCESS")]
            Success,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress
        };

        /// <value>
        /// The status of last execution of auto key rotation.
        /// </value>
        [JsonProperty(PropertyName = "lastRotationStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LastRotationStatusEnum> LastRotationStatus { get; set; }
        
        /// <value>
        /// The last execution status message of auto key rotation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lastRotationMessage")]
        public string LastRotationMessage { get; set; }
        
    }
}
