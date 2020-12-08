/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LoggingingestionService.Models
{
    /// <summary>
    /// A single batch of Log Entries.
    /// </summary>
    public class LogEntryBatch 
    {
        
        /// <value>
        /// List of data entries.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Entries is required.")]
        [JsonProperty(PropertyName = "entries")]
        public System.Collections.Generic.List<LogEntry> Entries { get; set; }
        
        /// <value>
        /// Source of the logs that generated the message. This could be the
        /// instance name, hostname, or the source used to read the event. For example, \"ServerA\".
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Source is required.")]
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }
        
        /// <value>
        /// This field signifies the type of logs being ingested.
        /// For Example: ServerA.requestLogs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// This optional field is useful for specifying the specific sub-resource
        /// or input file used to read the event.
        /// For Example: &quot;/var/log/application.log&quot;.
        /// </value>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }
        
        /// <value>
        /// The timestamp for all log entries in this batch. This can be
        /// considered as the default timestamp for each entry, unless it is
        /// overwritten by the entry time. An RFC3339-formatted date-time
        /// string.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Defaultlogentrytime is required.")]
        [JsonProperty(PropertyName = "defaultlogentrytime")]
        public System.Nullable<System.DateTime> Defaultlogentrytime { get; set; }
        
    }
}