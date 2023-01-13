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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// The essential properties to identify a Java Runtime.
    /// </summary>
    public class JavaRuntimeId 
    {
        
        /// <value>
        /// The version of the Java Runtime.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The vendor of the Java Runtime.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Vendor is required.")]
        [JsonProperty(PropertyName = "vendor")]
        public string Vendor { get; set; }
        
        /// <value>
        /// The distribution of a Java Runtime is the name of the lineage of product to which it belongs, for example _Java(TM) SE Runtime Environment_.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Distribution is required.")]
        [JsonProperty(PropertyName = "distribution")]
        public string Distribution { get; set; }
        
        /// <value>
        /// The unique identifier for a Java Runtime.
        /// </value>
        [JsonProperty(PropertyName = "jreKey")]
        public string JreKey { get; set; }
        
    }
}
