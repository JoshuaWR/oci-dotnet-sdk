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
    /// The information about node to be removed.
    /// </summary>
    public class RemoveNodeDetails 
    {
        
        /// <value>
        /// Base-64 encoded password for the cluster (and Cloudera Manager) admin user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterAdminPassword is required.")]
        [JsonProperty(PropertyName = "clusterAdminPassword")]
        public string ClusterAdminPassword { get; set; }
        
        /// <value>
        /// Boolean flag specifying whether or not to force remove node if graceful
        /// removal fails.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isForceRemoveEnabled")]
        public System.Nullable<bool> IsForceRemoveEnabled { get; set; }
        
        /// <value>
        /// OCID of the node to be removed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NodeId is required.")]
        [JsonProperty(PropertyName = "nodeId")]
        public string NodeId { get; set; }
        
    }
}
