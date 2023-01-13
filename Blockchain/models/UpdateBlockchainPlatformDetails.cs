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


namespace Oci.BlockchainService.Models
{
    /// <summary>
    /// Blockchain Platform details for updating a service.
    /// </summary>
    public class UpdateBlockchainPlatformDetails 
    {
        
        /// <value>
        /// Platform Description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Storage size in TBs
        /// </value>
        [JsonProperty(PropertyName = "storageSizeInTBs")]
        public System.Double StorageSizeInTBs { get; set; }
        
        [JsonProperty(PropertyName = "replicas")]
        public ReplicaDetails Replicas { get; set; }
        
        /// <value>
        /// Number of total OCPUs to allocate
        /// </value>
        [JsonProperty(PropertyName = "totalOcpuCapacity")]
        public System.Nullable<int> TotalOcpuCapacity { get; set; }
        
        /// <value>
        /// Type of Load Balancer shape - LB_100_MBPS or LB_400_MBPS. Default is LB_100_MBPS.
        /// </value>
        [JsonProperty(PropertyName = "loadBalancerShape")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BlockchainPlatform.LoadBalancerShapeEnum> LoadBalancerShape { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
