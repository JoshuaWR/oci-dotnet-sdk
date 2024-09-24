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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Indicates that the selection is a scimQuery.
    /// 
    /// </summary>
    public class ScimQuerySelectionMode : SelectionDetails
    {
        
        /// <value>
        /// The scimQuery query parameter accepts filter expressions that use the syntax described in Section 3.2.2.2
        /// of the System for Cross-Domain Identity Management (SCIM) specification, which is available
        /// at [RFC3339](https://tools.ietf.org/html/draft-ietf-scim-api-12). In SCIM filtering expressions,
        /// text, date, and time values must be enclosed in quotation marks, with date and time values using ISO-8601 format.
        /// (Numeric and boolean values should not be quoted.)
        /// <br/>
        /// **Example: ** query=(dbUserName eq &quot;PAY_APP&quot;)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScimQuery is required.")]
        [JsonProperty(PropertyName = "scimQuery")]
        public string ScimQuery { get; set; }
        
        [JsonProperty(PropertyName = "selectionMode")]
        private readonly string selectionMode = "SCIM_QUERY";
    }
}
