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
    /// The attributes of a sensitive column that have been modified in the target database. It's populated only in the case
    /// of MODIFIED discovery results and shows the new values of the modified attributes.
    /// 
    /// </summary>
    public class ModifiedAttributes 
    {
        
        /// <value>
        /// Unique keys identifying the columns that are application-level (non-dictionary) children of the sensitive column.
        /// </value>
        [JsonProperty(PropertyName = "appDefinedChildColumnKeys")]
        public System.Collections.Generic.List<string> AppDefinedChildColumnKeys { get; set; }
        
        /// <value>
        /// Unique keys identifying the columns that are database-level (dictionary-defined) children of the sensitive column.
        /// </value>
        [JsonProperty(PropertyName = "dbDefinedChildColumnKeys")]
        public System.Collections.Generic.List<string> DbDefinedChildColumnKeys { get; set; }
        
    }
}
