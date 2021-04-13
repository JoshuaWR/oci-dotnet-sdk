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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Hardware Configuration metric for the host
    /// 
    /// </summary>
    public class HostHardwareConfiguration : HostConfigurationMetricGroup
    {
        
        /// <value>
        /// Processor architecture used by the platform
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuArchitecture is required.")]
        [JsonProperty(PropertyName = "cpuArchitecture")]
        public string CpuArchitecture { get; set; }
        
        [JsonProperty(PropertyName = "metricName")]
        private readonly string metricName = "HOST_HARDWARE_CONFIGURATION";
    }
}
