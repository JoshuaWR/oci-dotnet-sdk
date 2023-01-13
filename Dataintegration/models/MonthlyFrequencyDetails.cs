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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Frequency Details model for monthly frequency.
    /// </summary>
    public class MonthlyFrequencyDetails : AbstractFrequencyDetails
    {
        
        /// <value>
        /// This hold the repeatability aspect of a schedule. i.e. in a monhtly frequency, a task can be scheduled for every month, once in two months, once in tree months etc.
        /// </value>
        [JsonProperty(PropertyName = "interval")]
        public System.Nullable<int> Interval { get; set; }
        
        [JsonProperty(PropertyName = "time")]
        public Time Time { get; set; }
        
        /// <value>
        /// A list of days of the month to be scheduled. i.e. excute every 2nd,3rd, 10th of the month.
        /// </value>
        [JsonProperty(PropertyName = "days")]
        public System.Collections.Generic.List<int> Days { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "MONTHLY";
    }
}
