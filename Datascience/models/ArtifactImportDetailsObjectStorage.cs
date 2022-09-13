/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Artifact destination details for importing to destination bucket
    /// </summary>
    public class ArtifactImportDetailsObjectStorage : ArtifactImportDetails
    {
        
        /// <value>
        /// The Object Storage namespace used for the request.
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// The name of the bucket. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "destinationBucket")]
        public string DestinationBucket { get; set; }
        
        /// <value>
        /// The name of the object resulting from the copy operation.
        /// </value>
        [JsonProperty(PropertyName = "destinationObjectName")]
        public string DestinationObjectName { get; set; }
        
        /// <value>
        /// Region in which OSS bucket is present
        /// </value>
        [JsonProperty(PropertyName = "destinationRegion")]
        public string DestinationRegion { get; set; }
        
        [JsonProperty(PropertyName = "artifactSourceType")]
        private readonly string artifactSourceType = "ORACLE_OBJECT_STORAGE";
    }
}