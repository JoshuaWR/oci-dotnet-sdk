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


namespace Oci.DatalabelingService.Models
{
    /// <summary>
    /// File format details used for importing dataset
    /// </summary>
    public class ImportFormat 
    {
                ///
        /// <value>
        /// Name of import format
        /// </value>
        ///
        public enum NameEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "JSONL_CONSOLIDATED")]
            JsonlConsolidated,
            [EnumMember(Value = "JSONL_COMPACT_PLUS_CONTENT")]
            JsonlCompactPlusContent,
            [EnumMember(Value = "CONLL")]
            Conll,
            [EnumMember(Value = "SPACY")]
            Spacy,
            [EnumMember(Value = "COCO")]
            Coco,
            [EnumMember(Value = "YOLO")]
            Yolo,
            [EnumMember(Value = "PASCAL_VOC")]
            PascalVoc
        };

        /// <value>
        /// Name of import format
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NameEnum> Name { get; set; }
                ///
        /// <value>
        /// Version of import format
        /// </value>
        ///
        public enum VersionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "V2003")]
            V2003,
            [EnumMember(Value = "V5")]
            V5
        };

        /// <value>
        /// Version of import format
        /// </value>
        [JsonProperty(PropertyName = "version")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<VersionEnum> Version { get; set; }
        
    }
}