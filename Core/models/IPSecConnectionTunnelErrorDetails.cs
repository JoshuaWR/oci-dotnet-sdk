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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Details for an error on an IPSec tunnel.
    /// </summary>
    public class IPSecConnectionTunnelErrorDetails 
    {
        
        /// <value>
        /// Unique ID generated for each error report.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Unique code describes the error type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ErrorCode is required.")]
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }
        
        /// <value>
        /// A detailed description of the error.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ErrorDescription is required.")]
        [JsonProperty(PropertyName = "errorDescription")]
        public string ErrorDescription { get; set; }
        
        /// <value>
        /// Resolution for the error.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Solution is required.")]
        [JsonProperty(PropertyName = "solution")]
        public string Solution { get; set; }
        
        /// <value>
        /// Link to more Oracle resources or relevant documentation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OciResourcesLink is required.")]
        [JsonProperty(PropertyName = "ociResourcesLink")]
        public string OciResourcesLink { get; set; }
        
        /// <value>
        /// Timestamp when the error occurred.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Timestamp is required.")]
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
    }
}
