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


namespace Oci.DatalabelingService.Models
{
    /// <summary>
    /// Specifies where to output the export in Object Storage.
    /// </summary>
    public class ObjectStorageSnapshotExportDetails : SnapshotExportDetails
    {
        
        /// <value>
        /// Bucket namespace name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// Bucket name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Bucket is required.")]
        [JsonProperty(PropertyName = "bucket")]
        public string Bucket { get; set; }
        
        /// <value>
        /// Object path prefix to put snapshot file(s)
        /// </value>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }
        
        [JsonProperty(PropertyName = "exportType")]
        private readonly string exportType = "OBJECT_STORAGE";
    }
}