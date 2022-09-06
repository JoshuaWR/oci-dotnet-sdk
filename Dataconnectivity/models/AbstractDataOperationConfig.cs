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

namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// The information about the data operation.
    /// </summary>
    [JsonConverter(typeof(AbstractDataOperationConfigModelConverter))]
    public class AbstractDataOperationConfig 
    {
                ///
        /// <value>
        /// The type of data operation.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "READ_OPERATION_CONFIG")]
            ReadOperationConfig,
            [EnumMember(Value = "WRITE_OPERATION_CONFIG")]
            WriteOperationConfig
        };

        
        /// <value>
        /// this map is used for passing BIP report/REST parameter values.
        /// </value>
        [JsonProperty(PropertyName = "derivedAttributes")]
        public System.Collections.Generic.Dictionary<string, string> DerivedAttributes { get; set; }
        
    }

    public class AbstractDataOperationConfigModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AbstractDataOperationConfig);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AbstractDataOperationConfig);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "WRITE_OPERATION_CONFIG":
                    obj = new WriteOperationConfig();
                    break;
                case "READ_OPERATION_CONFIG":
                    obj = new ReadOperationConfig();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
