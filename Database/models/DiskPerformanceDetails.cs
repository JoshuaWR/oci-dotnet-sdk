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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Representation of disk performance detail parameters.
    /// 
    /// </summary>
    public class DiskPerformanceDetails 
    {
        
        /// <value>
        /// Disk IOPS in thousands.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DiskIops is required.")]
        [JsonProperty(PropertyName = "diskIops")]
        public System.Nullable<float> DiskIops { get; set; }
        
        /// <value>
        /// Disk Throughput in Mbps.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DiskThroughputInMbps is required.")]
        [JsonProperty(PropertyName = "diskThroughputInMbps")]
        public System.Nullable<float> DiskThroughputInMbps { get; set; }
        
    }
}
