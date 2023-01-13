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


namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// Monthly patch details.
    /// </summary>
    public class PatchAction : Action
    {
                ///
        /// <value>
        /// A string that describeds whether the change is applied hot or cold
        /// </value>
        ///
        public enum ModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "HOT")]
            Hot,
            [EnumMember(Value = "COLD")]
            Cold
        };

        /// <value>
        /// A string that describeds whether the change is applied hot or cold
        /// </value>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ModeEnum> Mode { get; set; }
                ///
        /// <value>
        /// patch artifact category
        /// </value>
        ///
        public enum CategoryEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MONTHLY")]
            Monthly,
            [EnumMember(Value = "WEEKLY")]
            Weekly,
            [EnumMember(Value = "ONEOFF")]
            Oneoff
        };

        /// <value>
        /// patch artifact category
        /// </value>
        [JsonProperty(PropertyName = "category")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CategoryEnum> Category { get; set; }
        
        /// <value>
        /// patch bundle name
        /// </value>
        [JsonProperty(PropertyName = "artifact")]
        public string Artifact { get; set; }
        
        [JsonProperty(PropertyName = "actionType")]
        private readonly string actionType = "PATCH";
    }
}
