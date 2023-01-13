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

namespace Oci.DnsService.Models
{
    /// <summary>
    /// The body for updating an existing resolver endpoint.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    [JsonConverter(typeof(UpdateResolverEndpointDetailsModelConverter))]
    public class UpdateResolverEndpointDetails 
    {
                ///
        /// <value>
        /// The type of resolver endpoint. VNIC is currently the only supported type.
        /// 
        /// </value>
        ///
        public enum EndpointTypeEnum {
            [EnumMember(Value = "VNIC")]
            Vnic
        };

        
    }

    public class UpdateResolverEndpointDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateResolverEndpointDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateResolverEndpointDetails);
            var discriminator = jsonObject["endpointType"].Value<string>();
            switch (discriminator)
            {
                case "VNIC":
                    obj = new UpdateResolverVnicEndpointDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
