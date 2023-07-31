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
    /// The LOG type endpoint configuration. Logs are fetched from the specified endpoint.
    /// For time based incremental collection, specify the START_TIME macro with the desired time format,
    /// Example: {START_TIME:yyMMddHHmmssZ}.For offset based incremental collection, specify the START_OFFSET macro with offset identifier in the API response,
    /// </summary>
    public class LogTypeEndpoint : LogAnalyticsEndpoint
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogEndpoint is required.")]
        [JsonProperty(PropertyName = "logEndpoint")]
        public LogEndpoint LogEndpoint { get; set; }
        
        [JsonProperty(PropertyName = "endpointType")]
        private readonly string endpointType = "LOG";
    }
}
