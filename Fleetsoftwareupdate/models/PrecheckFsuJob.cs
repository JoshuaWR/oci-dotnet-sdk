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


namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Precheck Exadata Fleet Update Job resource.
    /// 
    /// </summary>
    public class PrecheckFsuJob : FsuJob
    {
        
        /// <value>
        /// OCID of the Exadata Fleet Update Collection that the job is executing on.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FsuCollectionId is required.")]
        [JsonProperty(PropertyName = "fsuCollectionId")]
        public string FsuCollectionId { get; set; }
        
        /// <value>
        /// OCID of the Exadata Fleet Update Cycle that this job is part of.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FsuCycleId is required.")]
        [JsonProperty(PropertyName = "fsuCycleId")]
        public string FsuCycleId { get; set; }
        
        /// <value>
        /// OCID of Target resource on which the job is executing the action.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        [JsonProperty(PropertyName = "schedule")]
        public ScheduleDetails Schedule { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "PRECHECK";
    }
}
