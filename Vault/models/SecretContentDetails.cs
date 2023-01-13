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

namespace Oci.VaultService.Models
{
    /// <summary>
    /// The content of the secret and metadata to help identify it.
    /// </summary>
    [JsonConverter(typeof(SecretContentDetailsModelConverter))]
    public class SecretContentDetails 
    {
                ///
        /// <value>
        /// The base64-encoded content of the secret.
        /// </value>
        ///
        public enum ContentTypeEnum {
            [EnumMember(Value = "BASE64")]
            Base64
        };

        
        /// <value>
        /// Names should be unique within a secret. Valid characters are uppercase or lowercase letters, numbers, hyphens, underscores, and periods.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The rotation state of the secret content. The default is `CURRENT`, meaning that the secret is currently in use. A secret version
        /// that you mark as `PENDING` is staged and available for use, but you don't yet want to rotate it into current, active use. For example,
        /// you might create or update a secret and mark its rotation state as `PENDING` if you haven't yet updated the secret on the target system.
        /// When creating a secret, only the value `CURRENT` is applicable, although the value `LATEST` is also automatically applied. When updating
        /// a secret, you can specify a version's rotation state as either `CURRENT` or `PENDING`.
        /// 
        /// </value>
        ///
        public enum StageEnum {
            [EnumMember(Value = "CURRENT")]
            Current,
            [EnumMember(Value = "PENDING")]
            Pending
        };

        /// <value>
        /// The rotation state of the secret content. The default is `CURRENT`, meaning that the secret is currently in use. A secret version
        /// that you mark as `PENDING` is staged and available for use, but you don't yet want to rotate it into current, active use. For example,
        /// you might create or update a secret and mark its rotation state as `PENDING` if you haven't yet updated the secret on the target system.
        /// When creating a secret, only the value `CURRENT` is applicable, although the value `LATEST` is also automatically applied. When updating
        /// a secret, you can specify a version's rotation state as either `CURRENT` or `PENDING`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "stage")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StageEnum> Stage { get; set; }
        
    }

    public class SecretContentDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SecretContentDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SecretContentDetails);
            var discriminator = jsonObject["contentType"].Value<string>();
            switch (discriminator)
            {
                case "BASE64":
                    obj = new Base64SecretContentDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
