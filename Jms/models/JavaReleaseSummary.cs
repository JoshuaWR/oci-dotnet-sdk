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
    /// A summary of the Java release properties.
    /// </summary>
    public class JavaReleaseSummary 
    {
        
        /// <value>
        /// Java release version identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReleaseVersion is required.")]
        [JsonProperty(PropertyName = "releaseVersion")]
        public string ReleaseVersion { get; set; }
        
        /// <value>
        /// Java release family identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FamilyVersion is required.")]
        [JsonProperty(PropertyName = "familyVersion")]
        public string FamilyVersion { get; set; }
        
        /// <value>
        /// Parent Java release version identifier. This is applicable for BPR releases.
        /// </value>
        [JsonProperty(PropertyName = "parentReleaseVersion")]
        public string ParentReleaseVersion { get; set; }
        
        /// <value>
        /// The security status of the Java version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityStatus is required.")]
        [JsonProperty(PropertyName = "securityStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<JreSecurityStatus> SecurityStatus { get; set; }
        
        /// <value>
        /// Release category of the Java version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReleaseType is required.")]
        [JsonProperty(PropertyName = "releaseType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ReleaseType> ReleaseType { get; set; }
        
        /// <value>
        /// License type for the Java version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LicenseType is required.")]
        [JsonProperty(PropertyName = "licenseType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LicenseType> LicenseType { get; set; }
        
        [JsonProperty(PropertyName = "familyDetails")]
        public JavaFamily FamilyDetails { get; set; }
        
        [JsonProperty(PropertyName = "licenseDetails")]
        public JavaLicense LicenseDetails { get; set; }
        
        /// <value>
        /// The release date of the Java version (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReleaseDate is required.")]
        [JsonProperty(PropertyName = "releaseDate")]
        public System.Nullable<System.DateTime> ReleaseDate { get; set; }
        
        /// <value>
        /// Release notes associated with the Java version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReleaseNotesUrl is required.")]
        [JsonProperty(PropertyName = "releaseNotesUrl")]
        public string ReleaseNotesUrl { get; set; }
        
        /// <value>
        /// Artifact content types for the Java version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArtifactContentTypes is required.")]
        [JsonProperty(PropertyName = "artifactContentTypes", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<ArtifactContentType> ArtifactContentTypes { get; set; }
        
    }
}
