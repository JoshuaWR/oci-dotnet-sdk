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


namespace Oci.ApmconfigService.Models
{
    /// <summary>
    /// An object that represents configuration options.
    /// </summary>
    public class Options : Config
    {
        
        /// <value>
        /// The name by which a configuration entity is displayed to the end user.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The options are stored here as JSON.
        /// </value>
        [JsonProperty(PropertyName = "options")]
        public System.Object OptionsProp { get; set; }
        
        /// <value>
        /// A string that specifies the group that an OPTIONS item belongs to.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }
        
        /// <value>
        /// An optional string that describes what the options are intended or used for.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "OPTIONS";
    }
}
