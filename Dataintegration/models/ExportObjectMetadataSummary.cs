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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Details of the exported object
    /// </summary>
    public class ExportObjectMetadataSummary 
    {
        
        /// <value>
        /// Key of the object
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Name of the object
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Object identifier
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// Object type
        /// </value>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }
        
        /// <value>
        /// Object version
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public string ObjectVersion { get; set; }
        
        /// <value>
        /// Aggregator key
        /// </value>
        [JsonProperty(PropertyName = "aggregatorKey")]
        public string AggregatorKey { get; set; }
        
        /// <value>
        /// Object name path
        /// </value>
        [JsonProperty(PropertyName = "namePath")]
        public string NamePath { get; set; }
        
        /// <value>
        /// time at which this object was last updated.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdatedInMillis")]
        public System.Nullable<long> TimeUpdatedInMillis { get; set; }
        
    }
}