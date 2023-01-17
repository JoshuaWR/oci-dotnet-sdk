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
    /// Specifies the Instance Group Canary deployment stage.
    /// </summary>
    public class ComputeInstanceGroupCanaryDeployStage : DeployStage
    {
        
        /// <value>
        /// A compute instance group environment OCID for Canary deployment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputeInstanceGroupDeployEnvironmentId is required.")]
        [JsonProperty(PropertyName = "computeInstanceGroupDeployEnvironmentId")]
        public string ComputeInstanceGroupDeployEnvironmentId { get; set; }
        
        /// <value>
        /// The OCID of the artifact that contains the deployment specification.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentSpecDeployArtifactId is required.")]
        [JsonProperty(PropertyName = "deploymentSpecDeployArtifactId")]
        public string DeploymentSpecDeployArtifactId { get; set; }
        
        /// <value>
        /// The list of file artifact OCIDs to deploy.
        /// </value>
        [JsonProperty(PropertyName = "deployArtifactIds")]
        public System.Collections.Generic.List<string> DeployArtifactIds { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RolloutPolicy is required.")]
        [JsonProperty(PropertyName = "rolloutPolicy")]
        public ComputeInstanceGroupRolloutPolicy RolloutPolicy { get; set; }
        
        [JsonProperty(PropertyName = "testLoadBalancerConfig")]
        public LoadBalancerConfig TestLoadBalancerConfig { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProductionLoadBalancerConfig is required.")]
        [JsonProperty(PropertyName = "productionLoadBalancerConfig")]
        public LoadBalancerConfig ProductionLoadBalancerConfig { get; set; }
        
        [JsonProperty(PropertyName = "deployStageType")]
        private readonly string deployStageType = "COMPUTE_INSTANCE_GROUP_CANARY_DEPLOYMENT";
    }
}
