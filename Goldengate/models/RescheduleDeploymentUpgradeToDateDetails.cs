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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Definition of the additional attributes for default deployment upgrade cancel.
    /// </summary>
    public class RescheduleDeploymentUpgradeToDateDetails : RescheduleDeploymentUpgradeDetails
    {
        
        /// <value>
        /// The time of upgrade schedule. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeSchedule is required.")]
        [JsonProperty(PropertyName = "timeSchedule")]
        public System.Nullable<System.DateTime> TimeSchedule { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "RESCHEDULE_TO_DATE";
    }
}