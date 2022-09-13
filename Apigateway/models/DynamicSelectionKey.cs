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

namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Information around the values for selector of an authentication/ routing branch.
    /// </summary>
    [JsonConverter(typeof(DynamicSelectionKeyModelConverter))]
    public class DynamicSelectionKey 
    {
                ///
        /// <value>
        /// Information regarding type of the selection key.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "ANY_OF")]
            AnyOf,
            [EnumMember(Value = "WILDCARD")]
            Wildcard
        };

        
        /// <value>
        /// Information regarding whether this is the default branch.
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
        /// <value>
        /// Name assigned to the branch.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
    }

    public class DynamicSelectionKeyModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DynamicSelectionKey);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DynamicSelectionKey);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "WILDCARD":
                    obj = new WildcardSelectionKey();
                    break;
                case "ANY_OF":
                    obj = new AnyOfSelectionKey();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under DynamicSelectionKey! Returning null value.");
            }
            return obj;
        }
    }
}
