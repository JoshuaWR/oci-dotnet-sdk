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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// The maximum possible date and time that a maintenance reboot can be extended.
    /// </summary>
    public class InstanceMaintenanceReboot 
    {
        
        /// <value>
        /// The maximum extension date and time for the maintenance reboot, in the format defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// The range for the maintenance extension is between 1 and 14 days from the initial scheduled maintenance date.
        /// Example: 2018-05-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeMaintenanceRebootDueMax is required.")]
        [JsonProperty(PropertyName = "timeMaintenanceRebootDueMax")]
        public System.Nullable<System.DateTime> TimeMaintenanceRebootDueMax { get; set; }
        
    }
}
