/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// The Resource IDs for which metric extension will be disabled
    /// </summary>
    public class DisableMetricExtensionDetails 
    {
        
        /// <value>
        /// List of Resource IDs [OCIDs]. Currently supports upto 20 resources per request
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceIds is required.")]
        [JsonProperty(PropertyName = "resourceIds")]
        public System.Collections.Generic.List<string> ResourceIds { get; set; }
        
    }
}