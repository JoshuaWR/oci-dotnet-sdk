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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// The health checker's configuration details.
    /// </summary>
    public class UpdateHealthCheckerDetails 
    {
        
        /// <value>
        /// The protocol the health check must use; either HTTP or TCP.
        /// <br/>
        /// Example: HTTP
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }
        
        /// <value>
        /// The path against which to run the health check.
        /// <br/>
        /// Example: /healthcheck
        /// </value>
        [JsonProperty(PropertyName = "urlPath")]
        public string UrlPath { get; set; }
        
        /// <value>
        /// The backend server port against which to run the health check.
        /// <br/>
        /// Example: 8080
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The status code a healthy backend server should return.
        /// <br/>
        /// Example: 200
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReturnCode is required.")]
        [JsonProperty(PropertyName = "returnCode")]
        public System.Nullable<int> ReturnCode { get; set; }
        
        /// <value>
        /// The number of retries to attempt before a backend server is considered \"unhealthy\". This number also applies
        /// when recovering a server to the \"healthy\" state.
        /// <br/>
        /// Example: 3
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Retries is required.")]
        [JsonProperty(PropertyName = "retries")]
        public System.Nullable<int> Retries { get; set; }
        
        /// <value>
        /// The maximum time, in milliseconds, to wait for a reply to a health check. A health check is successful only if a reply
        /// returns within this timeout period.
        /// <br/>
        /// Example: 3000
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeoutInMillis is required.")]
        [JsonProperty(PropertyName = "timeoutInMillis")]
        public System.Nullable<int> TimeoutInMillis { get; set; }
        
        /// <value>
        /// The interval between health checks, in milliseconds.
        /// <br/>
        /// Example: 10000
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IntervalInMillis is required.")]
        [JsonProperty(PropertyName = "intervalInMillis")]
        public System.Nullable<int> IntervalInMillis { get; set; }
        
        /// <value>
        /// A regular expression for parsing the response body from the backend server.
        /// <br/>
        /// Example: ^((?!false).|\\s)*$
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResponseBodyRegex is required.")]
        [JsonProperty(PropertyName = "responseBodyRegex")]
        public string ResponseBodyRegex { get; set; }
        
    }
}
