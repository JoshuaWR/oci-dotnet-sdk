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


namespace Oci.DatalabelingservicedataplaneService.Models
{
    /// <summary>
    /// Metadata of delimited files.
    /// </summary>
    public class DelimitedFileTypeMetadata : TextFileTypeMetadata
    {
        
        /// <value>
        /// The name of a selected column.
        /// </value>
        [JsonProperty(PropertyName = "columnName")]
        public string ColumnName { get; set; }
        
        /// <value>
        /// The index of a selected column. This is a zero-based index.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ColumnIndex is required.")]
        [JsonProperty(PropertyName = "columnIndex")]
        public System.Nullable<int> ColumnIndex { get; set; }
        
        /// <value>
        /// A column delimiter
        /// </value>
        [JsonProperty(PropertyName = "columnDelimiter")]
        public string ColumnDelimiter { get; set; }
        
        /// <value>
        /// A line delimiter.
        /// </value>
        [JsonProperty(PropertyName = "lineDelimiter")]
        public string LineDelimiter { get; set; }
        
        /// <value>
        /// An escape character.
        /// </value>
        [JsonProperty(PropertyName = "escapeCharacter")]
        public string EscapeCharacter { get; set; }
        
        [JsonProperty(PropertyName = "formatType")]
        private readonly string formatType = "DELIMITED";
    }
}
