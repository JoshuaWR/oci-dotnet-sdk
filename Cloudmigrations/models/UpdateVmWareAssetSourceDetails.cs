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


namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Asset source update details.
    /// </summary>
    public class UpdateVmWareAssetSourceDetails : UpdateAssetSourceDetails
    {
        
        /// <value>
        /// Endpoint for VMware asset discovery and replication in the form of ```https://<host>:<port>/sdk```
        /// </value>
        [JsonProperty(PropertyName = "vcenterEndpoint")]
        public string VcenterEndpoint { get; set; }
        
        [JsonProperty(PropertyName = "discoveryCredentials")]
        public AssetSourceCredentials DiscoveryCredentials { get; set; }
        
        [JsonProperty(PropertyName = "replicationCredentials")]
        public AssetSourceCredentials ReplicationCredentials { get; set; }
        
        /// <value>
        /// Flag indicating whether historical metrics are collected for assets, originating from this asset source.
        /// </value>
        [JsonProperty(PropertyName = "areHistoricalMetricsCollected")]
        public System.Nullable<bool> AreHistoricalMetricsCollected { get; set; }
        
        /// <value>
        /// Flag indicating whether real-time metrics are collected for assets, originating from this asset source.
        /// </value>
        [JsonProperty(PropertyName = "areRealtimeMetricsCollected")]
        public System.Nullable<bool> AreRealtimeMetricsCollected { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the discovery schedule that is going to be assigned to an asset source.
        /// </value>
        [JsonProperty(PropertyName = "discoveryScheduleId")]
        public string DiscoveryScheduleId { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "VMWARE";
    }
}
