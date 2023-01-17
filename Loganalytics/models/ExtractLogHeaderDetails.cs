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
    /// log header values
    /// </summary>
    public class ExtractLogHeaderDetails 
    {
        
        /// <value>
        /// The log key.
        /// </value>
        [JsonProperty(PropertyName = "logKey")]
        public string LogKey { get; set; }
        
        /// <value>
        /// The log header values.
        /// </value>
        [JsonProperty(PropertyName = "headerValues")]
        public System.Collections.Generic.List<string> HeaderValues { get; set; }
        
    }
}
