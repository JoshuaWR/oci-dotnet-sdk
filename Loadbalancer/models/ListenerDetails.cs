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
    /// The listener's configuration details.
    /// </summary>
    public class ListenerDetails 
    {
        
        /// <value>
        /// The name of the associated backend set.
        /// <br/>
        /// Example: example_backend_set
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefaultBackendSetName is required.")]
        [JsonProperty(PropertyName = "defaultBackendSetName")]
        public string DefaultBackendSetName { get; set; }
        
        /// <value>
        /// The communication port for the listener.
        /// <br/>
        /// Example: 80
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The protocol on which the listener accepts connection requests.
        /// To get a list of valid protocols, use the {@link #listProtocols(ListProtocolsRequest) listProtocols}
        /// operation.
        /// <br/>
        /// Example: HTTP
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }
        
        /// <value>
        /// An array of hostname resource names.
        /// </value>
        [JsonProperty(PropertyName = "hostnameNames")]
        public System.Collections.Generic.List<string> HostnameNames { get; set; }
        
        /// <value>
        /// Deprecated. Please use `routingPolicies` instead.
        /// <br/>
        /// The name of the set of path-based routing rules, {@link PathRouteSet},
        /// applied to this listener's traffic.
        /// <br/>
        /// Example: example_path_route_set
        /// </value>
        [JsonProperty(PropertyName = "pathRouteSetName")]
        public string PathRouteSetName { get; set; }
        
        [JsonProperty(PropertyName = "sslConfiguration")]
        public SSLConfigurationDetails SslConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "connectionConfiguration")]
        public ConnectionConfiguration ConnectionConfiguration { get; set; }
        
        /// <value>
        /// The name of the routing policy applied to this listener's traffic.
        /// <br/>
        /// Example: example_routing_policy
        /// </value>
        [JsonProperty(PropertyName = "routingPolicyName")]
        public string RoutingPolicyName { get; set; }
        
        /// <value>
        /// The names of the {@link RuleSet} to apply to the listener.
        /// <br/>
        ///  Example: [&quot;example_rule_set&quot;]
        /// </value>
        [JsonProperty(PropertyName = "ruleSetNames")]
        public System.Collections.Generic.List<string> RuleSetNames { get; set; }
        
    }
}
