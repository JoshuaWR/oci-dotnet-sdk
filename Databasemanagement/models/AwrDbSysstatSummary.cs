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
    /// The summary of the AWR SYSSTAT data.
    /// </summary>
    public class AwrDbSysstatSummary 
    {
        
        /// <value>
        /// The name of the SYSSTAT.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The name of the SYSSTAT category.
        /// </value>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        
        /// <value>
        /// The start time of the SYSSTAT.
        /// </value>
        [JsonProperty(PropertyName = "timeBegin")]
        public System.Nullable<System.DateTime> TimeBegin { get; set; }
        
        /// <value>
        /// The end time of the SYSSTAT.
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// The average value of the SYSSTAT.
        /// </value>
        [JsonProperty(PropertyName = "avgValue")]
        public System.Double AvgValue { get; set; }
        
        /// <value>
        /// The last value of the SYSSTAT.
        /// </value>
        [JsonProperty(PropertyName = "currentValue")]
        public System.Double CurrentValue { get; set; }
        
    }
}
