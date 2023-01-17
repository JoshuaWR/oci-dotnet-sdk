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


namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// Details of data masking activity.
    /// </summary>
    public class DataMaskingActivity 
    {
        
        /// <value>
        /// Unique identifier that is immutable on creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Fusion Environment Identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FusionEnvironmentId is required.")]
        [JsonProperty(PropertyName = "fusionEnvironmentId")]
        public string FusionEnvironmentId { get; set; }
                ///
        /// <value>
        /// The current state of the DataMaskingActivity.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// The current state of the DataMaskingActivity.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The time the data masking activity started. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeMaskingStart is required.")]
        [JsonProperty(PropertyName = "timeMaskingStart")]
        public System.Nullable<System.DateTime> TimeMaskingStart { get; set; }
        
        /// <value>
        /// The time the data masking activity ended. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeMaskingFinish is required.")]
        [JsonProperty(PropertyName = "timeMaskingFinish")]
        public System.Nullable<System.DateTime> TimeMaskingFinish { get; set; }
        
    }
}
