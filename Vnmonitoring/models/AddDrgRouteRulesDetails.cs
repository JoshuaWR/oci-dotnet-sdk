/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    /// Details used in a request to add static routes to a DRG route table.
    /// 
    /// </summary>
    public class AddDrgRouteRulesDetails 
    {
        
        /// <value>
        /// The collection of static rules used to insert routes into the DRG route table.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routeRules")]
        public System.Collections.Generic.List<AddDrgRouteRuleDetails> RouteRules { get; set; }
        
    }
}
