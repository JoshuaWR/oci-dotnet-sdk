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


namespace Oci.RoverService.Models
{
    /// <summary>
    /// Information about a RoverWorkload.
    /// </summary>
    public class RoverWorkload 
    {
        
        /// <value>
        /// Name of the Rover Workload
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the workload.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The Unique Oracle ID (OCID) that is immutable on creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Size of the workload.
        /// </value>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }
        
        /// <value>
        /// Number of objects in a workload.
        /// </value>
        [JsonProperty(PropertyName = "objectCount")]
        public string ObjectCount { get; set; }
        
        /// <value>
        /// Prefix to filter objects in case it is a bucket.
        /// </value>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }
        
        /// <value>
        /// Start of the range in a bucket.
        /// </value>
        [JsonProperty(PropertyName = "rangeStart")]
        public string RangeStart { get; set; }
        
        /// <value>
        /// End of the range in a bucket.
        /// </value>
        [JsonProperty(PropertyName = "rangeEnd")]
        public string RangeEnd { get; set; }
        
        /// <value>
        /// The type of workload
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WorkloadType is required.")]
        [JsonProperty(PropertyName = "workloadType")]
        public string WorkloadType { get; set; }
        
        /// <value>
        /// The compute work request id to track progress of custom image exports.
        /// </value>
        [JsonProperty(PropertyName = "workRequestId")]
        public string WorkRequestId { get; set; }
        
    }
}
