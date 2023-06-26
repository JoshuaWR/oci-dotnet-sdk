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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The set of parameters used in an SPM evolve task.
    /// </summary>
    public class SpmEvolveTaskParameters 
    {
                ///
        ///
        public enum AlternatePlanSourcesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AUTO")]
            Auto,
            [EnumMember(Value = "AUTOMATIC_WORKLOAD_REPOSITORY")]
            AutomaticWorkloadRepository,
            [EnumMember(Value = "CURSOR_CACHE")]
            CursorCache,
            [EnumMember(Value = "SQL_TUNING_SET")]
            SqlTuningSet
        };

        /// <value>
        /// Determines which sources to search for additional plans.
        /// </value>
        [JsonProperty(PropertyName = "alternatePlanSources", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<AlternatePlanSourcesEnum> AlternatePlanSources { get; set; }
                ///
        ///
        public enum AlternatePlanBaselinesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AUTO")]
            Auto,
            [EnumMember(Value = "EXISTING")]
            Existing,
            [EnumMember(Value = "NEW")]
            New
        };

        /// <value>
        /// Determines which alternative plans should be loaded.
        /// </value>
        [JsonProperty(PropertyName = "alternatePlanBaselines", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<AlternatePlanBaselinesEnum> AlternatePlanBaselines { get; set; }
        
        /// <value>
        /// Specifies the maximum number of plans to load in total (that is, not
        /// the limit for each SQL statement). A value of zero indicates `UNLIMITED`
        /// number of plans.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "alternatePlanLimit")]
        public System.Nullable<int> AlternatePlanLimit { get; set; }
        
        /// <value>
        /// Specifies whether to accept recommended plans automatically.
        /// </value>
        [JsonProperty(PropertyName = "arePlansAutoAccepted")]
        public System.Nullable<bool> ArePlansAutoAccepted { get; set; }
        
        /// <value>
        /// The global time limit in seconds. This is the total time allowed for the task.
        /// </value>
        [JsonProperty(PropertyName = "allowedTimeLimit")]
        public System.Nullable<int> AllowedTimeLimit { get; set; }
        
    }
}
