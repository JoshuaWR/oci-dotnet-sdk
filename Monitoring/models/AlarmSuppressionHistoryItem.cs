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
    /// A summary of properties for the specified alarm suppression history item.
    /// 
    /// </summary>
    public class AlarmSuppressionHistoryItem 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the alarm suppression.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SuppressionId is required.")]
        [JsonProperty(PropertyName = "suppressionId")]
        public string SuppressionId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AlarmSuppressionTarget is required.")]
        [JsonProperty(PropertyName = "alarmSuppressionTarget")]
        public AlarmSuppressionTarget AlarmSuppressionTarget { get; set; }
                ///
        /// <value>
        /// The level of this alarm suppression.
        /// `ALARM` indicates a suppression of the entire alarm, regardless of dimension.
        /// `DIMENSION` indicates a suppression configured for specified dimensions.
        /// 
        /// </value>
        ///
        public enum LevelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ALARM")]
            Alarm,
            [EnumMember(Value = "DIMENSION")]
            Dimension
        };

        /// <value>
        /// The level of this alarm suppression.
        /// `ALARM` indicates a suppression of the entire alarm, regardless of dimension.
        /// `DIMENSION` indicates a suppression configured for specified dimensions.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Level is required.")]
        [JsonProperty(PropertyName = "level")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LevelEnum> Level { get; set; }
        
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
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.Dictionary<string, string> Dimensions { get; set; }
        
        /// <value>
        /// The start date and time for the suppression actually starts, inclusive. Format defined by RFC3339.
        /// <br/>
        /// Example: 2023-02-01T01:02:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeEffectiveFrom is required.")]
        [JsonProperty(PropertyName = "timeEffectiveFrom")]
        public System.Nullable<System.DateTime> TimeEffectiveFrom { get; set; }
        
        /// <value>
        /// The end date and time for the suppression actually ends, inclusive. Format defined by RFC3339.
        /// <br/>
        /// Example: 2023-02-01T02:02:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeEffectiveUntil is required.")]
        [JsonProperty(PropertyName = "timeEffectiveUntil")]
        public System.Nullable<System.DateTime> TimeEffectiveUntil { get; set; }
        
    }
}