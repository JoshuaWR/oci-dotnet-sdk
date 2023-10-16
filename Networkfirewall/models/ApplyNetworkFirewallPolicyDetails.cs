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


namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// Request data required to clone a network firewall policy.
    /// </summary>
    public class ApplyNetworkFirewallPolicyDetails 
    {
        
        /// <value>
        /// Ordered priority list of firewall OCIDs on which the update needs to be applied in given order. If the list is a subset of the firewalls attached, then given firewalls would be deployed first with the change, followed by remaining firewalls.
        /// </value>
        [JsonProperty(PropertyName = "firewalls")]
        public System.Collections.Generic.List<string> Firewalls { get; set; }
        
    }
}
