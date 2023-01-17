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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Insights response containing current/projected groups for CPU or memory.
    /// 
    /// </summary>
    public class SummarizeHostInsightResourceUtilizationInsightAggregation 
    {
        
        /// <value>
        /// The start timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalStart is required.")]
        [JsonProperty(PropertyName = "timeIntervalStart")]
        public System.Nullable<System.DateTime> TimeIntervalStart { get; set; }
        
        /// <value>
        /// The end timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalEnd is required.")]
        [JsonProperty(PropertyName = "timeIntervalEnd")]
        public System.Nullable<System.DateTime> TimeIntervalEnd { get; set; }
                ///
        /// <value>
        /// Defines the type of resource metric (CPU, Physical Memory, Logical Memory)
        /// 
        /// </value>
        ///
        public enum ResourceMetricEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CPU")]
            Cpu,
            [EnumMember(Value = "MEMORY")]
            Memory,
            [EnumMember(Value = "LOGICAL_MEMORY")]
            LogicalMemory
        };

        /// <value>
        /// Defines the type of resource metric (CPU, Physical Memory, Logical Memory)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceMetric is required.")]
        [JsonProperty(PropertyName = "resourceMetric")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceMetricEnum> ResourceMetric { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProjectedUtilization is required.")]
        [JsonProperty(PropertyName = "projectedUtilization")]
        public ResourceInsightProjectedUtilization ProjectedUtilization { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CurrentUtilization is required.")]
        [JsonProperty(PropertyName = "currentUtilization")]
        public ResourceInsightCurrentUtilization CurrentUtilization { get; set; }
        
    }
}
