/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// The information about the join operator. The join operator links data from multiple inbound sources.
    /// </summary>
    public class Join : PushDownOperation
    {
        
        /// <value>
        /// The join condition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Condition is required.")]
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }
                ///
        /// <value>
        /// The type of join.
        /// </value>
        ///
        public enum PolicyEnum {
            [EnumMember(Value = "INNER_JOIN")]
            InnerJoin,
            [EnumMember(Value = "LEFT_JOIN")]
            LeftJoin,
            [EnumMember(Value = "RIGHT_JOIN")]
            RightJoin,
            [EnumMember(Value = "FULL_JOIN")]
            FullJoin
        };

        /// <value>
        /// The type of join.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Policy is required.")]
        [JsonProperty(PropertyName = "policy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PolicyEnum> Policy { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "JOIN";
    }
}
