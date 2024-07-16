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


namespace Oci.ResourceschedulerService.Models
{
    /// <summary>
    /// This is a resource filter for filtering resources based on their creation time.
    /// </summary>
    public class TimeCreatedResourceFilter : ResourceFilter
    {
                ///
        /// <value>
        /// This is the condition for the filter in comparison to its creation time.
        /// </value>
        ///
        public enum ConditionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EQUAL")]
            Equal,
            [EnumMember(Value = "BEFORE")]
            Before,
            [EnumMember(Value = "AFTER")]
            After
        };

        /// <value>
        /// This is the condition for the filter in comparison to its creation time.
        /// </value>
        [JsonProperty(PropertyName = "condition")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ConditionEnum> Condition { get; set; }
        
        /// <value>
        /// This is the date and time as the value of the filter.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        [JsonProperty(PropertyName = "attribute")]
        private readonly string attribute = "TIME_CREATED";
    }
}