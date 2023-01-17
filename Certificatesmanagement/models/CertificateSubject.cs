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
    /// The subject of the certificate, which is a distinguished name that identifies the entity that owns the public key in the certificate.
    /// 
    /// </summary>
    public class CertificateSubject 
    {
        
        /// <value>
        /// Common name or fully-qualified domain name (RDN CN).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CommonName is required.")]
        [JsonProperty(PropertyName = "commonName")]
        public string CommonName { get; set; }
        
        /// <value>
        /// Country name (RDN C).
        /// </value>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        
        /// <value>
        /// Domain component (RDN DC).
        /// </value>
        [JsonProperty(PropertyName = "domainComponent")]
        public string DomainComponent { get; set; }
        
        /// <value>
        /// Distinguished name qualifier(RDN DNQ).
        /// </value>
        [JsonProperty(PropertyName = "distinguishedNameQualifier")]
        public string DistinguishedNameQualifier { get; set; }
        
        /// <value>
        /// Personal generational qualifier (for example, Sr., Jr. 3rd, or IV).
        /// </value>
        [JsonProperty(PropertyName = "generationQualifier")]
        public string GenerationQualifier { get; set; }
        
        /// <value>
        /// Personal given name (RDN G or GN).
        /// </value>
        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }
        
        /// <value>
        /// Personal initials.
        /// </value>
        [JsonProperty(PropertyName = "initials")]
        public string Initials { get; set; }
        
        /// <value>
        /// Locality (RDN L).
        /// </value>
        [JsonProperty(PropertyName = "localityName")]
        public string LocalityName { get; set; }
        
        /// <value>
        /// Organization (RDN O).
        /// </value>
        [JsonProperty(PropertyName = "organization")]
        public string Organization { get; set; }
        
        /// <value>
        /// Organizational unit (RDN OU).
        /// </value>
        [JsonProperty(PropertyName = "organizationalUnit")]
        public string OrganizationalUnit { get; set; }
        
        /// <value>
        /// Subject pseudonym.
        /// </value>
        [JsonProperty(PropertyName = "pseudonym")]
        public string Pseudonym { get; set; }
        
        /// <value>
        /// Unique subject identifier, which is not the same as the certificate serial number (RDN SERIALNUMBER).
        /// </value>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }
        
        /// <value>
        /// State or province name (RDN ST or S).
        /// </value>
        [JsonProperty(PropertyName = "stateOrProvinceName")]
        public string StateOrProvinceName { get; set; }
        
        /// <value>
        /// Street address (RDN STREET).
        /// </value>
        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }
        
        /// <value>
        /// Personal surname (RDN SN).
        /// </value>
        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }
        
        /// <value>
        /// Title (RDN T or TITLE).
        /// </value>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        
        /// <value>
        /// User ID (RDN UID).
        /// </value>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
        
    }
}
