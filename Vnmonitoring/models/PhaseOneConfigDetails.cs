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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Configuration details for IKE phase one (ISAKMP) configuration parameters.
    /// </summary>
    public class PhaseOneConfigDetails 
    {
        
        /// <value>
        /// Indicates whether custom configuration is enabled for phase one options.
        /// </value>
        [JsonProperty(PropertyName = "isCustomPhaseOneConfig")]
        public System.Nullable<bool> IsCustomPhaseOneConfig { get; set; }
                ///
        /// <value>
        /// The custom authentication algorithm proposed during phase one tunnel negotiation.
        /// 
        /// </value>
        ///
        public enum AuthenticationAlgorithmEnum {
            [EnumMember(Value = "SHA2_384")]
            Sha2384,
            [EnumMember(Value = "SHA2_256")]
            Sha2256,
            [EnumMember(Value = "SHA1_96")]
            Sha196
        };

        /// <value>
        /// The custom authentication algorithm proposed during phase one tunnel negotiation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "authenticationAlgorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AuthenticationAlgorithmEnum> AuthenticationAlgorithm { get; set; }
                ///
        /// <value>
        /// The custom encryption algorithm proposed during phase one tunnel negotiation.
        /// 
        /// </value>
        ///
        public enum EncryptionAlgorithmEnum {
            [EnumMember(Value = "AES_256_CBC")]
            Aes256Cbc,
            [EnumMember(Value = "AES_192_CBC")]
            Aes192Cbc,
            [EnumMember(Value = "AES_128_CBC")]
            Aes128Cbc
        };

        /// <value>
        /// The custom encryption algorithm proposed during phase one tunnel negotiation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "encryptionAlgorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<EncryptionAlgorithmEnum> EncryptionAlgorithm { get; set; }
                ///
        /// <value>
        /// The custom Diffie-Hellman group proposed during phase one tunnel negotiation.
        /// 
        /// </value>
        ///
        public enum DiffieHelmanGroupEnum {
            [EnumMember(Value = "GROUP2")]
            Group2,
            [EnumMember(Value = "GROUP5")]
            Group5,
            [EnumMember(Value = "GROUP14")]
            Group14,
            [EnumMember(Value = "GROUP19")]
            Group19,
            [EnumMember(Value = "GROUP20")]
            Group20,
            [EnumMember(Value = "GROUP24")]
            Group24
        };

        /// <value>
        /// The custom Diffie-Hellman group proposed during phase one tunnel negotiation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "diffieHelmanGroup")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DiffieHelmanGroupEnum> DiffieHelmanGroup { get; set; }
        
        /// <value>
        /// Internet key association (IKE) session key lifetime in seconds for IPSec phase one. The default is 28800 which is equivalent to 8 hours.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifetimeInSeconds")]
        public System.Nullable<int> LifetimeInSeconds { get; set; }
        
    }
}