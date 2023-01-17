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


namespace Oci.LoggingsearchService.Models
{
    /// <summary>
    /// Search request object.
    /// </summary>
    public class SearchLogsDetails 
    {
        
        /// <value>
        /// Start filter log's date and time, in the format defined by RFC3339.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStart is required.")]
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// End filter log's date and time, in the format defined by RFC3339.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeEnd is required.")]
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// Query corresponding to the search operation. This query is parsed and validated before execution and
        /// should follow the specification. For more information on the query language specification, see
        /// [Logging Query Language Specification](https://docs.cloud.oracle.com/Content/Logging/Reference/query_language_specification.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SearchQuery is required.")]
        [JsonProperty(PropertyName = "searchQuery")]
        public string SearchQuery { get; set; }
        
        /// <value>
        /// Whether to return field schema information for the log stream specified in searchQuery.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isReturnFieldInfo")]
        public System.Nullable<bool> IsReturnFieldInfo { get; set; }
        
    }
}
