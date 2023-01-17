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
    /// Properties used in term update operations.
    /// </summary>
    public class UpdateTermDetails 
    {
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Detailed description of the term.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The parent key of the term. In the case of a root-level category only, the term would have no parent and this should be left unset.
        /// </value>
        [JsonProperty(PropertyName = "parentTermKey")]
        public string ParentTermKey { get; set; }
        
        /// <value>
        /// OCID of the user who is the owner of this business terminology.
        /// </value>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }
        
        /// <value>
        /// Status of the approval process workflow for this business term in the glossary
        /// </value>
        [JsonProperty(PropertyName = "workflowStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TermWorkflowStatus> WorkflowStatus { get; set; }
        
        /// <value>
        /// The list of customized properties along with the values for this object
        /// </value>
        [JsonProperty(PropertyName = "customPropertyMembers")]
        public System.Collections.Generic.List<CustomPropertySetUsage> CustomPropertyMembers { get; set; }
        
    }
}
