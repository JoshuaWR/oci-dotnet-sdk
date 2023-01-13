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


namespace Oci.NetworkloadbalancerService.Models
{
    /// <summary>
    /// An object representing an updated list of network security groups that overwrites the existing list of network security groups.
    /// *  If the network load balancer has no configured network security groups, then the network load balancer uses the network security groups in this list.
    /// *  If the network load balancer has a list of configured network security groups, then this list replaces the existing list.
    /// *  If the network load balancer has a list of configured network security groups and this list is empty, then the operation removes all of the network security groups associated with the network load balancer.
    /// </summary>
    public class UpdateNetworkSecurityGroupsDetails 
    {
        
        /// <value>
        /// An array of network security group [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) associated with the network load
        /// balancer.
        /// <br/>
        /// During the creation of the network load balancer, the service adds the new network load balancer to the specified network security groups.
        /// <br/>
        /// The benefits of associating the network load balancer with network security groups include:
        /// <br/>
        /// *  Network security groups define network security rules to govern ingress and egress traffic for the network load balancer.
        /// <br/>
        /// *  The network security rules of other resources can reference the network security groups associated with the network load balancer
        ///    to ensure access.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "networkSecurityGroupIds")]
        public System.Collections.Generic.List<string> NetworkSecurityGroupIds { get; set; }
        
    }
}
