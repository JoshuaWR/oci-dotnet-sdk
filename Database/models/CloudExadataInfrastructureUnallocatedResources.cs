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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details of unallocated resources of the Cloud Exadata infrastructure. Applies to Cloud Exadata infrastructure instances only.
    /// 
    /// </summary>
    public class CloudExadataInfrastructureUnallocatedResources 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Cloud Exadata infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CloudExadataInfrastructureId is required.")]
        [JsonProperty(PropertyName = "cloudExadataInfrastructureId")]
        public string CloudExadataInfrastructureId { get; set; }
        
        /// <value>
        /// The user-friendly name for the Cloud Exadata infrastructure. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CloudExadataInfrastructureDisplayName is required.")]
        [JsonProperty(PropertyName = "cloudExadataInfrastructureDisplayName")]
        public string CloudExadataInfrastructureDisplayName { get; set; }
        
        /// <value>
        /// The minimum amount of unallocated storage available across all nodes in the infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "localStorageInGbs")]
        public System.Nullable<int> LocalStorageInGbs { get; set; }
        
        /// <value>
        /// The minimum amount of unallocated ocpus available across all nodes in the infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "ocpus")]
        public System.Nullable<int> Ocpus { get; set; }
        
        /// <value>
        /// The minimum amount of unallocated memory available across all nodes in the infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "memoryInGBs")]
        public System.Nullable<int> MemoryInGBs { get; set; }
        
        /// <value>
        /// Total unallocated exadata storage in the infrastructure in TBs.
        /// </value>
        [JsonProperty(PropertyName = "exadataStorageInTBs")]
        public System.Double ExadataStorageInTBs { get; set; }
        
        /// <value>
        /// The list of Cloud Autonomous VM Clusters on the Infrastructure and their associated unallocated resources details.
        /// </value>
        [JsonProperty(PropertyName = "cloudAutonomousVmClusters")]
        public System.Collections.Generic.List<CloudAutonomousVmClusterResourceDetails> CloudAutonomousVmClusters { get; set; }
        
    }
}
