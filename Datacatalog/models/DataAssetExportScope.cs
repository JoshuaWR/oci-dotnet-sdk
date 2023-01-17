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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Scope of asset export, which consists of a container object (bucket, folder, schema, etc) within the asset,
    /// and types of child objects contained by that object to be included.
    ///    objectKey - Key of the container object to be exported. For example, key of schema_1.
    ///    exportTypeIds - Type key(s) of objects within the container object to be exported. For example, type key of table or view.
    /// 
    /// </summary>
    public class DataAssetExportScope 
    {
        
        /// <value>
        /// Unique key of the object selected for export.
        /// </value>
        [JsonProperty(PropertyName = "objectKey")]
        public string ObjectKey { get; set; }
        
        /// <value>
        /// Array of type keys selected for export.
        /// </value>
        [JsonProperty(PropertyName = "exportTypeIds")]
        public System.Collections.Generic.List<string> ExportTypeIds { get; set; }
        
    }
}
