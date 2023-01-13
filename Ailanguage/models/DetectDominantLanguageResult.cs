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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// Result of language detect call.
    /// </summary>
    public class DetectDominantLanguageResult 
    {
        
        /// <value>
        /// List of detected languages with results sorted in descending order of the scores. Most likely language is on top.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Languages is required.")]
        [JsonProperty(PropertyName = "languages")]
        public System.Collections.Generic.List<DetectedLanguage> Languages { get; set; }
        
    }
}
