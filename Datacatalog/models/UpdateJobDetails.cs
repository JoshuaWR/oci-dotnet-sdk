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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Job properties that can be updated.
    /// </summary>
    public class UpdateJobDetails 
    {
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Detailed description of the job.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Interval on which the job will be run. Value is specified as a cron-supported time specification \"nickname\".
        /// The following subset of those is supported: @monthly, @weekly, @daily, @hourly.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scheduleCronExpression")]
        public string ScheduleCronExpression { get; set; }
        
        /// <value>
        /// Date that the schedule should be operational. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeScheduleBegin")]
        public System.Nullable<System.DateTime> TimeScheduleBegin { get; set; }
        
        /// <value>
        /// Date that the schedule should end from being operational. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeScheduleEnd")]
        public System.Nullable<System.DateTime> TimeScheduleEnd { get; set; }
        
        /// <value>
        /// The key of the connection resource that is used for the harvest by this job.
        /// </value>
        [JsonProperty(PropertyName = "connectionKey")]
        public string ConnectionKey { get; set; }
        
    }
}
