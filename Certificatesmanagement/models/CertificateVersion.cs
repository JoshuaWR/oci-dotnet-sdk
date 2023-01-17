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


namespace Oci.CertificatesmanagementService.Models
{
    /// <summary>
    /// The details of the certificate version. This object does not contain the certificate contents.
    /// </summary>
    public class CertificateVersion 
    {
        
        /// <value>
        /// The OCID of the certificate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificateId is required.")]
        [JsonProperty(PropertyName = "certificateId")]
        public string CertificateId { get; set; }
        
        /// <value>
        /// A unique certificate identifier used in certificate revocation tracking, formatted as octets.
        /// Example: 03 AC FC FA CC B3 CB 02 B8 F8 DE F5 85 E7 7B FF
        /// </value>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }
        
        /// <value>
        /// A optional property indicating when the certificate version was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2019-04-03T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The version number of the certificate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VersionNumber is required.")]
        [JsonProperty(PropertyName = "versionNumber")]
        public System.Nullable<long> VersionNumber { get; set; }
        
        /// <value>
        /// The version number of the issuing certificate authority (CA).
        /// </value>
        [JsonProperty(PropertyName = "issuerCaVersionNumber")]
        public System.Nullable<long> IssuerCaVersionNumber { get; set; }
        
        /// <value>
        /// The name of the certificate version. When the value is not null, a name is unique across versions of a given certificate.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "versionName")]
        public string VersionName { get; set; }
        
        /// <value>
        /// A list of subject alternative names.
        /// </value>
        [JsonProperty(PropertyName = "subjectAlternativeNames")]
        public System.Collections.Generic.List<CertificateSubjectAlternativeName> SubjectAlternativeNames { get; set; }
        
        /// <value>
        /// An optional property indicating when to delete the certificate version, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2019-04-03T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeOfDeletion")]
        public System.Nullable<System.DateTime> TimeOfDeletion { get; set; }
        
        [JsonProperty(PropertyName = "validity")]
        public Validity Validity { get; set; }
        
        /// <value>
        /// A list of stages of this entity.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Stages is required.")]
        [JsonProperty(PropertyName = "stages")]
        public System.Collections.Generic.List<VersionStage> Stages { get; set; }
        
        [JsonProperty(PropertyName = "revocationStatus")]
        public RevocationStatus RevocationStatus { get; set; }
        
    }
}
