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
    /// Specifies the instance group canary deployment load balancer traffic shift stage.
    /// </summary>
    public class ComputeInstanceGroupCanaryTrafficShiftDeployStage : DeployStage
    {
        
        /// <value>
        /// The OCID of an upstream compute instance group canary deployment stage ID in this pipeline.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputeInstanceGroupCanaryDeployStageId is required.")]
        [JsonProperty(PropertyName = "computeInstanceGroupCanaryDeployStageId")]
        public string ComputeInstanceGroupCanaryDeployStageId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RolloutPolicy is required.")]
        [JsonProperty(PropertyName = "rolloutPolicy")]
        public LoadBalancerTrafficShiftRolloutPolicy RolloutPolicy { get; set; }
        
        [JsonProperty(PropertyName = "deployStageType")]
        private readonly string deployStageType = "COMPUTE_INSTANCE_GROUP_CANARY_TRAFFIC_SHIFT";
    }
}
