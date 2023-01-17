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


namespace Oci.OpensearchService.Models
{
    /// <summary>
    /// The node count configuration to update on an existing OpenSearch cluster for [horizontal resizing](https://docs.cloud.oracle.com/iaas/Content/search-opensearch/Tasks/resizingacluster.htm#horizontalresize).
    /// </summary>
    public class ResizeOpensearchClusterHorizontalDetails 
    {
        
        /// <value>
        /// The number of master nodes to configure for the cluster.
        /// </value>
        [JsonProperty(PropertyName = "masterNodeCount")]
        public System.Nullable<int> MasterNodeCount { get; set; }
        
        /// <value>
        /// The number of data nodes to configure for the cluster.
        /// </value>
        [JsonProperty(PropertyName = "dataNodeCount")]
        public System.Nullable<int> DataNodeCount { get; set; }
        
        /// <value>
        /// The number of OpenSearch Dashboard nodes to configure for the cluster.
        /// </value>
        [JsonProperty(PropertyName = "opendashboardNodeCount")]
        public System.Nullable<int> OpendashboardNodeCount { get; set; }
        
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
