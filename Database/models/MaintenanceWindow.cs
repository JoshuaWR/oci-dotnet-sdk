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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The scheduling details for the quarterly maintenance window. Patching and system updates take place during the maintenance window.
    /// 
    /// </summary>
    public class MaintenanceWindow 
    {
                ///
        /// <value>
        /// The maintenance window scheduling preference.
        /// </value>
        ///
        public enum PreferenceEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NO_PREFERENCE")]
            NoPreference,
            [EnumMember(Value = "CUSTOM_PREFERENCE")]
            CustomPreference
        };

        /// <value>
        /// The maintenance window scheduling preference.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Preference is required.")]
        [JsonProperty(PropertyName = "preference")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PreferenceEnum> Preference { get; set; }
                ///
        /// <value>
        /// Cloud Exadata infrastructure node patching method, either \"ROLLING\" or \"NONROLLING\". Default value is ROLLING.
        /// <br/>
        /// *IMPORTANT*: Non-rolling infrastructure patching involves system down time. See [Oracle-Managed Infrastructure Maintenance Updates](https://docs.cloud.oracle.com/iaas/Content/Database/Concepts/examaintenance.htm#Oracle) for more information.
        /// 
        /// </value>
        ///
        public enum PatchingModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ROLLING")]
            Rolling,
            [EnumMember(Value = "NONROLLING")]
            Nonrolling
        };

        /// <value>
        /// Cloud Exadata infrastructure node patching method, either \"ROLLING\" or \"NONROLLING\". Default value is ROLLING.
        /// <br/>
        /// *IMPORTANT*: Non-rolling infrastructure patching involves system down time. See [Oracle-Managed Infrastructure Maintenance Updates](https://docs.cloud.oracle.com/iaas/Content/Database/Concepts/examaintenance.htm#Oracle) for more information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "patchingMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PatchingModeEnum> PatchingMode { get; set; }
        
        /// <value>
        /// If true, enables the configuration of a custom action timeout (waiting period) between database server patching operations.
        /// </value>
        [JsonProperty(PropertyName = "isCustomActionTimeoutEnabled")]
        public System.Nullable<bool> IsCustomActionTimeoutEnabled { get; set; }
        
        /// <value>
        /// Determines the amount of time the system will wait before the start of each database server patching operation.
        /// Custom action timeout is in minutes and valid value is between 15 to 120 (inclusive).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customActionTimeoutInMins")]
        public System.Nullable<int> CustomActionTimeoutInMins { get; set; }
        
        /// <value>
        /// If true, enables the monthly patching option.
        /// </value>
        [JsonProperty(PropertyName = "isMonthlyPatchingEnabled")]
        public System.Nullable<bool> IsMonthlyPatchingEnabled { get; set; }
        
        /// <value>
        /// Months during the year when maintenance should be performed.
        /// </value>
        [JsonProperty(PropertyName = "months")]
        public System.Collections.Generic.List<Month> Months { get; set; }
        
        /// <value>
        /// Weeks during the month when maintenance should be performed. Weeks start on the 1st, 8th, 15th, and 22nd days of the month, and have a duration of 7 days. Weeks start and end based on calendar dates, not days of the week.
        /// For example, to allow maintenance during the 2nd week of the month (from the 8th day to the 14th day of the month), use the value 2. Maintenance cannot be scheduled for the fifth week of months that contain more than 28 days.
        /// Note that this parameter works in conjunction with the  daysOfWeek and hoursOfDay parameters to allow you to specify specific days of the week and hours that maintenance will be performed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "weeksOfMonth")]
        public System.Collections.Generic.List<int> WeeksOfMonth { get; set; }
        
        /// <value>
        /// Days during the week when maintenance should be performed.
        /// </value>
        [JsonProperty(PropertyName = "daysOfWeek")]
        public System.Collections.Generic.List<DayOfWeek> DaysOfWeek { get; set; }
        
        /// <value>
        /// The window of hours during the day when maintenance should be performed. The window is a 4 hour slot. Valid values are
        /// - 0 - represents time slot 0:00 - 3:59 UTC - 4 - represents time slot 4:00 - 7:59 UTC - 8 - represents time slot 8:00 - 11:59 UTC - 12 - represents time slot 12:00 - 15:59 UTC - 16 - represents time slot 16:00 - 19:59 UTC - 20 - represents time slot 20:00 - 23:59 UTC
        /// </value>
        [JsonProperty(PropertyName = "hoursOfDay")]
        public System.Collections.Generic.List<int> HoursOfDay { get; set; }
        
        /// <value>
        /// Lead time window allows user to set a lead time to prepare for a down time. The lead time is in weeks and valid value is between 1 to 4.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "leadTimeInWeeks")]
        public System.Nullable<int> LeadTimeInWeeks { get; set; }
        
    }
}
