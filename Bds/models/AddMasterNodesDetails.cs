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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// The information about added master nodes.
    /// </summary>
    public class AddMasterNodesDetails 
    {
        
        /// <value>
        /// Base-64 encoded Cluster Admin Password for cluster admin user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterAdminPassword is required.")]
        [JsonProperty(PropertyName = "clusterAdminPassword")]
        public string ClusterAdminPassword { get; set; }
        
        /// <value>
        /// Number of additional master nodes for the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NumberOfMasterNodes is required.")]
        [JsonProperty(PropertyName = "numberOfMasterNodes")]
        public System.Nullable<int> NumberOfMasterNodes { get; set; }
        
        /// <value>
        /// Shape of the node. It's a read-only property derived from existing Master node.
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The size of block volume in GB to be attached to the given node. It's a read-only property.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "blockVolumeSizeInGBs")]
        public System.Nullable<long> BlockVolumeSizeInGBs { get; set; }
        
        [JsonProperty(PropertyName = "shapeConfig")]
        public ShapeConfigDetails ShapeConfig { get; set; }
        
    }
}
