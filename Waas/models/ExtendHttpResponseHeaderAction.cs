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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// An object that represents the action of adding a header field to a response.
    /// If the header with specified value already exists, nothing will be added.
    /// If the header exists with different value, additional header name:value pair will be added.
    /// Comma separated header values are not considered individually (instead as a single value) when adding a new header field.
    /// 
    /// </summary>
    public class ExtendHttpResponseHeaderAction : HeaderManipulationAction
    {
        
        /// <value>
        /// A header field name that conforms to RFC 7230.
        /// <br/>
        /// Example: example_header_name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Header is required.")]
        [JsonProperty(PropertyName = "header")]
        public string Header { get; set; }
        
        /// <value>
        /// A header field value that conforms to RFC 7230.
        /// <br/>
        /// Example: example_value
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        [JsonProperty(PropertyName = "action")]
        private readonly string action = "EXTEND_HTTP_RESPONSE_HEADER";
    }
}
