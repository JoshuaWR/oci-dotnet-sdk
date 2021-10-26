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


namespace Oci.CertificatesmanagementService.Models
{
    /// <summary>
    /// The details of the configuration for creating an externally managed certificate which is issued by a private certificate authority (CA).
    /// </summary>
    public class CreateCertificateManagedExternallyIssuedByInternalCaConfigDetails : CreateCertificateConfigDetails
    {
        
        /// <value>
        /// The OCID of the private CA.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IssuerCertificateAuthorityId is required.")]
        [JsonProperty(PropertyName = "issuerCertificateAuthorityId")]
        public string IssuerCertificateAuthorityId { get; set; }
        
        [JsonProperty(PropertyName = "validity")]
        public Validity Validity { get; set; }
        
        /// <value>
        /// The certificate signing request (in PEM format).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CsrPem is required.")]
        [JsonProperty(PropertyName = "csrPem")]
        public string CsrPem { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "MANAGED_EXTERNALLY_ISSUED_BY_INTERNAL_CA";
    }
}
