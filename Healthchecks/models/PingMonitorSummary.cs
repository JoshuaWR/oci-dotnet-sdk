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


namespace Oci.HealthchecksService.Models
{
    /// <summary>
    /// This model contains all of the mutable and immutable summary properties for an HTTP monitor.
    /// 
    /// </summary>
    public class PingMonitorSummary 
    {
        
        /// <value>
        /// The OCID of the resource.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A URL for fetching the probe results.
        /// </value>
        [JsonProperty(PropertyName = "resultsUrl")]
        public string ResultsUrl { get; set; }
        
        /// <value>
        /// The region where updates must be made and where results must be fetched from.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "homeRegion")]
        public string HomeRegion { get; set; }
        
        /// <value>
        /// The RFC 3339-formatted creation date and time of the probe.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly and mutable name suitable for display in a user interface.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The monitor interval in seconds. Valid values: 10, 30, and 60.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "intervalInSeconds")]
        public System.Nullable<int> IntervalInSeconds { get; set; }
        
        /// <value>
        /// Enables or disables the monitor. Set to 'true' to launch monitoring.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace.  For more information,
        /// see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PingProbeProtocol> Protocol { get; set; }
        
    }
}
