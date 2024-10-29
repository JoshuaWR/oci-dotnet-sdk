/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Backup operation details of the model.
    /// </summary>
    public class BackupOperationDetails 
    {
        
        /// <value>
        /// The last backup execution time of the model.
        /// </value>
        [JsonProperty(PropertyName = "timeLastBackup")]
        public System.Nullable<System.DateTime> TimeLastBackup { get; set; }
        
        /// <value>
        /// The backup status of the model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupState is required.")]
        [JsonProperty(PropertyName = "backupState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ModelSettingActionState> BackupState { get; set; }
        
        /// <value>
        /// The backup execution status details of the model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupStateDetails is required.")]
        [JsonProperty(PropertyName = "backupStateDetails")]
        public string BackupStateDetails { get; set; }
        
    }
}