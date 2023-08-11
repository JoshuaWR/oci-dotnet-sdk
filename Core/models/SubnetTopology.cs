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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Defines the visualization of a subnet in a VCN. 
    /// See [Network Visualizer Documentation](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/network_visualizer.htm) for more information, including
    /// conventions and pictures of symbols.
    /// 
    /// </summary>
    public class SubnetTopology : Topology
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the subnet for which the visualization is generated.
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "SUBNET";
    }
}
