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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// UsageStatusItem
    /// </summary>
    public class UsageStatusItem 
    {
        
        /// <value>
        /// The field data type.
        /// </value>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }
        
        /// <value>
        /// A flag indicating whether or not the field is multi-valued.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isMultiValued")]
        public System.Nullable<bool> IsMultiValued { get; set; }
        
        /// <value>
        /// The current usage of the field.
        /// </value>
        [JsonProperty(PropertyName = "currentUsage")]
        public System.Nullable<long> CurrentUsage { get; set; }
        
        /// <value>
        /// The maximum availability of the field.
        /// </value>
        [JsonProperty(PropertyName = "maxAvailable")]
        public System.Nullable<int> MaxAvailable { get; set; }
        
    }
}
