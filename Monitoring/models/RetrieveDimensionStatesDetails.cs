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


namespace Oci.MonitoringService.Models
{
    /// <summary>
    /// The configuration details for retrieving the alarm state entries.
    /// Filter retrieved alarm state entries by status value and dimension key-value pairs.
    /// 
    /// </summary>
    public class RetrieveDimensionStatesDetails 
    {
        
        /// <value>
        /// A filter to return only alarm state entries that match the exact set of specified dimension key-value pairs.
        /// If you specify `\"availabilityDomain\": \"phx-ad-1\"` but the alarm state entry corresponds to the set `\"availabilityDomain\": \"phx-ad-1\"`
        /// and `\"resourceId\": \"ocid1.instance.region1.phx.exampleuniqueID\"`, then no results are returned.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dimensionFilters")]
        public System.Collections.Generic.Dictionary<string, string> DimensionFilters { get; set; }
        
        /// <value>
        /// A filter to return only alarm state entries that match the status value.
        /// Example: FIRING
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AlarmDimensionStatesEntry.StatusEnum> Status { get; set; }
        
    }
}
