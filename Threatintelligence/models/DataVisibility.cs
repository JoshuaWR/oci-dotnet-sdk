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


namespace Oci.ThreatintelligenceService.Models
{
    /// <summary>
    /// The visibility level of attribution data, including its [Traffic Light Protocol (TLP)](https://www.cisa.gov/tlp) color.
    /// </summary>
    public class DataVisibility 
    {
        
        /// <value>
        /// The name of the visibility level.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The Traffic Light Protocol (TLP) color of the visibility level.
        /// </value>
        ///
        public enum TlpNameEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "TLP_INTERNAL_AUDIT")]
            TlpInternalAudit,
            [EnumMember(Value = "TLP_WHITE")]
            TlpWhite,
            [EnumMember(Value = "TLP_GREEN")]
            TlpGreen,
            [EnumMember(Value = "TLP_AMBER")]
            TlpAmber,
            [EnumMember(Value = "TLP_RED")]
            TlpRed
        };

        /// <value>
        /// The Traffic Light Protocol (TLP) color of the visibility level.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TlpName is required.")]
        [JsonProperty(PropertyName = "tlpName")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TlpNameEnum> TlpName { get; set; }
        
    }
}
