/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// The configuration details for updating a load balancer backend set.
    /// For more information about backend set configuration, see
    /// [Managing Backend Sets](https://docs.cloud.oracle.com/Content/NetworkLoadBalancer/BackendSets/backend-set-management.htm).
    /// <br/>
    /// **Caution:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class UpdateBackendSetDetails 
    {
        
        /// <value>
        /// The network load balancer policy for the backend set. To get a list of available policies, use the
        /// {@link #listNetworkLoadBalancersPolicies(ListNetworkLoadBalancersPoliciesRequest) listNetworkLoadBalancersPolicies} operation.
        /// <br/>
        /// Example: FIVE_TUPLE
        /// </value>
        [JsonProperty(PropertyName = "policy")]
        public string Policy { get; set; }
        
        /// <value>
        /// If this parameter is enabled, then the network load balancer preserves the source IP of the packet when it is forwarded to backends.
        /// Backends see the original source IP. If the isPreserveSourceDestination parameter is enabled for the network load balancer resource, then this parameter cannot be disabled.
        /// The value is true by default.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isPreserveSource")]
        public System.Nullable<bool> IsPreserveSource { get; set; }
        
        /// <value>
        /// The IP version associated with the backend set.
        /// </value>
        [JsonProperty(PropertyName = "ipVersion")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<IpVersion> IpVersion { get; set; }
        
        /// <value>
        /// An array of backends associated with the backend set.
        /// </value>
        [JsonProperty(PropertyName = "backends")]
        public System.Collections.Generic.List<BackendDetails> Backends { get; set; }
        
        [JsonProperty(PropertyName = "healthChecker")]
        public HealthCheckerDetails HealthChecker { get; set; }
        
    }
}
