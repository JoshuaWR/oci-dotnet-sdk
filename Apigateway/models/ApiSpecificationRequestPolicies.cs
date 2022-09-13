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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Global behavior applied to all requests received by the API.
    /// </summary>
    public class ApiSpecificationRequestPolicies 
    {
        
        [JsonProperty(PropertyName = "authentication")]
        public AuthenticationPolicy Authentication { get; set; }
        
        [JsonProperty(PropertyName = "rateLimiting")]
        public RateLimitingPolicy RateLimiting { get; set; }
        
        [JsonProperty(PropertyName = "cors")]
        public CorsPolicy Cors { get; set; }
        
        [JsonProperty(PropertyName = "mutualTls")]
        public MutualTlsDetails MutualTls { get; set; }
        
        [JsonProperty(PropertyName = "usagePlans")]
        public UsagePlansPolicy UsagePlans { get; set; }
        
        [JsonProperty(PropertyName = "dynamicAuthentication")]
        public DynamicAuthenticationPolicy DynamicAuthentication { get; set; }
        
    }
}
