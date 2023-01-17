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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// An object representing an updated list of network security groups (NSGs) that overwrites the existing list of NSGs.
    /// *  If the load balancer has no NSGs configured, it uses the NSGs in this list.
    /// *  If the load balancer has a list of NSGs configured, this list replaces the existing list.
    /// *  If the load balancer has a list of NSGs configured and this list is empty, the operation removes all of the load balancer's NSG associations.
    /// </summary>
    public class UpdateNetworkSecurityGroupsDetails 
    {
        
        /// <value>
        /// An array of NSG [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) associated with the load
        /// balancer.
        /// <br/>
        /// During the load balancer's creation, the service adds the new load balancer to the specified NSGs.
        /// <br/>
        /// The benefits of associating the load balancer with NSGs include:
        /// <br/>
        /// *  NSGs define network security rules to govern ingress and egress traffic for the load balancer.
        /// <br/>
        /// *  The network security rules of other resources can reference the NSGs associated with the load balancer
        ///    to ensure access.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "networkSecurityGroupIds")]
        public System.Collections.Generic.List<string> NetworkSecurityGroupIds { get; set; }
        
    }
}
