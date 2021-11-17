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


namespace Oci.CertificatesService.Models
{
    /// <summary>
    /// A certificate bundle, including the private key.
    /// </summary>
    public class CertificateBundleWithPrivateKey : CertificateBundle
    {
        
        /// <value>
        /// The private key (in PEM format) for the certificate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrivateKeyPem is required.")]
        [JsonProperty(PropertyName = "privateKeyPem")]
        public string PrivateKeyPem { get; set; }
        
        /// <value>
        /// An optional passphrase for the private key.
        /// </value>
        [JsonProperty(PropertyName = "privateKeyPemPassphrase")]
        public string PrivateKeyPemPassphrase { get; set; }
        
        [JsonProperty(PropertyName = "certificateBundleType")]
        private readonly string certificateBundleType = "CERTIFICATE_CONTENT_WITH_PRIVATE_KEY";
    }
}