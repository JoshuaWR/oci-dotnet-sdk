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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details required to configure automatic capture filters.
    /// </summary>
    public class ConfigureAutomaticCaptureFiltersDetails 
    {
        
        /// <value>
        /// The filters used in automatic initial plan capture.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AutoCaptureFilters is required.")]
        [JsonProperty(PropertyName = "autoCaptureFilters")]
        public System.Collections.Generic.List<AutomaticCaptureFilterDetails> AutoCaptureFilters { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Credentials is required.")]
        [JsonProperty(PropertyName = "credentials")]
        public ManagedDatabaseCredential Credentials { get; set; }
        
    }
}
