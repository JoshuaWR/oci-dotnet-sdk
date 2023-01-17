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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Specifies the Container Engine for Kubernetes (OKE) cluster deployment stage.
    /// </summary>
    public class CreateOkeDeployStageDetails : CreateDeployStageDetails
    {
        
        /// <value>
        /// Kubernetes cluster environment OCID for deployment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OkeClusterDeployEnvironmentId is required.")]
        [JsonProperty(PropertyName = "okeClusterDeployEnvironmentId")]
        public string OkeClusterDeployEnvironmentId { get; set; }
        
        /// <value>
        /// List of Kubernetes manifest artifact OCIDs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KubernetesManifestDeployArtifactIds is required.")]
        [JsonProperty(PropertyName = "kubernetesManifestDeployArtifactIds")]
        public System.Collections.Generic.List<string> KubernetesManifestDeployArtifactIds { get; set; }
        
        /// <value>
        /// Default namespace to be used for Kubernetes deployment when not specified in the manifest.
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        [JsonProperty(PropertyName = "rollbackPolicy")]
        public DeployStageRollbackPolicy RollbackPolicy { get; set; }
        
        [JsonProperty(PropertyName = "deployStageType")]
        private readonly string deployStageType = "OKE_DEPLOYMENT";
    }
}
