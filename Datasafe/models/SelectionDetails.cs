/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// Details of the items to be selected and the mode of selection.
    /// 
    /// </summary>
    [JsonConverter(typeof(SelectionDetailsModelConverter))]
    public class SelectionDetails 
    {
                ///
        /// <value>
        /// The mode of selection of items, whether it is a list of ocids or a scimQuery. Allowed values:
        /// - LIST
        /// - SCIM_QUERY
        /// 
        /// </value>
        ///
        public enum SelectionModeEnum {
            [EnumMember(Value = "LIST")]
            List,
            [EnumMember(Value = "SCIM_QUERY")]
            ScimQuery
        };

        
    }

    public class SelectionDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SelectionDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SelectionDetails);
            var discriminator = jsonObject["selectionMode"].Value<string>();
            switch (discriminator)
            {
                case "LIST":
                    obj = new ListSelectionMode();
                    break;
                case "SCIM_QUERY":
                    obj = new ScimQuerySelectionMode();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
