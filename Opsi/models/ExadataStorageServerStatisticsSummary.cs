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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Storage server details and statistics.
    /// </summary>
    public class ExadataStorageServerStatisticsSummary : ExadataInsightResourceStatisticsAggregation
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceDetails is required.")]
        [JsonProperty(PropertyName = "resourceDetails")]
        public StorageServerDetails ResourceDetails { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CurrentStatistics is required.")]
        [JsonProperty(PropertyName = "currentStatistics")]
        public ExadataInsightResourceStatistics CurrentStatistics { get; set; }
        
        [JsonProperty(PropertyName = "exadataResourceType")]
        private readonly string exadataResourceType = "STORAGE_SERVER";
    }
}
