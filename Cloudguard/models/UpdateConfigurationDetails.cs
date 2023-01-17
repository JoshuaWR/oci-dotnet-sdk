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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Update cloud guard configuration details for a tenancy.
    /// </summary>
    public class UpdateConfigurationDetails 
    {
        
        /// <value>
        /// The reporting region value
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReportingRegion is required.")]
        [JsonProperty(PropertyName = "reportingRegion")]
        public string ReportingRegion { get; set; }
        
        /// <value>
        /// Status of Cloud Guard Tenant
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CloudGuardStatus> Status { get; set; }
        
        /// <value>
        /// Identifies if Oracle managed resources will be created by customers.
        /// If no value is specified false is the default.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "selfManageResources")]
        public System.Nullable<bool> SelfManageResources { get; set; }
        
    }
}
