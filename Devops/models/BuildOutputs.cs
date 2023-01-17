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
    /// Outputs from the build.
    /// </summary>
    public class BuildOutputs 
    {
        
        [JsonProperty(PropertyName = "exportedVariables")]
        public ExportedVariableCollection ExportedVariables { get; set; }
        
        [JsonProperty(PropertyName = "deliveredArtifacts")]
        public DeliveredArtifactCollection DeliveredArtifacts { get; set; }
        
        [JsonProperty(PropertyName = "artifactOverrideParameters")]
        public DeployArtifactOverrideArgumentCollection ArtifactOverrideParameters { get; set; }
        
        [JsonProperty(PropertyName = "vulnerabilityAuditSummaryCollection")]
        public VulnerabilityAuditSummaryCollection VulnerabilityAuditSummaryCollection { get; set; }
        
    }
}
