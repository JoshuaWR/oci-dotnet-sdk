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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The summary of an external ASM disk group.
    /// </summary>
    public class ExternalAsmDiskGroupSummary 
    {
        
        /// <value>
        /// The name of the ASM disk group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The number of ASM instances that have the disk group in mounted state.
        /// </value>
        [JsonProperty(PropertyName = "mountingInstanceCount")]
        public System.Nullable<int> MountingInstanceCount { get; set; }
        
        /// <value>
        /// The number of ASM instances that have the disk group in dismounted state.
        /// </value>
        [JsonProperty(PropertyName = "dismountingInstanceCount")]
        public System.Nullable<int> DismountingInstanceCount { get; set; }
                ///
        /// <value>
        /// The redundancy type of the disk group.
        /// </value>
        ///
        public enum RedundancyTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EXTEND")]
            Extend,
            [EnumMember(Value = "EXTERN")]
            Extern,
            [EnumMember(Value = "FLEX")]
            Flex,
            [EnumMember(Value = "HIGH")]
            High,
            [EnumMember(Value = "NORMAL")]
            Normal
        };

        /// <value>
        /// The redundancy type of the disk group.
        /// </value>
        [JsonProperty(PropertyName = "redundancyType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RedundancyTypeEnum> RedundancyType { get; set; }
        
        /// <value>
        /// Indicates whether the disk group is a sparse disk group or not.
        /// </value>
        [JsonProperty(PropertyName = "isSparse")]
        public System.Nullable<bool> IsSparse { get; set; }
        
        /// <value>
        /// The unique names of the databases using the disk group.
        /// </value>
        [JsonProperty(PropertyName = "databases")]
        public System.Collections.Generic.List<string> Databases { get; set; }
        
        /// <value>
        /// The total capacity of the disk group (in megabytes).
        /// </value>
        [JsonProperty(PropertyName = "totalSizeInMBs")]
        public System.Nullable<long> TotalSizeInMBs { get; set; }
        
        /// <value>
        /// The used capacity of the disk group (in megabytes).
        /// </value>
        [JsonProperty(PropertyName = "usedSizeInMBs")]
        public System.Nullable<long> UsedSizeInMBs { get; set; }
        
        /// <value>
        /// The percentage of used space in the disk group.
        /// </value>
        [JsonProperty(PropertyName = "usedPercent")]
        public System.Nullable<float> UsedPercent { get; set; }
        
    }
}