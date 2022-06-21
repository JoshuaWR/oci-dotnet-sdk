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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Time filters to be applied in the data object query.
    /// </summary>
    public class DataObjectQueryTimeFilters 
    {
        
        /// <value>
        /// Specify time period in ISO 8601 format with respect to current time.
        /// Default is last 30 days represented by P30D.
        /// If timePeriod is specified, then timeStart and timeEnd will be ignored.
        /// Examples: P90D (last 90 days), P4W (last 4 weeks), P2M (last 2 months), P1Y (last 12 months).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timePeriod")]
        public string TimePeriod { get; set; }
        
        /// <value>
        /// Start time in UTC in RFC3339 formatted datetime string. Example: 2021-10-30T00:00:00.000Z.timeStart and timeEnd are used together. If timePeriod is specified, this parameter is ignored.
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// End time in UTC in RFC3339 formatted datetime string. Example: 2021-10-30T00:00:00.000Z.timeStart and timeEnd are used together. If timePeriod is specified, this parameter is ignored.If timeEnd is not specified, current time is used as timeEnd.
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
    }
}