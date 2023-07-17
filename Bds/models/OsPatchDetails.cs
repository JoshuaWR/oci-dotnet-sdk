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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// Details of an os patch.
    /// </summary>
    public class OsPatchDetails 
    {
        
        /// <value>
        /// Version of the os patch.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OsPatchVersion is required.")]
        [JsonProperty(PropertyName = "osPatchVersion")]
        public string OsPatchVersion { get; set; }
        
        /// <value>
        /// Minimum BDS version required to install current OS patch.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MinBdsVersion is required.")]
        [JsonProperty(PropertyName = "minBdsVersion")]
        public string MinBdsVersion { get; set; }
        
        /// <value>
        /// Map of major ODH version to minimum ODH version required to install current OS patch. e.g. {ODH0.9: 0.9.1}
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MinCompatibleOdhVersionMap is required.")]
        [JsonProperty(PropertyName = "minCompatibleOdhVersionMap")]
        public System.Collections.Generic.Dictionary<string, string> MinCompatibleOdhVersionMap { get; set; }
        
        /// <value>
        /// List of summaries of individual target packages.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetPackages is required.")]
        [JsonProperty(PropertyName = "targetPackages")]
        public System.Collections.Generic.List<OsPatchPackageSummary> TargetPackages { get; set; }
        
        /// <value>
        /// Released date of the OS patch.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReleaseDate is required.")]
        [JsonProperty(PropertyName = "releaseDate")]
        public System.Nullable<System.DateTime> ReleaseDate { get; set; }
                ///
        /// <value>
        /// Type of a specific os patch.
        /// REGULAR means standard released os patches.
        /// CUSTOM means os patches with some customizations.
        /// EMERGENT means os patches with some emergency fixes that should be prioritized.
        /// 
        /// </value>
        ///
        public enum PatchTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "REGULAR")]
            Regular,
            [EnumMember(Value = "CUSTOM")]
            Custom,
            [EnumMember(Value = "EMERGENT")]
            Emergent
        };

        /// <value>
        /// Type of a specific os patch.
        /// REGULAR means standard released os patches.
        /// CUSTOM means os patches with some customizations.
        /// EMERGENT means os patches with some emergency fixes that should be prioritized.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PatchType is required.")]
        [JsonProperty(PropertyName = "patchType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PatchTypeEnum> PatchType { get; set; }
        
    }
}
