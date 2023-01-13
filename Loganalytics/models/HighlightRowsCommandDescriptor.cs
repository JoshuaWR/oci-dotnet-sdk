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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Command descriptor for querylanguage HIGHLIGHTROWS command.
    /// 
    /// </summary>
    public class HighlightRowsCommandDescriptor : AbstractCommandDescriptor
    {
        
        /// <value>
        /// User specified color to highlight matches with if found.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }
        
        /// <value>
        /// List of terms or phrases to find to mark the result row as highlighted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keywords")]
        public System.Collections.Generic.List<string> Keywords { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        private readonly string name = "HIGHLIGHT_ROWS";
    }
}
