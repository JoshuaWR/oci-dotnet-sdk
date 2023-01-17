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
    /// Specifies the OCIR details.
    /// </summary>
    public class OcirDeployArtifactSource : DeployArtifactSource
    {
        
        /// <value>
        /// Specifies OCIR image path - optionally include tag.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImageUri is required.")]
        [JsonProperty(PropertyName = "imageUri")]
        public string ImageUri { get; set; }
        
        /// <value>
        /// Specifies image digest for the version of the image.
        /// </value>
        [JsonProperty(PropertyName = "imageDigest")]
        public string ImageDigest { get; set; }
        
        [JsonProperty(PropertyName = "deployArtifactSourceType")]
        private readonly string deployArtifactSourceType = "OCIR";
    }
}
