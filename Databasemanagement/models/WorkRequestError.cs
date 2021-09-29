/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// An error encountered while executing a work request.
    /// </summary>
    public class WorkRequestError 
    {
        
        /// <value>
        /// The identifier of the work request erorr.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WorkRequestId is required.")]
        [JsonProperty(PropertyName = "workRequestId")]
        public string WorkRequestId { get; set; }
        
        /// <value>
        /// A machine-usable code for the error that occured. Error codes are listed on
        /// (https://docs.us-phoenix-1.oraclecloud.com/Content/API/References/apierrors.htm)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Code is required.")]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        
        /// <value>
        /// A human readable description of the issue encountered.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Message is required.")]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// To determine the work request error is retryable or not
        /// </value>
        [JsonProperty(PropertyName = "isRetryable")]
        public System.Nullable<bool> IsRetryable { get; set; }
        
        /// <value>
        /// The time the error occured.
        /// An RFC3339 formatted datetime string. The precision for the time object is milliseconds.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Timestamp is required.")]
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
    }
}