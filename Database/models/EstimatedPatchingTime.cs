/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The estimated total time required in minutes for all patching operations (database server, storage server, and network switch patching).
    /// 
    /// </summary>
    public class EstimatedPatchingTime 
    {
        
        /// <value>
        /// The estimated total time required in minutes for all patching operations.
        /// </value>
        [JsonProperty(PropertyName = "totalEstimatedPatchingTime")]
        public System.Nullable<int> TotalEstimatedPatchingTime { get; set; }
        
        /// <value>
        /// The estimated time required in minutes for database server patching.
        /// </value>
        [JsonProperty(PropertyName = "estimatedDbServerPatchingTime")]
        public System.Nullable<int> EstimatedDbServerPatchingTime { get; set; }
        
        /// <value>
        /// The estimated time required in minutes for storage server patching.
        /// </value>
        [JsonProperty(PropertyName = "estimatedStorageServerPatchingTime")]
        public System.Nullable<int> EstimatedStorageServerPatchingTime { get; set; }
        
        /// <value>
        /// The estimated time required in minutes for network switch patching.
        /// </value>
        [JsonProperty(PropertyName = "estimatedNetworkSwitchesPatchingTime")]
        public System.Nullable<int> EstimatedNetworkSwitchesPatchingTime { get; set; }
        
    }
}