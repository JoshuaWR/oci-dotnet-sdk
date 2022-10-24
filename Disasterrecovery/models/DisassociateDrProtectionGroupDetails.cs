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

namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// The details for disassociating this DR Protection Group from a peer (remote) DR Protection Group.
    /// </summary>
    [JsonConverter(typeof(DisassociateDrProtectionGroupDetailsModelConverter))]
    public class DisassociateDrProtectionGroupDetails 
    {
                ///
        /// <value>
        /// The default type (required for forward compatibility).
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "DEFAULT")]
            Default
        };

        
    }

    public class DisassociateDrProtectionGroupDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DisassociateDrProtectionGroupDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DisassociateDrProtectionGroupDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "DEFAULT":
                    obj = new DisassociateDrProtectionGroupDefaultDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
