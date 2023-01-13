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
    /// StatusSummary
    /// </summary>
    public class StatusSummary 
    {
        
        /// <value>
        /// The number of chunks processed.
        /// </value>
        [JsonProperty(PropertyName = "chunksProcessed")]
        public System.Nullable<long> ChunksProcessed { get; set; }
        
        /// <value>
        /// The failure details, if any.
        /// </value>
        [JsonProperty(PropertyName = "failureDetails")]
        public string FailureDetails { get; set; }
        
        /// <value>
        /// The filename.
        /// </value>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }
        
        /// <value>
        /// The status.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        /// <value>
        /// The total number of chunks.
        /// </value>
        [JsonProperty(PropertyName = "totalChunks")]
        public System.Nullable<long> TotalChunks { get; set; }
        
    }
}
