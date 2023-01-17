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

namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Migration tablespace settings.
    /// 
    /// </summary>
    [JsonConverter(typeof(TargetTypeTablespaceDetailsModelConverter))]
    public class TargetTypeTablespaceDetails 
    {
        
        
    }

    public class TargetTypeTablespaceDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(TargetTypeTablespaceDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(TargetTypeTablespaceDetails);
            var discriminator = jsonObject["targetType"].Value<string>();
            switch (discriminator)
            {
                case "ADB_D_AUTOCREATE":
                    obj = new ADBDedicatedAutoCreateTablespaceDetails();
                    break;
                case "ADB_S_REMAP":
                    obj = new ADBServerlesTablespaceDetails();
                    break;
                case "ADB_D_REMAP":
                    obj = new ADBDedicatedRemapTargetTablespaceDetails();
                    break;
                case "NON_ADB_REMAP":
                    obj = new NonADBRemapTablespaceDetails();
                    break;
                case "NON_ADB_AUTOCREATE":
                    obj = new NonADBAutoCreateTablespaceDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under TargetTypeTablespaceDetails! Returning null value.");
            }
            return obj;
        }
    }
}
