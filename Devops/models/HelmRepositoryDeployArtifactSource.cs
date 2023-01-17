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
    /// Specifies Helm chart source details.
    /// </summary>
    public class HelmRepositoryDeployArtifactSource : DeployArtifactSource
    {
        
        /// <value>
        /// The URL of an OCIR repository.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ChartUrl is required.")]
        [JsonProperty(PropertyName = "chartUrl")]
        public string ChartUrl { get; set; }
        
        /// <value>
        /// Users can set this as a placeholder value that refers to a pipeline parameter, for example, ${appVersion}.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeployArtifactVersion is required.")]
        [JsonProperty(PropertyName = "deployArtifactVersion")]
        public string DeployArtifactVersion { get; set; }
        
        [JsonProperty(PropertyName = "deployArtifactSourceType")]
        private readonly string deployArtifactSourceType = "HELM_CHART";
    }
}
