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


namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// The Excel format attribute.
    /// </summary>
    public class ExcelFormatAttribute : AbstractFormatAttribute
    {
        
        /// <value>
        /// Range of the data. For example, \"'My Sheet'!B3:C35\"
        /// </value>
        [JsonProperty(PropertyName = "dataAddress")]
        public string DataAddress { get; set; }
        
        /// <value>
        /// Whether the dataAddress contains the header with column names. If false - column names fill be generated.
        /// </value>
        [JsonProperty(PropertyName = "header")]
        public System.Nullable<bool> Header { get; set; }
        
        /// <value>
        /// Workbook password if it is password protected.
        /// </value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "EXCEL_FORMAT";
    }
}