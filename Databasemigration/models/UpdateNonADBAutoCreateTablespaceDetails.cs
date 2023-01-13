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
    /// Migration tablespace settings valid for NON-ADB target type using auto create feature.
    /// 
    /// </summary>
    public class UpdateNonADBAutoCreateTablespaceDetails : UpdateTargetTypeTablespaceDetails
    {
        
        /// <value>
        /// True to auto-create tablespace in the target Database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoCreate")]
        public System.Nullable<bool> IsAutoCreate { get; set; }
        
        /// <value>
        /// True set tablespace to big file.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isBigFile")]
        public System.Nullable<bool> IsBigFile { get; set; }
        
        /// <value>
        /// Size of extend in MB. Can only be specified if 'isBigFile' property is set to true.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "extendSizeInMBs")]
        public System.Nullable<int> ExtendSizeInMBs { get; set; }
        
        [JsonProperty(PropertyName = "targetType")]
        private readonly string targetType = "NON_ADB_AUTOCREATE";
    }
}
