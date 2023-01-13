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
    /// Summary details for the Amazon s3 data asset type.
    /// </summary>
    public class DataAssetSummaryFromAmazonS3 : DataAssetSummary
    {
        
        /// <value>
        /// The region for Amazon s3
        /// </value>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        [JsonProperty(PropertyName = "defaultConnection")]
        public ConnectionSummaryFromAmazonS3 DefaultConnection { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "AMAZON_S3_DATA_ASSET";
    }
}
