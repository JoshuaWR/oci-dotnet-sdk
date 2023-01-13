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


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// aggregated network data.
    /// </summary>
    public class AggregatedNetworkData 
    {
                ///
        /// <value>
        /// state of the result
        /// </value>
        ///
        public enum ResultStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SUCCESS")]
            Success,
            [EnumMember(Value = "FAILURE")]
            Failure,
            [EnumMember(Value = "PARTIAL")]
            Partial
        };

        /// <value>
        /// state of the result
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResultState is required.")]
        [JsonProperty(PropertyName = "resultState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResultStateEnum> ResultState { get; set; }
        
        /// <value>
        /// List of VantagePointNode items.
        /// </value>
        [JsonProperty(PropertyName = "vantagePointNodes")]
        public System.Collections.Generic.List<VantagePointNode> VantagePointNodes { get; set; }
        
        /// <value>
        /// 2d array of nodes where each internal array corresponds to 1 level
        /// </value>
        [JsonProperty(PropertyName = "nodesByLevel")]
        public System.Collections.Generic.List<System.Collections.Generic.List<Node>> NodesByLevel { get; set; }
        
        /// <value>
        /// map of Link objects
        /// </value>
        [JsonProperty(PropertyName = "links")]
        public System.Collections.Generic.Dictionary<string, Link> Links { get; set; }
        
        /// <value>
        /// string contaiing error details
        /// </value>
        [JsonProperty(PropertyName = "errorDetails")]
        public string ErrorDetails { get; set; }
        
    }
}
