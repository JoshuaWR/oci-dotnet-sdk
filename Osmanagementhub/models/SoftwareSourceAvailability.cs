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
    /// An object that contains a software source OCID and its availability.
    /// </summary>
    public class SoftwareSourceAvailability 
    {
        
        /// <value>
        /// The OCID for a vendor software source.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SoftwareSourceId is required.")]
        [JsonProperty(PropertyName = "softwareSourceId")]
        public string SoftwareSourceId { get; set; }
        
        /// <value>
        /// Possible availabilities of a software source.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Availability is required.")]
        [JsonProperty(PropertyName = "availability")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Availability> Availability { get; set; }
        
    }
}
