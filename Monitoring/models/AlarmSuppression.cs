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


namespace Oci.MonitoringService.Models
{
    /// <summary>
    /// The configuration details for a dimension-specific alarm suppression.
    /// 
    /// </summary>
    public class AlarmSuppression 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the alarm suppression.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the alarm suppression.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AlarmSuppressionTarget is required.")]
        [JsonProperty(PropertyName = "alarmSuppressionTarget")]
        public AlarmSuppressionTarget AlarmSuppressionTarget { get; set; }
        
        /// <value>
        /// A user-friendly name for the alarm suppression. It does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Human-readable reason for this alarm suppression.
        /// It does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// Oracle recommends including tracking information for the event or associated work,
        /// such as a ticket number.
        /// <br/>
        /// Example: Planned outage due to change IT-1234.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Configured dimension filter for suppressing alarm state entries that include the set of specified dimension key-value pairs.
        /// <br/>
        /// Example: {&quot;resourceId&quot;: &quot;ocid1.instance.region1.phx.exampleuniqueID&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Dimensions is required.")]
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.Dictionary<string, string> Dimensions { get; set; }
        
        /// <value>
        /// The start date and time for the suppression to take place, inclusive. Format defined by RFC3339.
        /// <br/>
        /// Example: 2018-02-01T01:02:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeSuppressFrom is required.")]
        [JsonProperty(PropertyName = "timeSuppressFrom")]
        public System.Nullable<System.DateTime> TimeSuppressFrom { get; set; }
        
        /// <value>
        /// The end date and time for the suppression to take place, inclusive. Format defined by RFC3339.
        /// <br/>
        /// Example: 2018-02-01T02:02:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeSuppressUntil is required.")]
        [JsonProperty(PropertyName = "timeSuppressUntil")]
        public System.Nullable<System.DateTime> TimeSuppressUntil { get; set; }
                ///
        /// <value>
        /// The current lifecycle state of the alarm suppression.
        /// <br/>
        /// Example: DELETED
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The current lifecycle state of the alarm suppression.
        /// <br/>
        /// Example: DELETED
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the alarm suppression was created. Format defined by RFC3339.
        /// <br/>
        /// Example: 2018-02-01T01:02:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the alarm suppression was last updated (deleted). Format defined by RFC3339.
        /// <br/>
        /// Example: 2018-02-03T01:02:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
