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

namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Defines the relationship between Virtual Network topology entities.
    /// </summary>
    [JsonConverter(typeof(TopologyEntityRelationshipModelConverter))]
    public class TopologyEntityRelationship 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the first entity in the relationship.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id1 is required.")]
        [JsonProperty(PropertyName = "id1")]
        public string Id1 { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the second entity in the relationship.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id2 is required.")]
        [JsonProperty(PropertyName = "id2")]
        public string Id2 { get; set; }
                ///
        /// <value>
        /// The type of relationship between the entities.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "CONTAINS")]
            Contains,
            [EnumMember(Value = "ASSOCIATED_WITH")]
            AssociatedWith,
            [EnumMember(Value = "ROUTES_TO")]
            RoutesTo
        };

        
    }

    public class TopologyEntityRelationshipModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(TopologyEntityRelationship);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(TopologyEntityRelationship);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "ROUTES_TO":
                    obj = new TopologyRoutesToEntityRelationship();
                    break;
                case "ASSOCIATED_WITH":
                    obj = new TopologyAssociatedWithEntityRelationship();
                    break;
                case "CONTAINS":
                    obj = new TopologyContainsEntityRelationship();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
