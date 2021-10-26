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
    /// The details for updating a private root certificate authority (CA).
    /// Note: This operation automatically rotates the private key.
    /// 
    /// </summary>
    public class UpdateRootCaByGeneratingInternallyConfigDetails : UpdateCertificateAuthorityConfigDetails
    {
        
        [JsonProperty(PropertyName = "validity")]
        public Validity Validity { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "ROOT_CA_GENERATED_INTERNALLY";
    }
}
