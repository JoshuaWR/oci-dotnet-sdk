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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Sighting summary definition.
    /// </summary>
    public class SightingSummary 
    {
        
        /// <value>
        /// Unique identifier for sighting
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Compartment OCID where the impacted resource is created
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Problem ID associated with sighting
        /// </value>
        [JsonProperty(PropertyName = "problemId")]
        public string ProblemId { get; set; }
        
        /// <value>
        /// Unique identifier for principal actor
        /// </value>
        [JsonProperty(PropertyName = "actorPrincipalId")]
        public string ActorPrincipalId { get; set; }
        
        /// <value>
        /// Name of principal actor
        /// </value>
        [JsonProperty(PropertyName = "actorPrincipalName")]
        public string ActorPrincipalName { get; set; }
        
        /// <value>
        /// Type of principal actor
        /// </value>
        [JsonProperty(PropertyName = "actorPrincipalType")]
        public string ActorPrincipalType { get; set; }
        
        /// <value>
        /// Unique identifier of the detector rule that was triggered
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DetectorRuleId is required.")]
        [JsonProperty(PropertyName = "detectorRuleId")]
        public string DetectorRuleId { get; set; }
        
        /// <value>
        /// Classification status of the sighting
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClassificationStatus is required.")]
        [JsonProperty(PropertyName = "classificationStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ClassificationStatus> ClassificationStatus { get; set; }
        
        /// <value>
        /// Type of sighting
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SightingType is required.")]
        [JsonProperty(PropertyName = "sightingType")]
        public string SightingType { get; set; }
        
        /// <value>
        /// Display name of the sighting type
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SightingTypeDisplayName is required.")]
        [JsonProperty(PropertyName = "sightingTypeDisplayName")]
        public string SightingTypeDisplayName { get; set; }
        
        /// <value>
        /// Name of the MITRE ATT@CK framework tactic
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TacticName is required.")]
        [JsonProperty(PropertyName = "tacticName")]
        public string TacticName { get; set; }
        
        /// <value>
        /// Name of the MITRE ATT@CK framework technique
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechniqueName is required.")]
        [JsonProperty(PropertyName = "techniqueName")]
        public string TechniqueName { get; set; }
        
        /// <value>
        /// Score for the sighting
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SightingScore is required.")]
        [JsonProperty(PropertyName = "sightingScore")]
        public System.Nullable<int> SightingScore { get; set; }
        
        /// <value>
        /// Severity of the sighting
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Severity is required.")]
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Severity> Severity { get; set; }
        
        /// <value>
        /// Confidence level that the sighting is not a false positive
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Confidence is required.")]
        [JsonProperty(PropertyName = "confidence")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Confidence> Confidence { get; set; }
        
        /// <value>
        /// Time the activities were first detected. Format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeFirstDetected is required.")]
        [JsonProperty(PropertyName = "timeFirstDetected")]
        public System.Nullable<System.DateTime> TimeFirstDetected { get; set; }
        
        /// <value>
        /// Time the activities were last detected. Format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeLastDetected is required.")]
        [JsonProperty(PropertyName = "timeLastDetected")]
        public System.Nullable<System.DateTime> TimeLastDetected { get; set; }
        
        /// <value>
        /// Time the activities were first performed. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeFirstOccurred")]
        public System.Nullable<System.DateTime> TimeFirstOccurred { get; set; }
        
        /// <value>
        /// Time the activities were last performed. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeLastOccurred")]
        public System.Nullable<System.DateTime> TimeLastOccurred { get; set; }
        
        /// <value>
        /// List of regions involved in the sighting
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Regions is required.")]
        [JsonProperty(PropertyName = "regions")]
        public System.Collections.Generic.List<string> Regions { get; set; }
        
    }
}
