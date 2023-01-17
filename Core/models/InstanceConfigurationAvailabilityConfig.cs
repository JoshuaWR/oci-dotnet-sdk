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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Options for defining the availabiity of a VM instance after a maintenance event that impacts the underlying hardware.
    /// 
    /// </summary>
    public class InstanceConfigurationAvailabilityConfig 
    {
                ///
        /// <value>
        /// The lifecycle state for an instance when it is recovered after infrastructure maintenance.
        /// * `RESTORE_INSTANCE` - The instance is restored to the lifecycle state it was in before the maintenance event.
        /// If the instance was running, it is automatically rebooted. This is the default action when a value is not set.
        /// * `STOP_INSTANCE` - The instance is recovered in the stopped state.
        /// 
        /// </value>
        ///
        public enum RecoveryActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "RESTORE_INSTANCE")]
            RestoreInstance,
            [EnumMember(Value = "STOP_INSTANCE")]
            StopInstance
        };

        /// <value>
        /// The lifecycle state for an instance when it is recovered after infrastructure maintenance.
        /// * `RESTORE_INSTANCE` - The instance is restored to the lifecycle state it was in before the maintenance event.
        /// If the instance was running, it is automatically rebooted. This is the default action when a value is not set.
        /// * `STOP_INSTANCE` - The instance is recovered in the stopped state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "recoveryAction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RecoveryActionEnum> RecoveryAction { get; set; }
        
    }
}
