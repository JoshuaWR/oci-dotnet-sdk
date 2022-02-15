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
    /// The Delete Rows masking format deletes the rows that meet a user-specified
    /// condition. It is useful in conditional masking when you want to delete a
    /// subset of values in a column and mask the remaining values using some other
    /// masking formats. You should be careful while using this masking format. If
    /// no condition is specified, all rows in a table are deleted. If a column is
    /// being masked using Delete Rows, there must not be a foreign key constraint
    /// or dependent column referring to the table. To learn more, check Delete Rows
    /// in the Data Safe documentation. 
    /// 
    /// </summary>
    public class DeleteRowsFormatEntry : FormatEntry
    {
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "DELETE_ROWS";
    }
}