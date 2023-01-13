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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Details of a schema fetched from the database.
    /// </summary>
    public class SchemaSummary 
    {
        
        /// <value>
        /// Name of the schema.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SchemaName is required.")]
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }
        
        /// <value>
        /// Indicates if the schema is oracle supplied.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsOracleMaintained is required.")]
        [JsonProperty(PropertyName = "isOracleMaintained")]
        public System.Nullable<bool> IsOracleMaintained { get; set; }
        
    }
}
