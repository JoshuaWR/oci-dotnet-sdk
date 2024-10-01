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


namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// Criteria to evaluate against incoming network traffic.
    /// A match occurs when at least one item in the array associated with each specified property corresponds with the relevant aspect of the traffic.
    /// 
    /// </summary>
    public class VxlanInspectionRuleMatchCriteria 
    {
        
        /// <value>
        /// An array of address list names to be evaluated against the traffic source address.
        /// </value>
        [JsonProperty(PropertyName = "sourceAddress")]
        public System.Collections.Generic.List<string> SourceAddress { get; set; }
        
        /// <value>
        /// An array of address list names to be evaluated against the traffic destination address.
        /// </value>
        [JsonProperty(PropertyName = "destinationAddress")]
        public System.Collections.Generic.List<string> DestinationAddress { get; set; }
        
    }
}