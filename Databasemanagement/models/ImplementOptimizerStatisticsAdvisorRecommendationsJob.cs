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
    /// The job request details to implement the Optimizer Statistics Advisor task recommendations.
    /// </summary>
    public class ImplementOptimizerStatisticsAdvisorRecommendationsJob 
    {
        
        /// <value>
        /// The name of the job. Valid characters are uppercase or lowercase letters,
        /// numbers, and \"_\". The name of the job cannot be modified. It must be unique
        /// in the compartment and must begin with an alphabetic character.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The name of the execution.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment in which the job resides.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResultLocation is required.")]
        [JsonProperty(PropertyName = "resultLocation")]
        public JobExecutionResultLocation ResultLocation { get; set; }
        
        [JsonProperty(PropertyName = "credentials")]
        public ManagedDatabaseCredential Credentials { get; set; }
        
    }
}
