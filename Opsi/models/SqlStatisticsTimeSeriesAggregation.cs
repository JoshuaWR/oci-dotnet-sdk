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
    /// Database details and SQL performance statistics for a given database
    /// </summary>
    public class SqlStatisticsTimeSeriesAggregation 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseDetails is required.")]
        [JsonProperty(PropertyName = "databaseDetails")]
        public DatabaseDetails DatabaseDetails { get; set; }
        
        /// <value>
        /// SQL performance statistics for a given database
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Statistics is required.")]
        [JsonProperty(PropertyName = "statistics")]
        public System.Collections.Generic.List<SqlStatisticsTimeSeries> Statistics { get; set; }
        
    }
}
