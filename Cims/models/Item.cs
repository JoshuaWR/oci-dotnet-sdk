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

namespace Oci.CimsService.Models
{
    /// <summary>
    /// Details about the item object.
    /// </summary>
    [JsonConverter(typeof(ItemModelConverter))]
    public class Item 
    {
        
        /// <value>
        /// Unique identifier for the item.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ItemKey is required.")]
        [JsonProperty(PropertyName = "itemKey")]
        public string ItemKey { get; set; }
        
        /// <value>
        /// The display name of the item.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        
        [JsonProperty(PropertyName = "category")]
        public Category Category { get; set; }
        
        [JsonProperty(PropertyName = "subCategory")]
        public SubCategory SubCategory { get; set; }
        
        [JsonProperty(PropertyName = "issueType")]
        public IssueType IssueType { get; set; }
        
    }

    public class ItemModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(Item);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(Item);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "limit":
                    obj = new LimitItem();
                    break;
                case "tech":
                    obj = new TechSupportItem();
                    break;
                case "activity":
                    obj = new ActivityItem();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
