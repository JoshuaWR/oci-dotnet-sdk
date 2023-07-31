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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// An endpoint used to fetch logs.
    /// </summary>
    public class LogEndpoint 
    {
        
        /// <value>
        /// The endpoint name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The endpoint description.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The endpoint model.
        /// </value>
        [JsonProperty(PropertyName = "model")]
        public string Model { get; set; }
        
        /// <value>
        /// The endpoint unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "endpointId")]
        public System.Nullable<long> EndpointId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Request is required.")]
        [JsonProperty(PropertyName = "request")]
        public EndpointRequest Request { get; set; }
        
        [JsonProperty(PropertyName = "response")]
        public EndpointResponse Response { get; set; }
        
        [JsonProperty(PropertyName = "credentials")]
        public EndpointCredentials Credentials { get; set; }
        
        [JsonProperty(PropertyName = "proxy")]
        public EndpointProxy Proxy { get; set; }
        
        /// <value>
        /// A flag indicating whether or not the endpoint is enabled for log collection.
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// The system flag. A value of false denotes a custom, or user
        /// defined endpoint. A value of true denotes an Oracle defined endpoint.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }
        
        /// <value>
        /// A list of endpoint properties.
        /// </value>
        [JsonProperty(PropertyName = "endpointProperties")]
        public System.Collections.Generic.List<LogAnalyticsProperty> EndpointProperties { get; set; }
        
    }
}
