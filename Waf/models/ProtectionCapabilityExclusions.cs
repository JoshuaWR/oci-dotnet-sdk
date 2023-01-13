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


namespace Oci.WafService.Models
{
    /// <summary>
    /// Identifies specific HTTP message parameters to exclude from inspection by a protection capability.
    /// 
    /// </summary>
    public class ProtectionCapabilityExclusions 
    {
        
        /// <value>
        /// List of HTTP request cookie values (by cookie name) to exclude from inspecting.
        /// Example: If we have cookie 'cookieName=cookieValue' and requestCookies=['cookieName'], both 'cookieName' and 'cookieValue' will not be inspected.
        /// </value>
        [JsonProperty(PropertyName = "requestCookies")]
        public System.Collections.Generic.List<string> RequestCookies { get; set; }
        
        /// <value>
        /// List of URL query parameter values from form-urlencoded XML, JSON, AMP, or POST payloads to exclude from inspecting.
        /// Example: If we have query parameter 'argumentName=argumentValue' and args=['argumentName'], both 'argumentName' and 'argumentValue' will not be inspected.
        /// </value>
        [JsonProperty(PropertyName = "args")]
        public System.Collections.Generic.List<string> Args { get; set; }
        
    }
}
