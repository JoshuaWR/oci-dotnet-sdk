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

namespace Oci.DatalabelingservicedataplaneService.Models
{
    /// <summary>
    /// An entity allows the labeler to identify an object in the record to label.  This can be, for example, a snippet of text, an entire image, or a bounding box within an image.  All entity types have an array of labels that are indexed. If more than one label is provided, but the annotationType on the corresponding dataset is for a single class, the API rejects the create annotation request.
    /// 
    /// </summary>
    [JsonConverter(typeof(EntityModelConverter))]
    public class Entity 
    {
                ///
        /// <value>
        /// The entity type described in the annotation.
        /// GENERIC  - An extensible entity type that is the base entity type for some annotation formats.
        /// IMAGEOBJECTSELECTION- - This allows the labeler to use specify a bounding polygon on the image to represent an object and apply labels to it.
        /// TEXTSELECTION - This allows the labeler to highlight text, by specifying an offset and a length, and apply labels to it.
        /// KEYVALUESELECTION - This allows the labeler to apply label the highlighted text from OCR.
        /// 
        /// </value>
        ///
        public enum EntityTypeEnum {
            [EnumMember(Value = "GENERIC")]
            Generic,
            [EnumMember(Value = "IMAGEOBJECTSELECTION")]
            Imageobjectselection,
            [EnumMember(Value = "TEXTSELECTION")]
            Textselection,
            [EnumMember(Value = "KEYVALUESELECTION")]
            Keyvalueselection
        };

        
    }

    public class EntityModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(Entity);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(Entity);
            var discriminator = jsonObject["entityType"].Value<string>();
            switch (discriminator)
            {
                case "IMAGEOBJECTSELECTION":
                    obj = new ImageObjectSelectionEntity();
                    break;
                case "GENERIC":
                    obj = new GenericEntity();
                    break;
                case "KEYVALUESELECTION":
                    obj = new KeyValueSelectionEntity();
                    break;
                case "TEXTSELECTION":
                    obj = new TextSelectionEntity();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under Entity! Returning null value.");
            }
            return obj;
        }
    }
}
