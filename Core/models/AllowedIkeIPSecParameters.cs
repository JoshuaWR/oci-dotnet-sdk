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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Lists the current allowed and default IPSec tunnel parameters.
    /// </summary>
    public class AllowedIkeIPSecParameters 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AllowedPhaseOneParameters is required.")]
        [JsonProperty(PropertyName = "allowedPhaseOneParameters")]
        public AllowedPhaseOneParameters AllowedPhaseOneParameters { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AllowedPhaseTwoParameters is required.")]
        [JsonProperty(PropertyName = "allowedPhaseTwoParameters")]
        public AllowedPhaseTwoParameters AllowedPhaseTwoParameters { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefaultPhaseOneParameters is required.")]
        [JsonProperty(PropertyName = "defaultPhaseOneParameters")]
        public DefaultPhaseOneParameters DefaultPhaseOneParameters { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefaultPhaseTwoParameters is required.")]
        [JsonProperty(PropertyName = "defaultPhaseTwoParameters")]
        public DefaultPhaseTwoParameters DefaultPhaseTwoParameters { get; set; }
        
    }
}
