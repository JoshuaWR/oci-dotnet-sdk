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


namespace Oci.RoverService.Models
{
    /// <summary>
    /// The information required to replace a certificate authority details for a roverNode.
    /// </summary>
    public class RoverNodeReplaceCertificateAuthorityDetails 
    {
        
        /// <value>
        /// The certificate authority id.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificateAuthorityId is required.")]
        [JsonProperty(PropertyName = "certificateAuthorityId")]
        public string CertificateAuthorityId { get; set; }
        
        /// <value>
        /// key algorithm for issuing leaf certificate.
        /// </value>
        [JsonProperty(PropertyName = "certKeyAlgorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CertKeyAlgorithm> CertKeyAlgorithm { get; set; }
        
        /// <value>
        /// signature algorithm for issuing leaf certificate.
        /// </value>
        [JsonProperty(PropertyName = "certSignatureAlgorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CertSignatureAlgorithm> CertSignatureAlgorithm { get; set; }
        
    }
}