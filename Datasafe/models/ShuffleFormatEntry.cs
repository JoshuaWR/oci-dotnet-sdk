/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The Shuffle masking format randomly shuffles values within a column. It
    /// can also be used to shuffle column data within discrete units, or groups,
    /// where there is a relationship among the members of each group. To learn more,
    /// check Shuffle in the Data Safe documentation. The Shuffle masking format
    /// randomly shuffles values within a column. It can also be used to shuffle
    /// column data within discrete units, or groups, where there is a relationship
    /// among the members of each group. To learn more, check Shuffle in the
    /// Data Safe documentation.
    /// 
    /// </summary>
    public class ShuffleFormatEntry : FormatEntry
    {
        
        /// <value>
        /// One or more reference columns to be used to group column values so that
        /// they can be shuffled within their own group. The grouping columns and 
        /// the column to be masked must belong to the same table. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "groupingColumns")]
        public System.Collections.Generic.List<string> GroupingColumns { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "SHUFFLE";
    }
}
