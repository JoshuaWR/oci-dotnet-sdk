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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The details for calculating audit data volume on target.
    /// </summary>
    public class CalculateAuditVolumeAvailableDetails 
    {
        
        /// <value>
        /// The date from which the audit trail must start collecting data in UTC, in the format defined by RFC3339. If not specified, this will default to the date based on the retention period.
        /// </value>
        [JsonProperty(PropertyName = "auditCollectionStartTime")]
        public System.Nullable<System.DateTime> AuditCollectionStartTime { get; set; }
        
        /// <value>
        /// The trail locations for which the audit data volume has to be calculated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TrailLocations is required.")]
        [JsonProperty(PropertyName = "trailLocations")]
        public System.Collections.Generic.List<string> TrailLocations { get; set; }
        
    }
}
