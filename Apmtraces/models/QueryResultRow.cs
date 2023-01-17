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
    /// Object that represents a single row of the query result.  It contains the queryResultRowData object that contains the actual data
    /// represented by the elements of the query result row, and a queryResultRowMetadata object that contains the metadata about the data contained in
    /// the query result row.
    /// 
    /// </summary>
    public class QueryResultRow 
    {
        
        /// <value>
        /// A map containing the actual data represented by a single row of the query result.
        /// The key is the column name or attribute specified in the show clause, or an aggregate function in the show clause.
        /// The value is the actual value of that attribute or aggregate function of the corresponding single row of the query result set.
        /// If an alias name is specified for an attribute or an aggregate function, then the key will be the alias name specified in the show
        /// clause.  If an alias name is not specified for the group by aggregate function in the show clause, then the corresponding key
        /// will be the appropriate aggregate_function_name_column_name (For Example: count(traces) will be keyed as count_traces).  The datatype of the valueis presented in the queryResultRowTypeSummaries list in the queryResultMetadata structure, where the i-th queryResultRowTypeSummary objectrepresents the datatype of the i-th value when this map is iterated in order.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "QueryResultRowData is required.")]
        [JsonProperty(PropertyName = "queryResultRowData")]
        public System.Collections.Generic.Dictionary<string, System.Object> QueryResultRowData { get; set; }
        
        /// <value>
        /// A map containing metadata or add-on data for the data presented in the queryResultRowData map.  Data required to present drill down
        /// information from the queryResultRowData is presented as key-value pairs.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "QueryResultRowMetadata is required.")]
        [JsonProperty(PropertyName = "queryResultRowMetadata")]
        public System.Collections.Generic.Dictionary<string, System.Object> QueryResultRowMetadata { get; set; }
        
    }
}
