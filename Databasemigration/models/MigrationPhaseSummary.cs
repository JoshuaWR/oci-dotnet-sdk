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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Migration Phase Summary of details.
    /// 
    /// </summary>
    public class MigrationPhaseSummary 
    {
        
        /// <value>
        /// ODMS Job phase name
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OdmsJobPhases> Name { get; set; }
        
        /// <value>
        /// Action recommended for this phase. If not included in the response, there is no recommended action for the phase.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "recommendedAction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OdmsPhaseActions> RecommendedAction { get; set; }
        
        /// <value>
        /// Array of actions for the corresponding phase. Empty array would indicate there is no supported action for the phase.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SupportedActions is required.")]
        [JsonProperty(PropertyName = "supportedActions")]
        public System.Collections.Generic.List<OdmsPhaseActions> SupportedActions { get; set; }
        
    }
}
