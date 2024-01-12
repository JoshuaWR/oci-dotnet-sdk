/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// The details of the peer database used for updating the peer target database in Data Safe.
    /// </summary>
    public class UpdatePeerTargetDatabaseDetails 
    {
        
        /// <value>
        /// The display name of the peer target database in Data Safe.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The description of the peer target database in Data Safe.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        [JsonProperty(PropertyName = "databaseDetails")]
        public DatabaseDetails DatabaseDetails { get; set; }
        
        [JsonProperty(PropertyName = "tlsConfig")]
        public TlsConfig TlsConfig { get; set; }
        
    }
}
