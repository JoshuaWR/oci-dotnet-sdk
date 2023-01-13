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


namespace Oci.AivisionService.Models
{
    /// <summary>
    /// The document incorporated in the request payload.
    /// </summary>
    public class InlineDocumentDetails : DocumentDetails
    {
        
        /// <value>
        /// Raw document data.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Data is required.")]
        [JsonProperty(PropertyName = "data")]
        public System.Byte[] Data { get; set; }
        
        [JsonProperty(PropertyName = "source")]
        private readonly string source = "INLINE";
    }
}
