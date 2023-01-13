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
    /// Details used to add a route distribution statement.
    /// 
    /// </summary>
    public class AddDrgRouteDistributionStatementDetails 
    {
        
        /// <value>
        /// The action is applied only if all of the match criteria is met.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MatchCriteria is required.")]
        [JsonProperty(PropertyName = "matchCriteria")]
        public System.Collections.Generic.List<DrgRouteDistributionMatchCriteria> MatchCriteria { get; set; }
                ///
        /// <value>
        /// Accept: import/export the route \"as is\"
        /// 
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "ACCEPT")]
            Accept
        };

        /// <value>
        /// Accept: import/export the route \"as is\"
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
        /// <value>
        /// This field is used to specify the priority of each statement in a route distribution.
        /// The priority will be represented as a number between 0 and 65535 where a lower number
        /// indicates a higher priority. When a route is processed, statements are applied in the order
        /// defined by their priority. The first matching rule dictates the action that will be taken
        /// on the route.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Priority is required.")]
        [JsonProperty(PropertyName = "priority")]
        public System.Nullable<int> Priority { get; set; }
        
    }
}
