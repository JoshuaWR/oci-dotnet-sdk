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
    /// The configuration details for creating an alarm suppression.
    /// 
    /// </summary>
    public class CreateAlarmSuppressionDetails 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AlarmSuppressionTarget is required.")]
        [JsonProperty(PropertyName = "alarmSuppressionTarget")]
        public AlarmSuppressionTarget AlarmSuppressionTarget { get; set; }
        
        /// <value>
        /// The level of this alarm suppression.
        /// `ALARM` indicates a suppression of the entire alarm, regardless of dimension.
        /// `DIMENSION` indicates a suppression configured for specified dimensions.
        /// <br/>
        /// Defaut: `DIMENSION`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AlarmSuppression.LevelEnum> Level { get; set; }
        
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
        /// A filter to suppress only alarm state entries that include the set of specified dimension key-value pairs.
        /// If you specify {\"availabilityDomain\": \"phx-ad-1\"}
        /// and the alarm state entry corresponds to the set {\"availabilityDomain\": \"phx-ad-1\" and \"resourceId\": \"ocid1.instance.region1.phx.exampleuniqueID\"},
        /// then this alarm will be included for suppression.
        /// <br/>
        /// This is required only when the value of level is `DIMENSION`. If required, the value cannot be an empty object.
        /// Only a single value is allowed per key. No grouping of multiple values is allowed under the same key.
        /// Maximum characters (after serialization): 4000. This maximum satisfies typical use cases.
        /// The response for an exceeded maximum is `HTTP 400` with an \"dimensions values are too long\" message.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.Dictionary<string, string> Dimensions { get; set; }
        
        /// <value>
        /// The start date and time for the suppression to take place, inclusive. Format defined by RFC3339.
        /// <br/>
        /// Example: 2023-02-01T01:02:29.600Z
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
        /// Example: 2023-02-01T02:02:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeSuppressUntil is required.")]
        [JsonProperty(PropertyName = "timeSuppressUntil")]
        public System.Nullable<System.DateTime> TimeSuppressUntil { get; set; }
        
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
        
        /// <value>
        /// Array of all preconditions for alarm suppression.
        /// Example: [{  conditionType: &quot;RECURRENCE&quot;,  suppressionRecurrence: &quot;FRQ=DAILY;BYHOUR=10&quot;,  suppressionDuration: &quot;PT1H&quot;}]
        /// </value>
        [JsonProperty(PropertyName = "suppressionConditions")]
        public System.Collections.Generic.List<SuppressionCondition> SuppressionConditions { get; set; }
        
    }
}
