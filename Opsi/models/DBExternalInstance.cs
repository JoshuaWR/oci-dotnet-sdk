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
    /// Configuration parameters defined for external databases instance level.
    /// </summary>
    public class DBExternalInstance : DatabaseConfigurationMetricGroup
    {
        
        /// <value>
        /// Name of the database instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceName is required.")]
        [JsonProperty(PropertyName = "instanceName")]
        public string InstanceName { get; set; }
        
        /// <value>
        /// Host name of the database instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostName is required.")]
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
        
        /// <value>
        /// Total number of CPUs allocated for the host.
        /// </value>
        [JsonProperty(PropertyName = "cpuCount")]
        public System.Nullable<int> CpuCount { get; set; }
        
        /// <value>
        /// Total amount of usable Physical RAM Memory available in gigabytes.
        /// </value>
        [JsonProperty(PropertyName = "hostMemoryCapacity")]
        public System.Double HostMemoryCapacity { get; set; }
        
        /// <value>
        /// Database version.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// Indicates whether the instance is mounted in cluster database mode (YES) or not (NO).
        /// </value>
        [JsonProperty(PropertyName = "parallel")]
        public string Parallel { get; set; }
        
        /// <value>
        /// Role (permissions) of the database instance.
        /// </value>
        [JsonProperty(PropertyName = "instanceRole")]
        public string InstanceRole { get; set; }
        
        /// <value>
        /// Indicates if logins are allowed or restricted.
        /// </value>
        [JsonProperty(PropertyName = "logins")]
        public string Logins { get; set; }
        
        /// <value>
        /// Status of the database.
        /// </value>
        [JsonProperty(PropertyName = "databaseStatus")]
        public string DatabaseStatus { get; set; }
        
        /// <value>
        /// Status of the instance.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        /// <value>
        /// The edition of the database.
        /// </value>
        [JsonProperty(PropertyName = "edition")]
        public string Edition { get; set; }
        
        /// <value>
        /// Start up time of the database instance.
        /// </value>
        [JsonProperty(PropertyName = "startupTime")]
        public System.Nullable<System.DateTime> StartupTime { get; set; }
        
        [JsonProperty(PropertyName = "metricName")]
        private readonly string metricName = "DB_EXTERNAL_INSTANCE";
    }
}
