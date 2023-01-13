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


namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// The information about scheduled refresh.
    /// </summary>
    public class UpdateRefreshActivityDetails 
    {
        
        /// <value>
        /// Time the refresh activity is scheduled to start. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeScheduledStart")]
        public System.Nullable<System.DateTime> TimeScheduledStart { get; set; }
        
    }
}
