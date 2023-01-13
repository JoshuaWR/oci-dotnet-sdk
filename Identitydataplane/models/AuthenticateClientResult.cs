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


namespace Oci.IdentitydataplaneService.Models
{
    
    public class AuthenticateClientResult 
    {
        
        /// <value>
        /// The original caller's resolved principal object if the authentication succeeds, null otherwise.
        /// </value>
        [JsonProperty(PropertyName = "principal")]
        public Principal Principal { get; set; }
        
        /// <value>
        /// If the authentication fails for the original caller (not failing authentication of the calling service, in which case we return 401), we return a 200, but with null principal and an error message
        /// </value>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
        
    }
}
