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
    /// Details to update the Rest data asset.
    /// </summary>
    public class UpdateDataAssetFromRest : UpdateDataAssetDetails
    {
        
        /// <value>
        /// The base url of the rest server.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BaseUrl is required.")]
        [JsonProperty(PropertyName = "baseUrl")]
        public string BaseUrl { get; set; }
        
        /// <value>
        /// The manifest file content of the rest APIs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManifestFileContent is required.")]
        [JsonProperty(PropertyName = "manifestFileContent")]
        public string ManifestFileContent { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefaultConnection is required.")]
        [JsonProperty(PropertyName = "defaultConnection")]
        public UpdateConnectionDetails DefaultConnection { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "REST_DATA_ASSET";
    }
}
