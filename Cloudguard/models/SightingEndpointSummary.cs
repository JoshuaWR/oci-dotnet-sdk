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
    /// Sighting Endpoints summary.
    /// </summary>
    public class SightingEndpointSummary 
    {
        
        /// <value>
        /// Unique identifier for sighting endpoints
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Sighitng Id for sighting endpoints
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SightingId is required.")]
        [JsonProperty(PropertyName = "sightingId")]
        public string SightingId { get; set; }
        
        /// <value>
        /// Problem Id for sighting endpoints
        /// </value>
        [JsonProperty(PropertyName = "problemId")]
        public string ProblemId { get; set; }
        
        /// <value>
        /// IP Address
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IpAddress is required.")]
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// IP Address type
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IpAddressType is required.")]
        [JsonProperty(PropertyName = "ipAddressType")]
        public string IpAddressType { get; set; }
        
        /// <value>
        /// IP Address classification type
        /// </value>
        [JsonProperty(PropertyName = "ipClassificationType")]
        public string IpClassificationType { get; set; }
        
        /// <value>
        /// Country
        /// </value>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        
        /// <value>
        /// Latitude
        /// </value>
        [JsonProperty(PropertyName = "latitude")]
        public System.Double Latitude { get; set; }
        
        /// <value>
        /// Longitude
        /// </value>
        [JsonProperty(PropertyName = "longitude")]
        public System.Double Longitude { get; set; }
        
        /// <value>
        /// ASN number
        /// </value>
        [JsonProperty(PropertyName = "asnNumber")]
        public string AsnNumber { get; set; }
        
        /// <value>
        /// Regions where activities were performed from this IP
        /// </value>
        [JsonProperty(PropertyName = "regions")]
        public System.Collections.Generic.List<string> Regions { get; set; }
        
        /// <value>
        /// Services where activities were performed from this IP
        /// </value>
        [JsonProperty(PropertyName = "services")]
        public System.Collections.Generic.List<string> Services { get; set; }
        
        /// <value>
        /// Time when activities were created
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeLastDetected is required.")]
        [JsonProperty(PropertyName = "timeLastDetected")]
        public System.Nullable<System.DateTime> TimeLastDetected { get; set; }
        
    }
}
