/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// Details of artifact generated via pipeline run
    /// </summary>
    public class GenericArtifacts : StageOutput
    {
        
        /// <value>
        /// Name of artifact.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LocationDetails is required.")]
        [JsonProperty(PropertyName = "locationDetails")]
        public GenericArtifactLocationDetails LocationDetails { get; set; }
        
        [JsonProperty(PropertyName = "outputType")]
        private readonly string outputType = "ARTIFACT";
    }
}