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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// The issuer of the certificate.
    /// </summary>
    public class CertificateIssuerName 
    {
        
        /// <value>
        /// ISO 3166-1 alpha-2 code of the country where the organization is located. For a list of codes, see [ISO's website](https://www.iso.org/obp/ui/#search/code/).
        /// </value>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        
        /// <value>
        /// The province where the organization is located.
        /// </value>
        [JsonProperty(PropertyName = "stateProvince")]
        public string StateProvince { get; set; }
        
        /// <value>
        /// The city in which the organization is located.
        /// </value>
        [JsonProperty(PropertyName = "locality")]
        public string Locality { get; set; }
        
        /// <value>
        /// The organization name.
        /// </value>
        [JsonProperty(PropertyName = "organization")]
        public string Organization { get; set; }
        
        /// <value>
        /// The field to differentiate between divisions within an organization.
        /// </value>
        [JsonProperty(PropertyName = "organizationalUnit")]
        public string OrganizationalUnit { get; set; }
        
        /// <value>
        /// The Certificate Authority (CA) name.
        /// </value>
        [JsonProperty(PropertyName = "commonName")]
        public string CommonName { get; set; }
        
        /// <value>
        /// The email address of the server's administrator.
        /// </value>
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }
        
    }
}
