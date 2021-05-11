/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.UsageapiService.Models
{
    /// <summary>
    /// The common fields for Cost Analysis UI rendering.
    /// </summary>
    public class CostAnalysisUI 
    {
                ///
        /// <value>
        /// the type of graph mode.
        /// </value>
        ///
        public enum GraphEnum {
            [EnumMember(Value = "BARS")]
            Bars,
            [EnumMember(Value = "LINES")]
            Lines,
            [EnumMember(Value = "STACKED_LINES")]
            StackedLines
        };

        /// <value>
        /// the type of graph mode.
        /// </value>
        [JsonProperty(PropertyName = "graph")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<GraphEnum> Graph { get; set; }
        
        /// <value>
        /// is cumulative graph.
        /// </value>
        [JsonProperty(PropertyName = "isCumulativeGraph")]
        public System.Nullable<bool> IsCumulativeGraph { get; set; }
        
    }
}