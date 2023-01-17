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


namespace Oci.ServicecatalogService.Models
{
    /// <summary>
    /// The model to create a single association between a service catalog and a resource.
    /// </summary>
    public class CreateServiceCatalogAssociationDetails 
    {
        
        /// <value>
        /// Identifier of the service catalog.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceCatalogId is required.")]
        [JsonProperty(PropertyName = "serviceCatalogId")]
        public string ServiceCatalogId { get; set; }
        
        /// <value>
        /// Identifier of the entity being associated with service catalog.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityId is required.")]
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }
        
        /// <value>
        /// The type of the entity that is associated with the service catalog.
        /// </value>
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }
        
    }
}
