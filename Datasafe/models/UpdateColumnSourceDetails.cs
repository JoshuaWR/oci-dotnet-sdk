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

namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Details to update the column source of a masking policy.
    /// </summary>
    [JsonConverter(typeof(UpdateColumnSourceDetailsModelConverter))]
    public class UpdateColumnSourceDetails 
    {
                ///
        /// <value>
        /// The source of masking columns.
        /// </value>
        ///
        public enum ColumnSourceEnum {
            [EnumMember(Value = "TARGET")]
            Target,
            [EnumMember(Value = "SENSITIVE_DATA_MODEL")]
            SensitiveDataModel
        };

        
    }

    public class UpdateColumnSourceDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateColumnSourceDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateColumnSourceDetails);
            var discriminator = jsonObject["columnSource"].Value<string>();
            switch (discriminator)
            {
                case "SENSITIVE_DATA_MODEL":
                    obj = new UpdateColumnSourceSdmDetails();
                    break;
                case "TARGET":
                    obj = new UpdateColumnSourceTargetDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
