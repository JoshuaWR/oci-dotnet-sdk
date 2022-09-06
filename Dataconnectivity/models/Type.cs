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


namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// DataAsset and Connection Registry Attributes
    /// </summary>
    public class Type 
    {
        
        /// <value>
        /// The list of attributes of the data asset.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataAssetAttributes is required.")]
        [JsonProperty(PropertyName = "dataAssetAttributes")]
        public System.Collections.Generic.List<Attribute> DataAssetAttributes { get; set; }
        
        /// <value>
        /// Mapping the connectionType as the key to the list of attributes as the value.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectionAttributes is required.")]
        [JsonProperty(PropertyName = "connectionAttributes")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Attribute>> ConnectionAttributes { get; set; }
        
    }
}
