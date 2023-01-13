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
    /// Collection of result set rows from the data object query.
    /// </summary>
    public class QueryDataObjectJsonResultSetRowsCollection : QueryDataObjectResultSetRowsCollection
    {
        
        /// <value>
        /// Array of result set rows.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<System.Object> Items { get; set; }
        
        /// <value>
        /// Array of QueryDataObjectResultSetColumnMetadata objects that describe the result set columns.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ItemsMetadata is required.")]
        [JsonProperty(PropertyName = "itemsMetadata")]
        public System.Collections.Generic.List<QueryDataObjectResultSetColumnMetadata> ItemsMetadata { get; set; }
        
        [JsonProperty(PropertyName = "format")]
        private readonly string format = "JSON";
    }
}
