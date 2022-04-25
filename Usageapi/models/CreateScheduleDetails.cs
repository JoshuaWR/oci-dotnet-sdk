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


namespace Oci.UsageapiService.Models
{
    /// <summary>
    /// The saved schedule.
    /// </summary>
    public class CreateScheduleDetails 
    {
        
        /// <value>
        /// The unique name of the schedule created by the user
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The tenancy of the customer
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
        [Required(ErrorMessage = "ResultLocation is required.")]
        [JsonProperty(PropertyName = "resultLocation")]
        public ResultLocation ResultLocation { get; set; }
        
        /// <value>
        /// In x-obmcs-recurring-time format shown here: https://datatracker.ietf.org/doc/html/rfc5545#section-3.3.10
        /// Describes the frequency of when the schedule will be run
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScheduleRecurrences is required.")]
        [JsonProperty(PropertyName = "scheduleRecurrences")]
        public string ScheduleRecurrences { get; set; }
        
        /// <value>
        /// The date and time of the first time job execution
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeScheduled is required.")]
        [JsonProperty(PropertyName = "timeScheduled")]
        public System.Nullable<System.DateTime> TimeScheduled { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "QueryProperties is required.")]
        [JsonProperty(PropertyName = "queryProperties")]
        public QueryProperties QueryProperties { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. 
        /// See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
