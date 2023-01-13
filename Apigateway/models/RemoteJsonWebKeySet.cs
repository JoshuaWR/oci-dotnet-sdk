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
    /// A set of public keys that is retrieved at run-time from a remote location
    /// to verify the JWT signature. The set should only contain JWK-formatted
    /// keys.
    /// 
    /// </summary>
    public class RemoteJsonWebKeySet : PublicKeySet
    {
        
        /// <value>
        /// The uri from which to retrieve the key. It must be accessible
        /// without authentication.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Uri is required.")]
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
        /// <value>
        /// Defines whether or not to uphold SSL verification.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSslVerifyDisabled")]
        public System.Nullable<bool> IsSslVerifyDisabled { get; set; }
        
        /// <value>
        /// The duration for which the JWKS should be cached before it is
        /// fetched again.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxCacheDurationInHours")]
        public System.Nullable<int> MaxCacheDurationInHours { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "REMOTE_JWKS";
    }
}
