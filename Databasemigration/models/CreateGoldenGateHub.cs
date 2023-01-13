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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Details about Oracle GoldenGate Microservices. Required for online logical migration.
    /// 
    /// </summary>
    public class CreateGoldenGateHub 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RestAdminCredentials is required.")]
        [JsonProperty(PropertyName = "restAdminCredentials")]
        public CreateAdminCredentials RestAdminCredentials { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceDbAdminCredentials is required.")]
        [JsonProperty(PropertyName = "sourceDbAdminCredentials")]
        public CreateAdminCredentials SourceDbAdminCredentials { get; set; }
        
        [JsonProperty(PropertyName = "sourceContainerDbAdminCredentials")]
        public CreateAdminCredentials SourceContainerDbAdminCredentials { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetDbAdminCredentials is required.")]
        [JsonProperty(PropertyName = "targetDbAdminCredentials")]
        public CreateAdminCredentials TargetDbAdminCredentials { get; set; }
        
        /// <value>
        /// Oracle GoldenGate Microservices hub's REST endpoint.
        /// Refer to https://docs.oracle.com/en/middleware/goldengate/core/19.1/securing/network.html#GUID-A709DA55-111D-455E-8942-C9BDD1E38CAA
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Url is required.")]
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        /// <value>
        /// Name of GoldenGate Microservices deployment to operate on source database
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceMicroservicesDeploymentName is required.")]
        [JsonProperty(PropertyName = "sourceMicroservicesDeploymentName")]
        public string SourceMicroservicesDeploymentName { get; set; }
        
        /// <value>
        /// Name of GoldenGate Microservices deployment to operate on target database
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetMicroservicesDeploymentName is required.")]
        [JsonProperty(PropertyName = "targetMicroservicesDeploymentName")]
        public string TargetMicroservicesDeploymentName { get; set; }
        
        /// <value>
        /// OCID of GoldenGate Microservices compute instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "computeId")]
        public string ComputeId { get; set; }
        
    }
}
