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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Connection strings to connect to an Oracle Database.
    /// 
    /// </summary>
    public class DatabaseConnectionStrings 
    {
        
        /// <value>
        /// Host name based CDB Connection String.
        /// </value>
        [JsonProperty(PropertyName = "cdbDefault")]
        public string CdbDefault { get; set; }
        
        /// <value>
        /// IP based CDB Connection String.
        /// </value>
        [JsonProperty(PropertyName = "cdbIpDefault")]
        public string CdbIpDefault { get; set; }
        
        /// <value>
        /// All connection strings to use to connect to the Database.
        /// </value>
        [JsonProperty(PropertyName = "allConnectionStrings")]
        public System.Collections.Generic.Dictionary<string, string> AllConnectionStrings { get; set; }
        
    }
}
