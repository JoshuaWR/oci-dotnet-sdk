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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// For a flexible shape, the amount of memory available for instances that use this shape.
    /// <br/>
    /// If this field is null, then this shape has a fixed amount of memory equivalent to `memoryInGBs`.
    /// 
    /// </summary>
    public class ShapeMemoryOptions 
    {
        
        /// <value>
        /// The minimum amount of memory, in gigabytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "minInGBs")]
        public System.Nullable<float> MinInGBs { get; set; }
        
        /// <value>
        /// The maximum amount of memory, in gigabytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxInGBs")]
        public System.Nullable<float> MaxInGBs { get; set; }
        
        /// <value>
        /// The default amount of memory per OCPU available for this shape, in gigabytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "defaultPerOcpuInGBs")]
        public System.Nullable<float> DefaultPerOcpuInGBs { get; set; }
        
        /// <value>
        /// The minimum amount of memory per OCPU available for this shape, in gigabytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "minPerOcpuInGBs")]
        public System.Nullable<float> MinPerOcpuInGBs { get; set; }
        
        /// <value>
        /// The maximum amount of memory per OCPU available for this shape, in gigabytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxPerOcpuInGBs")]
        public System.Nullable<float> MaxPerOcpuInGBs { get; set; }
        
    }
}
