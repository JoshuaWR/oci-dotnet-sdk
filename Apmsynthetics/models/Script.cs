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


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// The information about the script.
    /// </summary>
    public class Script 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the script.
        /// scriptId is mandatory for creation of SCRIPTED_BROWSER and SCRIPTED_REST monitor types. For other monitor types, it should be set to null.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Unique name that can be edited. The name should not contain any confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Content type of the script.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ContentType is required.")]
        [JsonProperty(PropertyName = "contentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ContentTypes> ContentType { get; set; }
        
        /// <value>
        /// The content of the script. It may contain custom-defined tags that can be used for setting dynamic parameters.
        /// The format to set dynamic parameters is: `<ORAP><ON>param name</ON><OV>param value</OV><OS>isParamValueSecret(true/false)</OS></ORAP>`.
        /// Param value and isParamValueSecret are optional, the default value for isParamValueSecret is false.
        /// Examples:
        /// With mandatory param name : `<ORAP><ON>param name</ON></ORAP>`
        /// With parameter name and value : `<ORAP><ON>param name</ON><OV>param value</OV></ORAP>`
        /// Note that the content is valid if it matches the given content type. For example, if the content type is SIDE, then the content should be in Side script format. If the content type is JS, then the content should be in JavaScript format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
        
        /// <value>
        /// The time the script was uploaded.
        /// </value>
        [JsonProperty(PropertyName = "timeUploaded")]
        public System.Nullable<System.DateTime> TimeUploaded { get; set; }
        
        /// <value>
        /// Size of the script content.
        /// </value>
        [JsonProperty(PropertyName = "contentSizeInBytes")]
        public System.Nullable<int> ContentSizeInBytes { get; set; }
        
        /// <value>
        /// File name of the uploaded script content.
        /// </value>
        [JsonProperty(PropertyName = "contentFileName")]
        public string ContentFileName { get; set; }
        
        /// <value>
        /// List of script parameters. Example: [{&quot;scriptParameter&quot;: {&quot;paramName&quot;: &quot;userid&quot;, &quot;paramValue&quot;:&quot;testuser&quot;, &quot;isSecret&quot;: false}, &quot;isOverwritten&quot;: false}]
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<ScriptParameterInfo> Parameters { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MonitorStatusCountMap is required.")]
        [JsonProperty(PropertyName = "monitorStatusCountMap")]
        public MonitorStatusCountMap MonitorStatusCountMap { get; set; }
        
        /// <value>
        /// The time the resource was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// timestamp format.
        /// Example: 2020-02-12T22:47:12.613Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the resource was updated, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// timestamp format.
        /// Example: 2020-02-13T22:47:12.613Z
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
