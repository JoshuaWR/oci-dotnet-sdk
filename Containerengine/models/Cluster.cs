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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// A Kubernetes cluster. Avoid entering confidential information.
    /// </summary>
    public class Cluster 
    {
        
        /// <value>
        /// The OCID of the cluster.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the cluster.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The OCID of the compartment in which the cluster exists.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The network configuration for access to the Cluster control plane.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "endpointConfig")]
        public ClusterEndpointConfig EndpointConfig { get; set; }
        
        /// <value>
        /// The OCID of the virtual cloud network (VCN) in which the cluster exists.
        /// </value>
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
        /// <value>
        /// The version of Kubernetes running on the cluster masters.
        /// </value>
        [JsonProperty(PropertyName = "kubernetesVersion")]
        public string KubernetesVersion { get; set; }
        
        /// <value>
        /// The OCID of the KMS key to be used as the master encryption key for Kubernetes secret encryption.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// Optional attributes for the cluster.
        /// </value>
        [JsonProperty(PropertyName = "options")]
        public ClusterCreateOptions Options { get; set; }
        
        /// <value>
        /// Metadata about the cluster.
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public ClusterMetadata Metadata { get; set; }
        
        /// <value>
        /// The state of the cluster masters.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ClusterLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Details about the state of the cluster masters.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// Endpoints served up by the cluster masters.
        /// </value>
        [JsonProperty(PropertyName = "endpoints")]
        public ClusterEndpoints Endpoints { get; set; }
        
        /// <value>
        /// Available Kubernetes versions to which the clusters masters may be upgraded.
        /// </value>
        [JsonProperty(PropertyName = "availableKubernetesUpgrades")]
        public System.Collections.Generic.List<string> AvailableKubernetesUpgrades { get; set; }
        
        /// <value>
        /// The image verification policy for signature validation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "imagePolicyConfig")]
        public ImagePolicyConfig ImagePolicyConfig { get; set; }
        
        /// <value>
        /// Available CNIs and network options for existing and new node pools of the cluster
        /// </value>
        [JsonProperty(PropertyName = "clusterPodNetworkOptions")]
        public System.Collections.Generic.List<ClusterPodNetworkOptionDetails> ClusterPodNetworkOptions { get; set; }
        
    }
}
