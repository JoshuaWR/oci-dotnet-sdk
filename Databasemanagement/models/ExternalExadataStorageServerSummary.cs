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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The Exadata storage server of the Exadata infrastructure.
    /// </summary>
    public class ExternalExadataStorageServerSummary : DbmResource
    {
        
        /// <value>
        /// The make model of the Exadata storage server.
        /// </value>
        [JsonProperty(PropertyName = "makeModel")]
        public string MakeModel { get; set; }
        
        /// <value>
        /// The IP address of the Exadata storage server.
        /// </value>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// The CPU count of the Exadata storage server.
        /// </value>
        [JsonProperty(PropertyName = "cpuCount")]
        public System.Nullable<decimal> CpuCount { get; set; }
        
        /// <value>
        /// The Exadata storage server memory size in GB.
        /// </value>
        [JsonProperty(PropertyName = "memoryGB")]
        public System.Double MemoryGB { get; set; }
        
        /// <value>
        /// The maximum hard disk IO operations per second of the Exadata storage server.
        /// </value>
        [JsonProperty(PropertyName = "maxHardDiskIOPS")]
        public System.Nullable<int> MaxHardDiskIOPS { get; set; }
        
        /// <value>
        /// The maximum hard disk IO throughput in MB/s of the Exadata storage server.
        /// </value>
        [JsonProperty(PropertyName = "maxHardDiskThroughput")]
        public System.Nullable<int> MaxHardDiskThroughput { get; set; }
        
        /// <value>
        /// The maximum flash disk IO operations per second of the Exadata storage server.
        /// </value>
        [JsonProperty(PropertyName = "maxFlashDiskIOPS")]
        public System.Nullable<int> MaxFlashDiskIOPS { get; set; }
        
        /// <value>
        /// The maximum flash disk IO throughput in MB/s of the Exadata storage server.
        /// </value>
        [JsonProperty(PropertyName = "maxFlashDiskThroughput")]
        public System.Nullable<int> MaxFlashDiskThroughput { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the connector.
        /// </value>
        [JsonProperty(PropertyName = "connectorId")]
        public string ConnectorId { get; set; }
        
        [JsonProperty(PropertyName = "resourceType")]
        private readonly string resourceType = "STORAGE_SERVER_SUMMARY";
    }
}
