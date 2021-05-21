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


namespace Oci.BastionService.Models
{
    /// <summary>
    /// Details about a port forwarding session for a target resource.
    /// </summary>
    public class PortForwardingSessionTargetResourceDetails : TargetResourceDetails
    {
        
        /// <value>
        /// The unique identifier (OCID) of the target resource (a Compute instance, for example) that the session connects to.
        /// </value>
        [JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId { get; set; }
        
        /// <value>
        /// The private IP address of the target resource that the session connects to.
        /// </value>
        [JsonProperty(PropertyName = "targetResourcePrivateIpAddress")]
        public string TargetResourcePrivateIpAddress { get; set; }
        
        /// <value>
        /// The display name of the target Compute instance that the session connects to.
        /// </value>
        [JsonProperty(PropertyName = "targetResourceDisplayName")]
        public string TargetResourceDisplayName { get; set; }
        
        [JsonProperty(PropertyName = "sessionType")]
        private readonly string sessionType = "PORT_FORWARDING";
    }
}
