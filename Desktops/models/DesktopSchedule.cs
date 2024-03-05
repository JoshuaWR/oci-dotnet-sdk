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


namespace Oci.DesktopsService.Models
{
    /// <summary>
    /// Provides the schedule information for a desktop.
    /// </summary>
    public class DesktopSchedule 
    {
        
        /// <value>
        /// A cron expression describing the desktop's schedule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CronExpression is required.")]
        [JsonProperty(PropertyName = "cronExpression")]
        public string CronExpression { get; set; }
        
        /// <value>
        /// The timezone of the desktop's schedule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Timezone is required.")]
        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }
        
    }
}