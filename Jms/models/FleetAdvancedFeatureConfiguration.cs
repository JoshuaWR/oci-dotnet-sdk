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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Advanced feature metadata for the fleet
    /// </summary>
    public class FleetAdvancedFeatureConfiguration 
    {
        
        /// <value>
        /// Namespace for the fleet advanced feature
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AnalyticNamespace is required.")]
        [JsonProperty(PropertyName = "analyticNamespace")]
        public string AnalyticNamespace { get; set; }
        
        /// <value>
        /// Bucket name required to store jfr and related data
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AnalyticBucketName is required.")]
        [JsonProperty(PropertyName = "analyticBucketName")]
        public string AnalyticBucketName { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Lcm is required.")]
        [JsonProperty(PropertyName = "lcm")]
        public Lcm Lcm { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CryptoEventAnalysis is required.")]
        [JsonProperty(PropertyName = "cryptoEventAnalysis")]
        public CryptoEventAnalysis CryptoEventAnalysis { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AdvancedUsageTracking is required.")]
        [JsonProperty(PropertyName = "advancedUsageTracking")]
        public AdvancedUsageTracking AdvancedUsageTracking { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JfrRecording is required.")]
        [JsonProperty(PropertyName = "jfrRecording")]
        public JfrRecording JfrRecording { get; set; }
        
        /// <value>
        /// The date and time of the last modification to the Fleet Agent Configuration (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeLastModified is required.")]
        [JsonProperty(PropertyName = "timeLastModified")]
        public System.Nullable<System.DateTime> TimeLastModified { get; set; }
        
    }
}
