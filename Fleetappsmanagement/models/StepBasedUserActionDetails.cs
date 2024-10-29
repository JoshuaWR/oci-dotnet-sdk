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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Details for a user action to be performed on a step.
    /// </summary>
    public class StepBasedUserActionDetails : UserActionDetails
    {
        
        /// <value>
        /// Unique identifier for the action group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionGroupId is required.")]
        [JsonProperty(PropertyName = "actionGroupId")]
        public string ActionGroupId { get; set; }
        
        /// <value>
        /// Resource OCID
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Target associated with the execution.
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// Name of the step on which user action needs to be performed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StepName is required.")]
        [JsonProperty(PropertyName = "stepName")]
        public string StepName { get; set; }
        
        [JsonProperty(PropertyName = "level")]
        private readonly string level = "STEP_NAME";
    }
}