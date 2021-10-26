/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// Details for the Oracle Object storage data asset type.
    /// </summary>
    public class DataAssetFromObjectStorageDetails : DataAsset
    {
        
        /// <value>
        /// The Oracle Object storage Region ie. us-ashburn-1
        /// </value>
        [JsonProperty(PropertyName = "ociRegion")]
        public string OciRegion { get; set; }
        
        /// <value>
        /// The Oracle Object storage URL.
        /// </value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        /// <value>
        /// The OCI tenancy OCID.
        /// </value>
        [JsonProperty(PropertyName = "tenancyId")]
        public string TenancyId { get; set; }
        
        /// <value>
        /// The namespace for the specified Oracle Object storage resource. You can find the namespace under Object Storage Settings in the Console.
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        [JsonProperty(PropertyName = "defaultConnection")]
        public ConnectionFromObjectStorageDetails DefaultConnection { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "ORACLE_OBJECT_STORAGE_DATA_ASSET";
    }
}
