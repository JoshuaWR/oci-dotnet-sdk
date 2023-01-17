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


namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// The data profile payload.
    /// </summary>
    public class CreateDataProfileDetails 
    {
        
        [JsonProperty(PropertyName = "readOperationConfig")]
        public ReadOperationConfig ReadOperationConfig { get; set; }
        
        [JsonProperty(PropertyName = "dataAsset")]
        public DataAsset DataAsset { get; set; }
        
        [JsonProperty(PropertyName = "connection")]
        public Connection Connection { get; set; }
        
        [JsonProperty(PropertyName = "schema")]
        public Schema Schema { get; set; }
        
        [JsonProperty(PropertyName = "dataEntity")]
        public DataEntity DataEntity { get; set; }
        
        [JsonProperty(PropertyName = "profileConfig")]
        public ProfileConfig ProfileConfig { get; set; }
        
    }
}
