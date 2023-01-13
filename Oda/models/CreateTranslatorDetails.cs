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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// Properties that are required to create a Translator.
    /// </summary>
    public class CreateTranslatorDetails 
    {
        
        /// <value>
        /// The Translation Service to use for this Translator.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TranslationService> Type { get; set; }
        
        /// <value>
        /// The base URL for invoking the Translation Service.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BaseUrl is required.")]
        [JsonProperty(PropertyName = "baseUrl")]
        public string BaseUrl { get; set; }
        
        /// <value>
        /// The authentication token to use when invoking the Translation Service
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuthToken is required.")]
        [JsonProperty(PropertyName = "authToken")]
        public string AuthToken { get; set; }
        
        /// <value>
        /// Properties used when invoking the translation service.
        /// Each property is a simple key-value pair.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.Dictionary<string, string> Properties { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type, or scope.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
