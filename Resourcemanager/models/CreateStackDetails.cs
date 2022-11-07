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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Creation details for a stack.
    /// 
    /// </summary>
    public class CreateStackDetails 
    {
        
        /// <value>
        /// Unique identifier ([OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)) of the compartment in which the stack resides.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The stack's display name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the stack.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConfigSource is required.")]
        [JsonProperty(PropertyName = "configSource")]
        public CreateConfigSourceDetails ConfigSource { get; set; }
        
        [JsonProperty(PropertyName = "customTerraformProvider")]
        public CustomTerraformProvider CustomTerraformProvider { get; set; }
        
        /// <value>
        /// Terraform variables associated with this resource.
        /// Maximum number of variables supported is 250.
        /// The maximum size of each variable, including both name and value, is 8192 bytes.
        /// Example: {&quot;CompartmentId&quot;: &quot;compartment-id-value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "variables")]
        public System.Collections.Generic.Dictionary<string, string> Variables { get; set; }
        
        /// <value>
        /// The version of Terraform to use with the stack. Example: 0.12.x
        /// </value>
        [JsonProperty(PropertyName = "terraformVersion")]
        public string TerraformVersion { get; set; }
        
        /// <value>
        /// Free-form tags associated with this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags associated with this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
