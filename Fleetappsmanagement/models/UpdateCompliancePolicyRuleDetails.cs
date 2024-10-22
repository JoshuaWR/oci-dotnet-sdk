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
    /// The data to update a CompliancePolicyRule.
    /// </summary>
    public class UpdateCompliancePolicyRuleDetails 
    {
        
        [JsonProperty(PropertyName = "productVersion")]
        public ProductVersionDetails ProductVersion { get; set; }
        
        /// <value>
        /// PlatformConfiguration OCID for the patch type to which this CompliancePolicyRule applies.
        /// </value>
        [JsonProperty(PropertyName = "patchType")]
        public System.Collections.Generic.List<string> PatchType { get; set; }
        
        /// <value>
        /// Severity to which this CompliancePolicyRule applies.
        /// </value>
        [JsonProperty(PropertyName = "severity", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<ComplianceRuleSeverity> Severity { get; set; }
        
        [JsonProperty(PropertyName = "patchSelection")]
        public PatchSelectionDetails PatchSelection { get; set; }
        
        /// <value>
        /// Grace period in days,weeks,months or years the exemption is applicable for the rule.
        /// This enables a grace period when Fleet Application Management doesn't report the product as noncompliant when patch is not applied.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "gracePeriod")]
        public string GracePeriod { get; set; }
        
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
