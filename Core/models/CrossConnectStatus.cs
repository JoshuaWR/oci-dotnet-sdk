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
    /// The status of the cross-connect.
    /// </summary>
    public class CrossConnectStatus 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the cross-connect.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CrossConnectId is required.")]
        [JsonProperty(PropertyName = "crossConnectId")]
        public string CrossConnectId { get; set; }
                ///
        /// <value>
        /// Indicates whether Oracle's side of the interface is up or down.
        /// </value>
        ///
        public enum InterfaceStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "UP")]
            Up,
            [EnumMember(Value = "DOWN")]
            Down
        };

        /// <value>
        /// Indicates whether Oracle's side of the interface is up or down.
        /// </value>
        [JsonProperty(PropertyName = "interfaceState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<InterfaceStateEnum> InterfaceState { get; set; }
        
        /// <value>
        /// The light level of the cross-connect (in dBm).
        /// <br/>
        /// Example: 14.0
        /// </value>
        [JsonProperty(PropertyName = "lightLevelIndBm")]
        public System.Nullable<float> LightLevelIndBm { get; set; }
                ///
        /// <value>
        /// Status indicator corresponding to the light level.
        /// <br/>
        ///   * **NO_LIGHT:** No measurable light
        ///   * **LOW_WARN:** There's measurable light but it's too low
        ///   * **HIGH_WARN:** Light level is too high
        ///   * **BAD:** There's measurable light but the signal-to-noise ratio is bad
        ///   * **GOOD:** Good light level
        /// 
        /// </value>
        ///
        public enum LightLevelIndicatorEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NO_LIGHT")]
            NoLight,
            [EnumMember(Value = "LOW_WARN")]
            LowWarn,
            [EnumMember(Value = "HIGH_WARN")]
            HighWarn,
            [EnumMember(Value = "BAD")]
            Bad,
            [EnumMember(Value = "GOOD")]
            Good
        };

        /// <value>
        /// Status indicator corresponding to the light level.
        /// <br/>
        ///   * **NO_LIGHT:** No measurable light
        ///   * **LOW_WARN:** There's measurable light but it's too low
        ///   * **HIGH_WARN:** Light level is too high
        ///   * **BAD:** There's measurable light but the signal-to-noise ratio is bad
        ///   * **GOOD:** Good light level
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lightLevelIndicator")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LightLevelIndicatorEnum> LightLevelIndicator { get; set; }
                ///
        /// <value>
        /// Encryption status of this cross connect.
        /// <br/>
        /// Possible values:
        /// * **UP:** Traffic is encrypted over this cross-connect
        /// * **DOWN:** Traffic is not encrypted over this cross-connect
        /// * **CIPHER_MISMATCH:** The MACsec encryption cipher doesn't match the cipher on the CPE
        /// * **CKN_MISMATCH:** The MACsec Connectivity association Key Name (CKN) doesn't match the CKN on the CPE
        /// * **CAK_MISMATCH:** The MACsec Connectivity Association Key (CAK) doesn't match the CAK on the CPE
        /// 
        /// </value>
        ///
        public enum EncryptionStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "UP")]
            Up,
            [EnumMember(Value = "DOWN")]
            Down,
            [EnumMember(Value = "CIPHER_MISMATCH")]
            CipherMismatch,
            [EnumMember(Value = "CKN_MISMATCH")]
            CknMismatch,
            [EnumMember(Value = "CAK_MISMATCH")]
            CakMismatch
        };

        /// <value>
        /// Encryption status of this cross connect.
        /// <br/>
        /// Possible values:
        /// * **UP:** Traffic is encrypted over this cross-connect
        /// * **DOWN:** Traffic is not encrypted over this cross-connect
        /// * **CIPHER_MISMATCH:** The MACsec encryption cipher doesn't match the cipher on the CPE
        /// * **CKN_MISMATCH:** The MACsec Connectivity association Key Name (CKN) doesn't match the CKN on the CPE
        /// * **CAK_MISMATCH:** The MACsec Connectivity Association Key (CAK) doesn't match the CAK on the CPE
        /// 
        /// </value>
        [JsonProperty(PropertyName = "encryptionStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EncryptionStatusEnum> EncryptionStatus { get; set; }
        
        /// <value>
        /// The light levels of the cross-connect (in dBm).
        /// <br/>
        /// Example: [14.0, -14.0, 2.1, -10.1]
        /// </value>
        [JsonProperty(PropertyName = "lightLevelsInDBm")]
        public System.Collections.Generic.List<float> LightLevelsInDBm { get; set; }
        
    }
}
