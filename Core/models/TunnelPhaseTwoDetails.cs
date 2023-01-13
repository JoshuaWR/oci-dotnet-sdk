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
    /// IPsec tunnel detail information specific to phase two.
    /// </summary>
    public class TunnelPhaseTwoDetails 
    {
        
        /// <value>
        /// Indicates whether custom phase two configuration is enabled.
        /// If this option is not enabled, default settings are proposed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isCustomPhaseTwoConfig")]
        public System.Nullable<bool> IsCustomPhaseTwoConfig { get; set; }
        
        /// <value>
        /// The total configured lifetime of the IKE security association.
        /// </value>
        [JsonProperty(PropertyName = "lifetime")]
        public System.Nullable<long> Lifetime { get; set; }
        
        /// <value>
        /// The remaining lifetime before the key is refreshed.
        /// </value>
        [JsonProperty(PropertyName = "remainingLifetime")]
        public System.Nullable<long> RemainingLifetime { get; set; }
        
        /// <value>
        /// Phase two authentication algorithm proposed during tunnel negotiation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customAuthenticationAlgorithm")]
        public string CustomAuthenticationAlgorithm { get; set; }
        
        /// <value>
        /// The negotiated phase two authentication algorithm.
        /// </value>
        [JsonProperty(PropertyName = "negotiatedAuthenticationAlgorithm")]
        public string NegotiatedAuthenticationAlgorithm { get; set; }
        
        /// <value>
        /// The proposed custom phase two encryption algorithm.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customEncryptionAlgorithm")]
        public string CustomEncryptionAlgorithm { get; set; }
        
        /// <value>
        /// The negotiated encryption algorithm.
        /// </value>
        [JsonProperty(PropertyName = "negotiatedEncryptionAlgorithm")]
        public string NegotiatedEncryptionAlgorithm { get; set; }
        
        /// <value>
        /// The proposed Diffie-Hellman group.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dhGroup")]
        public string DhGroup { get; set; }
        
        /// <value>
        /// The negotiated Diffie-Hellman group.
        /// </value>
        [JsonProperty(PropertyName = "negotiatedDhGroup")]
        public string NegotiatedDhGroup { get; set; }
        
        /// <value>
        /// Indicates that ESP phase two is established.
        /// </value>
        [JsonProperty(PropertyName = "isEspEstablished")]
        public System.Nullable<bool> IsEspEstablished { get; set; }
        
        /// <value>
        /// Indicates that PFS (perfect forward secrecy) is enabled.
        /// </value>
        [JsonProperty(PropertyName = "isPfsEnabled")]
        public System.Nullable<bool> IsPfsEnabled { get; set; }
        
        /// <value>
        /// The date and time the remaining lifetime was last retrieved, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "remainingLifetimeLastRetrieved")]
        public System.Nullable<System.DateTime> RemainingLifetimeLastRetrieved { get; set; }
        
    }
}
