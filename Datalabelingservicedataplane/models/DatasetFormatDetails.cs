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
    /// It specifies how to process the data. Supported formats include DOCUMENT, IMAGE, and TEXT.
    /// </summary>
    [JsonConverter(typeof(DatasetFormatDetailsModelConverter))]
    public class DatasetFormatDetails 
    {
                ///
        /// <value>
        /// The format type. DOCUMENT format is for record contents that are PDFs or TIFFs. IMAGE format is for record contents that are JPEGs or PNGs. TEXT format is for record contents that are TXT files.
        /// </value>
        ///
        public enum FormatTypeEnum {
            [EnumMember(Value = "DOCUMENT")]
            Document,
            [EnumMember(Value = "IMAGE")]
            Image,
            [EnumMember(Value = "TEXT")]
            Text
        };

        
    }

    public class DatasetFormatDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DatasetFormatDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DatasetFormatDetails);
            var discriminator = jsonObject["formatType"].Value<string>();
            switch (discriminator)
            {
                case "IMAGE":
                    obj = new ImageDatasetFormatDetails();
                    break;
                case "DOCUMENT":
                    obj = new DocumentDatasetFormatDetails();
                    break;
                case "TEXT":
                    obj = new TextDatasetFormatDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under DatasetFormatDetails! Returning null value.");
            }
            return obj;
        }
    }
}
