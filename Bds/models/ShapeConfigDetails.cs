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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// The shape configuration requested for the node.
    /// </summary>
    public class ShapeConfigDetails 
    {
        
        /// <value>
        /// The total number of OCPUs available to the node.
        /// </value>
        [JsonProperty(PropertyName = "ocpus")]
        public System.Nullable<int> Ocpus { get; set; }
        
        /// <value>
        /// The total amount of memory available to the node, in gigabytes.
        /// </value>
        [JsonProperty(PropertyName = "memoryInGBs")]
        public System.Nullable<int> MemoryInGBs { get; set; }
        
        /// <value>
        /// The number of NVMe drives to be used for storage. A single drive has 6.8 TB available.
        /// </value>
        [JsonProperty(PropertyName = "nvmes")]
        public System.Nullable<int> Nvmes { get; set; }
        
    }
}
