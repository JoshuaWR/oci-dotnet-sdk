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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Details regarding the validation of a pattern resource.
    /// </summary>
    public class ValidatePatternResult 
    {
        
        /// <value>
        /// The message from the pattern validation.
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// The status returned from the pattern validation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        /// <value>
        /// The expression used in the pattern validation.
        /// </value>
        [JsonProperty(PropertyName = "expression")]
        public string Expression { get; set; }
        
        /// <value>
        /// The prefix used in the pattern validation.
        /// </value>
        [JsonProperty(PropertyName = "filePathPrefix")]
        public string FilePathPrefix { get; set; }
        
        /// <value>
        /// Collection of logical entities derived from the pattern, as applied to a list of file paths.
        /// </value>
        [JsonProperty(PropertyName = "derivedLogicalEntities")]
        public System.Collections.Generic.List<DerivedLogicalEntities> DerivedLogicalEntities { get; set; }
        
    }
}
