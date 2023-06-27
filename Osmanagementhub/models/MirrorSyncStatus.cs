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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Status summary of all repos
    /// </summary>
    public class MirrorSyncStatus 
    {
        
        /// <value>
        /// Total of mirrors in 'failed' state
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Unsynced is required.")]
        [JsonProperty(PropertyName = "unsynced")]
        public System.Nullable<int> Unsynced { get; set; }
        
        /// <value>
        /// Total of mirrors in 'queued' state
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Queued is required.")]
        [JsonProperty(PropertyName = "queued")]
        public System.Nullable<int> Queued { get; set; }
        
        /// <value>
        /// Total of mirrors in 'syncing' state
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Syncing is required.")]
        [JsonProperty(PropertyName = "syncing")]
        public System.Nullable<int> Syncing { get; set; }
        
        /// <value>
        /// Total of mirrors in 'synced' state
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Synced is required.")]
        [JsonProperty(PropertyName = "synced")]
        public System.Nullable<int> Synced { get; set; }
        
        /// <value>
        /// Total of mirrors in 'failed' state
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Failed is required.")]
        [JsonProperty(PropertyName = "failed")]
        public System.Nullable<int> Failed { get; set; }
        
    }
}
