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
    /// Rollback Exadata Fleet Update Action creation details. This action will attempt to rollback the
    /// specified Targets according to strategy to the source target version prior to patching in this
    /// Exadata Fleet Update Cycle and remove them from the Collection.
    /// 
    /// </summary>
    public class CreateRollbackActionDetails : CreateFsuActionDetails
    {
        
        /// <value>
        /// OCID identifier for the Exadata Fleet Update Cycle the Action will be part of.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FsuCycleId is required.")]
        [JsonProperty(PropertyName = "fsuCycleId")]
        public string FsuCycleId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Details is required.")]
        [JsonProperty(PropertyName = "details")]
        public RollbackDetails Details { get; set; }
        
        [JsonProperty(PropertyName = "scheduleDetails")]
        public CreateScheduleDetails ScheduleDetails { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "ROLLBACK_AND_REMOVE_TARGET";
    }
}
