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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The details for configuring the ORDS certificates on Cloud Autonomous VM Cluster
    /// 
    /// </summary>
    public class RotateCloudAutonomousVmClusterOrdsCertsDetails 
    {
                ///
        /// <value>
        /// Specify SYSTEM to use Oracle-managed certificates. Specify BYOC when you want to bring your own certificate.
        /// </value>
        ///
        public enum CertificateGenerationTypeEnum {
            [EnumMember(Value = "SYSTEM")]
            System,
            [EnumMember(Value = "BYOC")]
            Byoc
        };

        /// <value>
        /// Specify SYSTEM to use Oracle-managed certificates. Specify BYOC when you want to bring your own certificate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificateGenerationType is required.")]
        [JsonProperty(PropertyName = "certificateGenerationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CertificateGenerationTypeEnum> CertificateGenerationType { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the certificate to use.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "certificateId")]
        public string CertificateId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the certificate authority.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "certificateAuthorityId")]
        public string CertificateAuthorityId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the certificate bundle.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "caBundleId")]
        public string CaBundleId { get; set; }
        
    }
}
