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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// A single configuration applied to a detector
    /// </summary>
    public class DetectorConfiguration 
    {
        
        /// <value>
        /// Unique name of the configuration
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConfigKey is required.")]
        [JsonProperty(PropertyName = "configKey")]
        public string ConfigKey { get; set; }
        
        /// <value>
        /// configuration name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// configuration value
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// configuration data type
        /// </value>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }
        
        /// <value>
        /// List of configuration values
        /// </value>
        [JsonProperty(PropertyName = "values")]
        public System.Collections.Generic.List<ConfigValue> Values { get; set; }
        
    }
}
