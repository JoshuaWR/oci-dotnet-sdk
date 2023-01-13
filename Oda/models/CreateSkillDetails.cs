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
using Newtonsoft.Json.Linq;

namespace Oci.OdaService.Models
{
    /// <summary>
    /// Properties that are required to create a Skill.
    /// </summary>
    [JsonConverter(typeof(CreateSkillDetailsModelConverter))]
    public class CreateSkillDetails 
    {
        
        
        /// <value>
        /// The resource's category.  This is used to group resource's together.
        /// </value>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        
        /// <value>
        /// A short description of the resource.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The ODA Platform Version for this resource.
        /// </value>
        [JsonProperty(PropertyName = "platformVersion")]
        public string PlatformVersion { get; set; }
        
        /// <value>
        /// The multilingual mode for the resource.
        /// </value>
        [JsonProperty(PropertyName = "multilingualMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BotMultilingualMode> MultilingualMode { get; set; }
        
        /// <value>
        /// The primary language for the resource.
        /// </value>
        [JsonProperty(PropertyName = "primaryLanguageTag")]
        public string PrimaryLanguageTag { get; set; }
        
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

    public class CreateSkillDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateSkillDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateSkillDetails);
            var discriminator = jsonObject["kind"].Value<string>();
            switch (discriminator)
            {
                case "CLONE":
                    obj = new CloneSkillDetails();
                    break;
                case "NEW":
                    obj = new CreateNewSkillDetails();
                    break;
                case "VERSION":
                    obj = new CreateSkillVersionDetails();
                    break;
                case "EXTEND":
                    obj = new ExtendSkillDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
