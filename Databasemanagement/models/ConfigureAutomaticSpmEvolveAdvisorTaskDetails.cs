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
    /// The configuration details of the Automatic SPM Evolve Advisor task.
    /// </summary>
    public class ConfigureAutomaticSpmEvolveAdvisorTaskDetails 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TaskParameters is required.")]
        [JsonProperty(PropertyName = "taskParameters")]
        public SpmEvolveTaskParameters TaskParameters { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Credentials is required.")]
        [JsonProperty(PropertyName = "credentials")]
        public ManagedDatabaseCredential Credentials { get; set; }
        
    }
}
