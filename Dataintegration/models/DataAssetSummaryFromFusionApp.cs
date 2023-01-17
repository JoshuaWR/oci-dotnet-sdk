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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Summary details for the FUSION_APP data asset type.
    /// </summary>
    public class DataAssetSummaryFromFusionApp : DataAssetSummary
    {
        
        /// <value>
        /// The generic JDBC host name.
        /// </value>
        [JsonProperty(PropertyName = "serviceUrl")]
        public string ServiceUrl { get; set; }
        
        [JsonProperty(PropertyName = "defaultConnection")]
        public ConnectionSummary DefaultConnection { get; set; }
        
        [JsonProperty(PropertyName = "stagingDataAsset")]
        public DataAssetSummaryFromObjectStorage StagingDataAsset { get; set; }
        
        [JsonProperty(PropertyName = "stagingConnection")]
        public ConnectionSummaryFromObjectStorage StagingConnection { get; set; }
        
        [JsonProperty(PropertyName = "bucketSchema")]
        public Schema BucketSchema { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "FUSION_APP_DATA_ASSET";
    }
}
