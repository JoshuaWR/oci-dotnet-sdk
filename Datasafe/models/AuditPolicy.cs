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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The resource represents all available audit policies relevant for the target database with their corresponding audit conditions.
    /// The audit policies could be in any one of the following 3 states in the target database
    /// 1) Created and enabled
    /// 2) Created but not enabled
    /// 3) Not created
    /// For more details on available audit policies, refer to [documentation](https://docs.oracle.com/en/cloud/paas/data-safe/udscs/audit-policies.html#GUID-361A9A9A-7C21-4F5A-8945-9B3A0C472827).
    /// 
    /// </summary>
    public class AuditPolicy 
    {
        
        /// <value>
        /// The OCID of the audit policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the audit policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The display name of the audit policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the audit policy.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The time the the audit policy was created, in the format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The last date and time the audit policy was updated, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the audit policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AuditPolicyLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Details about the current state of the audit policy in Data Safe.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The OCID of the target for which the audit policy is created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetId is required.")]
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// Option provided to users at the target to indicate whether the Data Safe service account has to be excluded while provisioning the audit policies.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsDataSafeServiceAccountExcluded is required.")]
        [JsonProperty(PropertyName = "isDataSafeServiceAccountExcluded")]
        public System.Nullable<bool> IsDataSafeServiceAccountExcluded { get; set; }
        
        /// <value>
        /// Indicates the last provisioning time of audit policies on the target, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeLastProvisioned")]
        public System.Nullable<System.DateTime> TimeLastProvisioned { get; set; }
        
        /// <value>
        /// The time when the audit policies was last retrieved from this target, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeLastRetrieved")]
        public System.Nullable<System.DateTime> TimeLastRetrieved { get; set; }
        
        /// <value>
        /// Represents all available audit policy specifications relevant for the target database. For more details on available audit polcies, refer to [documentation](https://docs.oracle.com/en/cloud/paas/data-safe/udscs/audit-policies.html#GUID-361A9A9A-7C21-4F5A-8945-9B3A0C472827).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "auditSpecifications")]
        public System.Collections.Generic.List<AuditSpecification> AuditSpecifications { get; set; }
        
        /// <value>
        /// Lists the audit policy provisioning conditions for the target database.
        /// </value>
        [JsonProperty(PropertyName = "auditConditions")]
        public System.Collections.Generic.List<AuditConditions> AuditConditions { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace. For more information, see Resource Tags.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
