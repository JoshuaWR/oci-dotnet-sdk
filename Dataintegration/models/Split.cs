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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The information about the split operator. Split operator has one input and many output links. Split operator allows users to take one data set and based on conditions produce many different outputs.
    /// </summary>
    public class Split : Operator
    {
                ///
        /// <value>
        /// Specify how to handle data that matches a split condition. Either data that matches the first condition should be removed from further processing by other conditions, or all matched data should be evaluated for all conditions.
        /// </value>
        ///
        public enum DataRoutingStrategyEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "FIRST")]
            First,
            [EnumMember(Value = "ALL")]
            All
        };

        /// <value>
        /// Specify how to handle data that matches a split condition. Either data that matches the first condition should be removed from further processing by other conditions, or all matched data should be evaluated for all conditions.
        /// </value>
        [JsonProperty(PropertyName = "dataRoutingStrategy")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DataRoutingStrategyEnum> DataRoutingStrategy { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "SPLIT_OPERATOR";
    }
}
