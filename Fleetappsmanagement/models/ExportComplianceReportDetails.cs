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
    /// Details for generating Compliance Report
    /// </summary>
    public class ExportComplianceReportDetails 
    {
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the entity for which the compliance is calculated.Ex.FleetId
        /// </value>
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }
        
        /// <value>
        /// The OCID to identify the resource.
        /// </value>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Product Stack.
        /// </value>
        [JsonProperty(PropertyName = "productStack")]
        public string ProductStack { get; set; }
        
        /// <value>
        /// Product Name.
        /// </value>
        [JsonProperty(PropertyName = "productName")]
        public string ProductName { get; set; }
        
        /// <value>
        /// Last known compliance state of target.
        /// </value>
        [JsonProperty(PropertyName = "complianceState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ComplianceState> ComplianceState { get; set; }
        
    }
}