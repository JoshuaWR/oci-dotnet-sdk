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


namespace Oci.OspgatewayService.Models
{
    /// <summary>
    /// Tax type rule information
    /// </summary>
    public class TaxTypeRule 
    {
        
        /// <value>
        /// Tax type rule fields
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Fields is required.")]
        [JsonProperty(PropertyName = "fields")]
        public System.Collections.Generic.List<Field> Fields { get; set; }
        
    }
}
