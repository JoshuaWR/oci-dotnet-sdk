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


namespace Oci.ApmtracesService.Models
{
    /// <summary>
    /// Summary containing the metadata about the query result set.
    /// 
    /// </summary>
    public class QueryResultMetadataSummary 
    {
        
        /// <value>
        /// A collection of QueryResultRowTypeSummary objects that describe the type and properties of the individual row elements of the query rows
        /// being returned.  The i-th element in this list contains the QueryResultRowTypeSummary of the i-th key-value pair in the QueryResultRowData map.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "queryResultRowTypeSummaries")]
        public System.Collections.Generic.List<QueryResultRowTypeSummary> QueryResultRowTypeSummaries { get; set; }
        
        /// <value>
        /// Source of the query result set (traces, spans, and so on).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceName")]
        public string SourceName { get; set; }
        
        /// <value>
        /// Columns or attributes of the query rows  which are group by values.  This is a list of ResultsGroupedBy summary objects,
        /// and the list will contain as many elements as the attributes and aggregate functions in the group by clause in the select query.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "queryResultsGroupedBy")]
        public System.Collections.Generic.List<QueryResultsGroupedBySummary> QueryResultsGroupedBy { get; set; }
        
        /// <value>
        /// Order by which the query results are organized.  This is a list of queryResultsOrderedBy summary objects, and the list
        /// will contain more than one OrderedBy summary object, if the sort was multidimensional.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "queryResultsOrderedBy")]
        public System.Collections.Generic.List<QueryResultsOrderedBySummary> QueryResultsOrderedBy { get; set; }
        
        /// <value>
        /// Interval for the time series function in minutes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeSeriesIntervalInMins")]
        public System.Nullable<int> TimeSeriesIntervalInMins { get; set; }
        
    }
}
