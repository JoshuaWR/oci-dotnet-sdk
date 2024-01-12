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
    /// The configuration details for an alarm-wide suppression.
    /// For dimension-specific suppressions, see {@link AlarmSuppression}.
    /// For information about alarms, see
    /// [Alarms Overview](https://docs.cloud.oracle.com/iaas/Content/Monitoring/Concepts/monitoringoverview.htm#AlarmsOverview).
    /// 
    /// </summary>
    public class Suppression 
    {
        
        /// <value>
        /// Human-readable reason for suppressing alarm notifications.
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
        
    }
}
