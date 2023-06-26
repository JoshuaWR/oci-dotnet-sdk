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
    /// An alert from the Exadata storage server.
    /// </summary>
    public class OpenAlertSummary 
    {
        
        /// <value>
        /// The severity of the alert.
        /// </value>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AlertSeverityEnum> Severity { get; set; }
        
        /// <value>
        /// The type of alert.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AlertTypeEnum> Type { get; set; }
        
        /// <value>
        /// The start time of the alert.
        /// </value>
        [JsonProperty(PropertyName = "timeStartAt")]
        public System.Nullable<System.DateTime> TimeStartAt { get; set; }
        
        /// <value>
        /// The alert message.
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
    }
}
