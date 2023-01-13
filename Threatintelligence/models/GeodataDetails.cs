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


namespace Oci.ThreatintelligenceService.Models
{
    /// <summary>
    /// Geodata information for a given IP address
    /// </summary>
    public class GeodataDetails 
    {
        
        /// <value>
        /// Encompassing assigned prefix for the IP
        /// </value>
        [JsonProperty(PropertyName = "routedPrefix")]
        public string RoutedPrefix { get; set; }
        
        /// <value>
        /// ASN entry
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Origin is required.")]
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }
        
        /// <value>
        /// Unique Identifier (optional)
        /// </value>
        [JsonProperty(PropertyName = "geoId")]
        public string GeoId { get; set; }
        
        /// <value>
        /// Two-letter abbreviation for country of origin
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CountryCode is required.")]
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }
        
        /// <value>
        /// State/Province/subdivision within the country
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AdminDiv is required.")]
        [JsonProperty(PropertyName = "adminDiv")]
        public string AdminDiv { get; set; }
        
        /// <value>
        /// City of origin
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "City is required.")]
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        
        /// <value>
        /// Latitude
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Latitude is required.")]
        [JsonProperty(PropertyName = "latitude")]
        public string Latitude { get; set; }
        
        /// <value>
        /// Longitude
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Longitude is required.")]
        [JsonProperty(PropertyName = "longitude")]
        public string Longitude { get; set; }
        
        /// <value>
        /// Information on source providing the information
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Label is required.")]
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
        
    }
}
