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
    /// The Exadata storage server grid.
    /// </summary>
    public class ExternalStorageGridDiscoverySummary : EntityDiscovered
    {
        
        /// <value>
        /// The total number of the storage servers discovered.
        /// </value>
        [JsonProperty(PropertyName = "countOfStorageServersDiscovered")]
        public System.Nullable<int> CountOfStorageServersDiscovered { get; set; }
        
        [JsonProperty(PropertyName = "entityType")]
        private readonly string entityType = "STORAGE_GRID_DISCOVER_SUMMARY";
    }
}