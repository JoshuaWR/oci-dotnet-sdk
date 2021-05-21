/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The AWR top wait event data.
    /// </summary>
    public class AwrDbTopWaitEventCollection : AwrQueryResult
    {
        
        /// <value>
        /// A list of AWR top event summary data.
        /// </value>
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<AwrDbTopWaitEventSummary> Items { get; set; }
        
        [JsonProperty(PropertyName = "awrResultType")]
        private readonly string awrResultType = "AWRDB_TOP_EVENT_SET";
    }
}
