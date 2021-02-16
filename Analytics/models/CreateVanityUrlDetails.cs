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


namespace Oci.AnalyticsService.Models
{
    /// <summary>
    /// Input payload to create a vanity url.
    /// 
    /// </summary>
    public class CreateVanityUrlDetails 
    {
        
        /// <value>
        /// Optional description.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// List of fully qualified hostnames supported by this vanity URL definition (max of 3).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Hosts is required.")]
        [JsonProperty(PropertyName = "hosts")]
        public System.Collections.Generic.List<string> Hosts { get; set; }
        
        /// <value>
        /// Passphrase for the PEM Private key (if any).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "passphrase")]
        public string Passphrase { get; set; }
        
        /// <value>
        /// PEM Private key for HTTPS connections.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrivateKey is required.")]
        [JsonProperty(PropertyName = "privateKey")]
        public string PrivateKey { get; set; }
        
        /// <value>
        /// PEM certificate for HTTPS connections.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PublicCertificate is required.")]
        [JsonProperty(PropertyName = "publicCertificate")]
        public string PublicCertificate { get; set; }
        
        /// <value>
        /// PEM CA certificate(s) for HTTPS connections. This may include multiple PEM certificates.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CaCertificate is required.")]
        [JsonProperty(PropertyName = "caCertificate")]
        public string CaCertificate { get; set; }
        
    }
}