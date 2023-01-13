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


namespace Oci.NosqlService.Models
{
    /// <summary>
    /// The usage metrics for a request.
    /// </summary>
    public class RequestUsage 
    {
        
        /// <value>
        /// Read Units consumed by this operation.
        /// </value>
        [JsonProperty(PropertyName = "readUnitsConsumed")]
        public System.Nullable<int> ReadUnitsConsumed { get; set; }
        
        /// <value>
        /// Write Units consumed by this operation.
        /// </value>
        [JsonProperty(PropertyName = "writeUnitsConsumed")]
        public System.Nullable<int> WriteUnitsConsumed { get; set; }
        
    }
}
