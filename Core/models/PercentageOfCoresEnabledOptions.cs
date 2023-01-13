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
    /// Configuration options for the percentage of cores enabled.
    /// 
    /// </summary>
    public class PercentageOfCoresEnabledOptions 
    {
        
        /// <value>
        /// The minimum allowed percentage of cores enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "min")]
        public System.Nullable<int> Min { get; set; }
        
        /// <value>
        /// The maximum allowed percentage of cores enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "max")]
        public System.Nullable<int> Max { get; set; }
        
        /// <value>
        /// The default percentage of cores enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "defaultValue")]
        public System.Nullable<int> DefaultValue { get; set; }
        
    }
}
