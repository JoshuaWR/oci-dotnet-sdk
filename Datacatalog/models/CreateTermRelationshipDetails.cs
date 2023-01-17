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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Properties used in term relationship create operations.
    /// </summary>
    public class CreateTermRelationshipDetails 
    {
        
        /// <value>
        /// A user-friendly display name. Is changeable. The combination of 'displayName' and 'parentTermKey'
        /// must be unique. Avoid entering confidential information. This is the same as 'relationshipType' for 'termRelationship'.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Detailed description of the term relationship usually defined at the time of creation.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Unique id of the related term.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RelatedTermKey is required.")]
        [JsonProperty(PropertyName = "relatedTermKey")]
        public string RelatedTermKey { get; set; }
        
    }
}
