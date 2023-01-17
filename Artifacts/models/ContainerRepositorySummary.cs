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


namespace Oci.ArtifactsService.Models
{
    /// <summary>
    /// Container repository summary.
    /// </summary>
    public class ContainerRepositorySummary 
    {
        
        /// <value>
        /// The OCID of the compartment in which the container repository exists.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The container repository name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the container repository.
        /// <br/>
        /// Example: ocid1.containerrepo.oc1..exampleuniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Total number of images.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImageCount is required.")]
        [JsonProperty(PropertyName = "imageCount")]
        public System.Nullable<int> ImageCount { get; set; }
        
        /// <value>
        /// Whether the repository is public. A public repository allows unauthenticated access.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsPublic is required.")]
        [JsonProperty(PropertyName = "isPublic")]
        public System.Nullable<bool> IsPublic { get; set; }
        
        /// <value>
        /// Total number of layers.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LayerCount is required.")]
        [JsonProperty(PropertyName = "layerCount")]
        public System.Nullable<int> LayerCount { get; set; }
        
        /// <value>
        /// Total storage in bytes consumed by layers.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LayersSizeInBytes is required.")]
        [JsonProperty(PropertyName = "layersSizeInBytes")]
        public System.Nullable<long> LayersSizeInBytes { get; set; }
        
        /// <value>
        /// The current state of the container repository.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ContainerRepository.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// An RFC 3339 timestamp indicating when the repository was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Total storage size in GBs that will be charged.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BillableSizeInGBs is required.")]
        [JsonProperty(PropertyName = "billableSizeInGBs")]
        public System.Nullable<long> BillableSizeInGBs { get; set; }
        
    }
}
