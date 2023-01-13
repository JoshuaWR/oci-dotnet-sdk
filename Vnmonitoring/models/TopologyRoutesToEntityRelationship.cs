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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Defines the `routesTo` relationship between virtual network topology entities. A `RoutesTo` relationship
    /// is defined when a routing table and a routing rule  are used to govern how to route traffic
    /// from one entity to another. For example, a DRG might have a routing rule to send certain traffic to an LPG.
    /// 
    /// </summary>
    public class TopologyRoutesToEntityRelationship : TopologyEntityRelationship
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RouteRuleDetails is required.")]
        [JsonProperty(PropertyName = "routeRuleDetails")]
        public TopologyRoutesToRelationshipDetails RouteRuleDetails { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "ROUTES_TO";
    }
}
