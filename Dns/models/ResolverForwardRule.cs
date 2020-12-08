/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DnsService.Models
{
    
    public class ResolverForwardRule : ResolverRule
    {
        
        /// <value>
        /// IP addresses to which queries should be forwarded. Currently limited to a single address.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationAddresses is required.")]
        [JsonProperty(PropertyName = "destinationAddresses")]
        public System.Collections.Generic.List<string> DestinationAddresses { get; set; }
        
        /// <value>
        /// Name of an endpoint, that is a sub-resource of the resolver, to use as the forwarding interface. The
        /// endpoint must have isForwarding set to true.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceEndpointName")]
        public string SourceEndpointName { get; set; }
        
        [JsonProperty(PropertyName = "action")]
        private readonly string action = "FORWARD";
    }
}