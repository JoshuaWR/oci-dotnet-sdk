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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The details of a Data Safe Alert, that shows alerts generated by a Data Safe feature.
    /// </summary>
    public class Alert 
    {
        
        /// <value>
        /// The OCID of the alert.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The status of the alert.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AlertStatus> Status { get; set; }
        
        /// <value>
        /// Severity level of the alert.
        /// </value>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AlertSeverity> Severity { get; set; }
        
        /// <value>
        /// The display name of the alert.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The description of the alert.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Creation date and time of the operation that triggered alert, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "operationTime")]
        public System.Nullable<System.DateTime> OperationTime { get; set; }
        
        /// <value>
        /// The operation (event) that triggered alert.
        /// </value>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }
                ///
        /// <value>
        /// The result of the operation (event) that triggered alert.
        /// </value>
        ///
        public enum OperationStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The result of the operation (event) that triggered alert.
        /// </value>
        [JsonProperty(PropertyName = "operationStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperationStatusEnum> OperationStatus { get; set; }
        
        /// <value>
        /// Array of OCIDs of the target database which are associated with the alert.
        /// </value>
        [JsonProperty(PropertyName = "targetIds")]
        public System.Collections.Generic.List<string> TargetIds { get; set; }
        
        /// <value>
        /// Array of names of the target database.
        /// </value>
        [JsonProperty(PropertyName = "targetNames")]
        public System.Collections.Generic.List<string> TargetNames { get; set; }
        
        /// <value>
        /// The OCID of the policy that triggered alert.
        /// </value>
        [JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; set; }
        
        /// <value>
        /// Type of the alert. Indicates the Data Safe feature triggering the alert.
        /// </value>
        [JsonProperty(PropertyName = "alertType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AlertType> AlertType { get; set; }
        
        /// <value>
        /// The resource endpoint that triggered the alert.
        /// </value>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// Map that contains maps of values.
        ///  Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "featureDetails")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> FeatureDetails { get; set; }
        
        /// <value>
        /// A comment for the alert. Entered by the user.
        /// </value>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the alert.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The current state of the alert.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AlertLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Creation date and time of the alert, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Last date and time the alert was updated, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
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
