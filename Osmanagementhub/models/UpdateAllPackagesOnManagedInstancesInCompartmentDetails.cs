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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// The details about the package types to be updated.
    /// </summary>
    public class UpdateAllPackagesOnManagedInstancesInCompartmentDetails 
    {
        
        /// <value>
        /// The compartment being targeted by this operation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The type of updates to be applied.
        /// </value>
        [JsonProperty(PropertyName = "updateTypes", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<UpdateTypes> UpdateTypes { get; set; }
        
        [JsonProperty(PropertyName = "workRequestDetails")]
        public WorkRequestDetails WorkRequestDetails { get; set; }
        
    }
}
