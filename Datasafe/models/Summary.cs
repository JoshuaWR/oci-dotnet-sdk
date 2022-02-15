/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Summary of the audit report.
    /// </summary>
    public class Summary 
    {
        
        /// <value>
        /// Name of the report summary.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Indicates if the summary is hidden. Values can either be 'true' or 'false'.
        /// </value>
        [JsonProperty(PropertyName = "isHidden")]
        public System.Nullable<bool> IsHidden { get; set; }
        
        /// <value>
        /// Specifies the order in which the summary must be displayed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayOrder is required.")]
        [JsonProperty(PropertyName = "displayOrder")]
        public System.Nullable<int> DisplayOrder { get; set; }
        
        /// <value>
        /// A comma-delimited string that specifies the names of the fields by which the records must be aggregated to get the summary.
        /// </value>
        [JsonProperty(PropertyName = "groupByFieldName")]
        public string GroupByFieldName { get; set; }
        
        /// <value>
        /// Name of the key or count of object.
        /// </value>
        [JsonProperty(PropertyName = "countOf")]
        public string CountOf { get; set; }
        
        /// <value>
        /// Additional scim filters used to get the specific summary.
        /// </value>
        [JsonProperty(PropertyName = "scimFilter")]
        public string ScimFilter { get; set; }
        
    }
}