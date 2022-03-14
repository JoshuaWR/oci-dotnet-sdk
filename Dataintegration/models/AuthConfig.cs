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
using Newtonsoft.Json.Linq;

namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Authentication configuration for Generic REST invocation.
    /// </summary>
    [JsonConverter(typeof(AuthConfigModelConverter))]
    public class AuthConfig 
    {
        
        /// <value>
        /// Generated key that can be used in API calls to identify this object.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The model version of an object.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
                ///
        /// <value>
        /// The specific authentication configuration to be used for Generic REST invocation.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "OCI_RESOURCE_AUTH_CONFIG")]
            OciResourceAuthConfig
        };

        
    }

    public class AuthConfigModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AuthConfig);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AuthConfig);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "OCI_RESOURCE_AUTH_CONFIG":
                    obj = new ResourcePrincipalAuthConfig();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
