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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// When dynamically routing and dynamically authenticating requests, the route or authentication server associated with a selection key containing a wildcard is used if the context variable in an incoming request matches that key.
    /// </summary>
    public class WildcardSelectionKey : DynamicSelectionKey
    {
        
        /// <value>
        /// A selection key string containing a wildcard to match with the context variable in an incoming request. If the context variable matches the string, the request is sent to the route or authentication server associated with the selection key. Valid wildcards are '*' (zero or more characters) and '+' (one or more characters). The string can only contain one wildcard, and the wildcard must be at the start or the end of the string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Expression is required.")]
        [JsonProperty(PropertyName = "expression")]
        public string Expression { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "WILDCARD";
    }
}
