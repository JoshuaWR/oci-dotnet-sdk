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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsParserFunction
    /// </summary>
    public class LogAnalyticsParserFunction 
    {
        
        [JsonProperty(PropertyName = "parserMetaPlugin")]
        public LogAnalyticsParserMetaPlugin ParserMetaPlugin { get; set; }
        
        /// <value>
        /// The parser function unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "parserFunctionId")]
        public System.Nullable<long> ParserFunctionId { get; set; }
        
        /// <value>
        /// The parser function internal name.
        /// </value>
        [JsonProperty(PropertyName = "parserFunctionName")]
        public string ParserFunctionName { get; set; }
        
        /// <value>
        /// A flag inidcating whether or not the parser function is enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// The system flag.  A value of false denotes a custom, or user
        /// defined object.  A value of true denotes a built in object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }
        
        /// <value>
        /// The associated parser unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "parserId")]
        public System.Nullable<long> ParserId { get; set; }
        
        /// <value>
        /// The associated parser internal name.
        /// </value>
        [JsonProperty(PropertyName = "parserName")]
        public string ParserName { get; set; }
        
        /// <value>
        /// The plugin internal name.
        /// </value>
        [JsonProperty(PropertyName = "parserMetaPluginName")]
        public string ParserMetaPluginName { get; set; }
        
        /// <value>
        /// The parser function priority.
        /// </value>
        [JsonProperty(PropertyName = "parserFunctionPriority")]
        public System.Nullable<long> ParserFunctionPriority { get; set; }
        
        /// <value>
        /// The parser function parameter list.
        /// </value>
        [JsonProperty(PropertyName = "parserFunctionParameters")]
        public System.Collections.Generic.List<LogAnalyticsParserFunctionParameter> ParserFunctionParameters { get; set; }
        
    }
}
