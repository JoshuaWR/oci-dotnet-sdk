/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// The information about new Runbook.
    /// </summary>
    public class CreateRunbookDetails 
    {
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: My new resource
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A user-friendly description. To provide some insight about the resource.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Type of runbook structure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RunbookRelevance is required.")]
        [JsonProperty(PropertyName = "runbookRelevance")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Runbook.RunbookRelevanceEnum> RunbookRelevance { get; set; }
        
        /// <value>
        /// The lifecycle operation performed by the task.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Operation is required.")]
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }
        
        /// <value>
        /// The OS type for the runbook.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OsType is required.")]
        [JsonProperty(PropertyName = "osType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OsType> OsType { get; set; }
        
        /// <value>
        /// The platform of the runbook.
        /// </value>
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }
        
        /// <value>
        /// Is the runbook default?
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
        /// <value>
        /// Estimated time to successfully complete the runbook execution
        /// </value>
        [JsonProperty(PropertyName = "estimatedTime")]
        public string EstimatedTime { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Associations is required.")]
        [JsonProperty(PropertyName = "associations")]
        public Associations Associations { get; set; }
        
        /// <value>
        /// OCID of the compartment to which the resource belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
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
