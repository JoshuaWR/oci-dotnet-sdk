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


namespace Oci.LoggingService.Models
{
    /// <summary>
    /// The details to create a log object.
    /// </summary>
    public class CreateLogDetails 
    {
        
        /// <value>
        /// The user-friendly display name. This must be unique within the enclosing resource,
        /// and it's changeable. Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The logType that the log object is for, whether custom or service.
        /// </value>
        ///
        public enum LogTypeEnum {
            [EnumMember(Value = "CUSTOM")]
            Custom,
            [EnumMember(Value = "SERVICE")]
            Service
        };

        /// <value>
        /// The logType that the log object is for, whether custom or service.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogType is required.")]
        [JsonProperty(PropertyName = "logType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LogTypeEnum> LogType { get; set; }
        
        /// <value>
        /// Whether or not this resource is currently enabled.
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        [JsonProperty(PropertyName = "configuration")]
        public Configuration Configuration { get; set; }
        
        /// <value>
        /// Log retention duration in 30-day increments (30, 60, 90 and so on).
        /// </value>
        [JsonProperty(PropertyName = "retentionDuration")]
        public System.Nullable<int> RetentionDuration { get; set; }
        
    }
}
