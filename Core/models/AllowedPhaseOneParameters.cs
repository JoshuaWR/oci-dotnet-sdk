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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Phase One Parameters
    /// </summary>
    public class AllowedPhaseOneParameters 
    {
        
        /// <value>
        /// Phase One Encryption Algorithms
        /// </value>
        [JsonProperty(PropertyName = "encryptionAlgorithms")]
        public System.Collections.Generic.List<string> EncryptionAlgorithms { get; set; }
        
        /// <value>
        /// Phase One Authentication Algorithms
        /// </value>
        [JsonProperty(PropertyName = "authenticationAlgorithms")]
        public System.Collections.Generic.List<string> AuthenticationAlgorithms { get; set; }
        
        /// <value>
        /// DH Groups
        /// </value>
        [JsonProperty(PropertyName = "dhGroups")]
        public System.Collections.Generic.List<string> DhGroups { get; set; }
        
    }
}
