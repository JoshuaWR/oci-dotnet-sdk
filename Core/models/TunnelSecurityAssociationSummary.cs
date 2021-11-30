/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// Detailed Tunnel SA
    /// </summary>
    public class TunnelSecurityAssociationSummary 
    {
        
        /// <value>
        /// IP and mask of the Partner Subnet for Policy Based VPNs or Static Routes
        /// </value>
        [JsonProperty(PropertyName = "cpeSubnet")]
        public string CpeSubnet { get; set; }
        
        /// <value>
        /// IP and mask of the Local Subnet for Policy Based VPNs or Static Routes
        /// </value>
        [JsonProperty(PropertyName = "oracleSubnet")]
        public string OracleSubnet { get; set; }
                ///
        /// <value>
        /// Phase 1 Status of the Tunnel
        /// </value>
        ///
        public enum TunnelSaStatusEnum {
            [EnumMember(Value = "INITIATING")]
            Initiating,
            [EnumMember(Value = "LISTENING")]
            Listening,
            [EnumMember(Value = "UP")]
            Up,
            [EnumMember(Value = "DOWN")]
            Down,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        };

        /// <value>
        /// Phase 1 Status of the Tunnel
        /// </value>
        [JsonProperty(PropertyName = "tunnelSaStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TunnelSaStatusEnum> TunnelSaStatus { get; set; }
        
        /// <value>
        /// Current state if status is not up, including phase1/phase2 and possible reason for tunnel not up
        /// </value>
        [JsonProperty(PropertyName = "tunnelSaErrorInfo")]
        public string TunnelSaErrorInfo { get; set; }
        
        /// <value>
        /// Seconds in current state
        /// </value>
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }
        
    }
}
