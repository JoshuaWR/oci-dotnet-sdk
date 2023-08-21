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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Unit details of a data object column of TIME unit category.
    /// </summary>
    public class DataObjectTimeColumnUnit : DataObjectColumnUnit
    {
                ///
        /// <value>
        /// Time unit.
        /// </value>
        ///
        public enum UnitEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NANO_SECOND")]
            NanoSecond,
            [EnumMember(Value = "MICRO_SECOND")]
            MicroSecond,
            [EnumMember(Value = "MILLI_SECOND")]
            MilliSecond,
            [EnumMember(Value = "CENTI_SECOND")]
            CentiSecond,
            [EnumMember(Value = "SECOND")]
            Second,
            [EnumMember(Value = "HOUR")]
            Hour,
            [EnumMember(Value = "DAY")]
            Day,
            [EnumMember(Value = "WEEK")]
            Week,
            [EnumMember(Value = "MONTH")]
            Month,
            [EnumMember(Value = "YEAR")]
            Year,
            [EnumMember(Value = "MINUTE")]
            Minute
        };

        /// <value>
        /// Time unit.
        /// </value>
        [JsonProperty(PropertyName = "unit")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UnitEnum> Unit { get; set; }
        
        [JsonProperty(PropertyName = "unitCategory")]
        private readonly string unitCategory = "TIME";
    }
}
