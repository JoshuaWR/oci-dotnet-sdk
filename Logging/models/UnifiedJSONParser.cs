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


namespace Oci.LoggingService.Models
{
    /// <summary>
    /// JSON parser.
    /// </summary>
    public class UnifiedJSONParser : UnifiedAgentParser
    {
                ///
        ///
        public enum TimeTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "FLOAT")]
            Float,
            [EnumMember(Value = "UNIXTIME")]
            Unixtime,
            [EnumMember(Value = "STRING")]
            String
        };

        [JsonProperty(PropertyName = "timeType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TimeTypeEnum> TimeType { get; set; }
        
        [JsonProperty(PropertyName = "timeFormat")]
        public string TimeFormat { get; set; }
        
        [JsonProperty(PropertyName = "parserType")]
        private readonly string parserType = "JSON";
    }
}
