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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Creates a lifecycle environment.
    /// A lifecycle environment is a user-defined pipeline to deliver curated, 
    /// versioned content in a prescribed, methodical manner.
    /// 
    /// </summary>
    public class CreateLifecycleEnvironmentDetails 
    {
        
        /// <value>
        /// The OCID of the tenancy containing the lifecycle environment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// User specified information about the lifecycle environment.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// User specified list of ranked lifecycle stages to be created for the lifecycle environment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Stages is required.")]
        [JsonProperty(PropertyName = "stages")]
        public System.Collections.Generic.List<CreateLifecycleStageDetails> Stages { get; set; }
        
        /// <value>
        /// The CPU architecture of the managed instance(s) in the lifecycle environment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArchType is required.")]
        [JsonProperty(PropertyName = "archType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ArchType> ArchType { get; set; }
        
        /// <value>
        /// The operating system type of the managed instance(s) in the lifecycle environment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OsFamily is required.")]
        [JsonProperty(PropertyName = "osFamily")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OsFamily> OsFamily { get; set; }
        
        /// <value>
        /// The software source vendor name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VendorName is required.")]
        [JsonProperty(PropertyName = "vendorName")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<VendorName> VendorName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
