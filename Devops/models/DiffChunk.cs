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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Details about a group of changes.
    /// </summary>
    public class DiffChunk 
    {
        
        /// <value>
        /// Line number in base version where changes begin.
        /// </value>
        [JsonProperty(PropertyName = "baseLine")]
        public System.Nullable<int> BaseLine { get; set; }
        
        /// <value>
        /// Number of lines chunk spans in base version.
        /// </value>
        [JsonProperty(PropertyName = "baseSpan")]
        public System.Nullable<int> BaseSpan { get; set; }
        
        /// <value>
        /// Line number in target version where changes begin.
        /// </value>
        [JsonProperty(PropertyName = "targetLine")]
        public System.Nullable<int> TargetLine { get; set; }
        
        /// <value>
        /// Number of lines chunk spans in target version.
        /// </value>
        [JsonProperty(PropertyName = "targetSpan")]
        public System.Nullable<int> TargetSpan { get; set; }
        
        /// <value>
        /// List of difference section.
        /// </value>
        [JsonProperty(PropertyName = "diffSections")]
        public System.Collections.Generic.List<DiffSection> DiffSections { get; set; }
        
    }
}
