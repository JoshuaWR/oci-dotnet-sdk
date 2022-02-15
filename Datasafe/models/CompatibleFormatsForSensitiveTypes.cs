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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The list of compatible masking formats grouped by generic sensitive types.
    /// </summary>
    public class CompatibleFormatsForSensitiveTypes 
    {
        
        /// <value>
        /// An array of library masking formats compatible with the existing sensitive types.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FormatsForSensitiveType is required.")]
        [JsonProperty(PropertyName = "formatsForSensitiveType")]
        public System.Collections.Generic.List<FormatsForSensitiveType> FormatsForSensitiveType { get; set; }
        
    }
}