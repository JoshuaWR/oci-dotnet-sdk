/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    /// The reqeust body while installing a patch to a cluster.
    /// </summary>
    public class InstallPatchDetails 
    {
        
        /// <value>
        /// The version of the patch to be installed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// Base-64 encoded password for the cluster admin user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterAdminPassword is required.")]
        [JsonProperty(PropertyName = "clusterAdminPassword")]
        public string ClusterAdminPassword { get; set; }
        
    }
}
