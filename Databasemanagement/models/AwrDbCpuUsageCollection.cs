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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The AWR CPU usage data.
    /// </summary>
    public class AwrDbCpuUsageCollection : AwrQueryResult
    {
        
        /// <value>
        /// The number of available CPU cores, which include subcores of multicore and single-core CPUs.
        /// </value>
        [JsonProperty(PropertyName = "numCpuCores")]
        public System.Nullable<int> NumCpuCores { get; set; }
        
        /// <value>
        /// The number of CPUs available for the database to use.
        /// </value>
        [JsonProperty(PropertyName = "cpuCount")]
        public System.Nullable<int> CpuCount { get; set; }
        
        /// <value>
        /// The number of available CPUs or processors.
        /// </value>
        [JsonProperty(PropertyName = "numCpus")]
        public System.Double NumCpus { get; set; }
        
        /// <value>
        /// A list of AWR CPU usage summary data.
        /// </value>
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<AwrDbCpuUsageSummary> Items { get; set; }
        
        [JsonProperty(PropertyName = "awrResultType")]
        private readonly string awrResultType = "AWRDB_ASH_CPU_USAGE_SET";
    }
}
