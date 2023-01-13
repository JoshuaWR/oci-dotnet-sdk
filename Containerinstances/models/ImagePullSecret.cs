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

namespace Oci.ContainerinstancesService.Models
{
    /// <summary>
    /// The image pull secrets for accessing private registry to pull images for containers
    /// 
    /// </summary>
    [JsonConverter(typeof(ImagePullSecretModelConverter))]
    public class ImagePullSecret 
    {
                ///
        /// <value>
        /// The type of ImagePullSecret.
        /// </value>
        ///
        public enum SecretTypeEnum {
            [EnumMember(Value = "BASIC")]
            Basic,
            [EnumMember(Value = "VAULT")]
            Vault
        };

        
        /// <value>
        /// The registry endpoint of the container image.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RegistryEndpoint is required.")]
        [JsonProperty(PropertyName = "registryEndpoint")]
        public string RegistryEndpoint { get; set; }
        
    }

    public class ImagePullSecretModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ImagePullSecret);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ImagePullSecret);
            var discriminator = jsonObject["secretType"].Value<string>();
            switch (discriminator)
            {
                case "VAULT":
                    obj = new VaultImagePullSecret();
                    break;
                case "BASIC":
                    obj = new BasicImagePullSecret();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ImagePullSecret! Returning null value.");
            }
            return obj;
        }
    }
}
