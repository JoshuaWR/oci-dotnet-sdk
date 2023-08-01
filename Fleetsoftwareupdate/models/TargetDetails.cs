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

namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Details of target member of a Exadata Fleet Update Collection.
    /// 
    /// </summary>
    [JsonConverter(typeof(TargetDetailsModelConverter))]
    public class TargetDetails 
    {
                ///
        /// <value>
        /// Resource EntityType for the target in the Exadata Fleet Update Collection.
        /// 
        /// </value>
        ///
        public enum EntityTypeEnum {
            [EnumMember(Value = "DATABASE")]
            Database,
            [EnumMember(Value = "VMCLUSTER")]
            Vmcluster,
            [EnumMember(Value = "CLOUDVMCLUSTER")]
            Cloudvmcluster
        };

        
        /// <value>
        /// OCID of the target resource in the Exadata Fleet Update Collection.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Compartment identifier of the target.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
    }

    public class TargetDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(TargetDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(TargetDetails);
            var discriminator = jsonObject["entityType"].Value<string>();
            switch (discriminator)
            {
                case "VMCLUSTER":
                    obj = new VmClusterTargetSummary();
                    break;
                case "CLOUDVMCLUSTER":
                    obj = new CloudVmClusterTargetSummary();
                    break;
                case "DATABASE":
                    obj = new DatabaseTargetSummary();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under TargetDetails! Returning null value.");
            }
            return obj;
        }
    }
}