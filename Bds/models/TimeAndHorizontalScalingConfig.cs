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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// Time of day and horizontal scaling configuration.
    /// </summary>
    public class TimeAndHorizontalScalingConfig 
    {
        
        /// <value>
        /// Day/time recurrence (specified following RFC 5545) at which to trigger autoscaling action. Currently only WEEKLY frequency is supported. Days of the week are specified using BYDAY field. Time of the day is specified using BYHOUR and BYMINUTE fields. Other fields are not supported.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeRecurrence")]
        public string TimeRecurrence { get; set; }
        
        /// <value>
        /// This value is the desired number of nodes in the cluster.
        /// </value>
        [JsonProperty(PropertyName = "targetNodeCount")]
        public System.Nullable<int> TargetNodeCount { get; set; }
        
    }
}
