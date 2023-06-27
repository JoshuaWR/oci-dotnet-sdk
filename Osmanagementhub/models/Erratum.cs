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
    /// Details about the erratum.
    /// </summary>
    public class Erratum 
    {
        
        /// <value>
        /// Advisory name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Summary description of the erratum.
        /// </value>
        [JsonProperty(PropertyName = "synopsis")]
        public string Synopsis { get; set; }
        
        /// <value>
        /// Date the erratum was issued, as described
        /// in [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeIssued")]
        public System.Nullable<System.DateTime> TimeIssued { get; set; }
        
        /// <value>
        /// Details describing the erratum.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Most recent date the erratum was updated, as described
        /// in [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Type of the erratum.
        /// </value>
        [JsonProperty(PropertyName = "classificationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ClassificationTypes> ClassificationType { get; set; }
        
        /// <value>
        /// Information specifying from where the erratum was release.
        /// </value>
        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }
        
        /// <value>
        /// Information describing how the erratum can be resolved.
        /// </value>
        [JsonProperty(PropertyName = "solution")]
        public string Solution { get; set; }
        
        /// <value>
        /// Information describing how to find more information about. the erratum.
        /// </value>
        [JsonProperty(PropertyName = "references")]
        public string References { get; set; }
        
        /// <value>
        /// List of CVEs applicable to this erratum.
        /// </value>
        [JsonProperty(PropertyName = "relatedCves")]
        public System.Collections.Generic.List<string> RelatedCves { get; set; }
        
        /// <value>
        /// List of repository identifiers.
        /// </value>
        [JsonProperty(PropertyName = "repositories")]
        public System.Collections.Generic.List<string> Repositories { get; set; }
        
        /// <value>
        /// List of Packages affected by this erratum.
        /// </value>
        [JsonProperty(PropertyName = "packages")]
        public System.Collections.Generic.List<SoftwarePackageSummary> Packages { get; set; }
        
        /// <value>
        /// List of affected OS families.
        /// </value>
        [JsonProperty(PropertyName = "osFamilies")]
        public System.Collections.Generic.List<OsFamily> OsFamilies { get; set; }
        
        /// <value>
        /// The severity for a security advisory, otherwise, null.
        /// </value>
        [JsonProperty(PropertyName = "advisorySeverity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AdvisorySeverity> AdvisorySeverity { get; set; }
        
    }
}