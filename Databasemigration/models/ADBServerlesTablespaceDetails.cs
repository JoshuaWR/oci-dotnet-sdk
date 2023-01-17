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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Migration tablespace settings valid for ADB-D target type using remap feature
    /// 
    /// </summary>
    public class ADBServerlesTablespaceDetails : TargetTypeTablespaceDetails
    {
                ///
        /// <value>
        /// Name of tablespace at target to which the source database tablespace need to be remapped.
        /// 
        /// </value>
        ///
        public enum RemapTargetEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DATA")]
            Data
        };

        /// <value>
        /// Name of tablespace at target to which the source database tablespace need to be remapped.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "remapTarget")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RemapTargetEnum> RemapTarget { get; set; }
        
        [JsonProperty(PropertyName = "targetType")]
        private readonly string targetType = "ADB_S_REMAP";
    }
}
