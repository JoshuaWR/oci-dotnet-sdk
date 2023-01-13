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
    /// Aggregated data for top processes on a specific date.
    /// </summary>
    public class TopProcessesUsage 
    {
        
        /// <value>
        /// Command line and arguments used to launch process.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Command is required.")]
        [JsonProperty(PropertyName = "command")]
        public string Command { get; set; }
        
        /// <value>
        /// Unique identifier for a process.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProcessHash is required.")]
        [JsonProperty(PropertyName = "processHash")]
        public string ProcessHash { get; set; }
        
        /// <value>
        /// Process CPU usage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuUsage is required.")]
        [JsonProperty(PropertyName = "cpuUsage")]
        public System.Double CpuUsage { get; set; }
        
        /// <value>
        /// Process CPU utilization percentage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuUtilization is required.")]
        [JsonProperty(PropertyName = "cpuUtilization")]
        public System.Double CpuUtilization { get; set; }
        
        /// <value>
        /// Process memory utilization percentage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MemoryUtilization is required.")]
        [JsonProperty(PropertyName = "memoryUtilization")]
        public System.Double MemoryUtilization { get; set; }
        
        /// <value>
        /// Process virtual memory in Megabytes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VirtualMemoryInMBs is required.")]
        [JsonProperty(PropertyName = "virtualMemoryInMBs")]
        public System.Double VirtualMemoryInMBs { get; set; }
        
        /// <value>
        /// Procress physical memory in Megabytes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PhysicalMemoryInMBs is required.")]
        [JsonProperty(PropertyName = "physicalMemoryInMBs")]
        public System.Double PhysicalMemoryInMBs { get; set; }
        
        /// <value>
        /// Maximum number of processes running at time of collection.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaxProcessCount is required.")]
        [JsonProperty(PropertyName = "maxProcessCount")]
        public System.Nullable<int> MaxProcessCount { get; set; }
        
    }
}
