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

namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Defines the security action details taken on the traffic.
    /// </summary>
    [JsonConverter(typeof(SecurityActionModelConverter))]
    public class SecurityAction 
    {
                ///
        /// <value>
        /// Action taken on the traffic.
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "ALLOWED")]
            Allowed,
            [EnumMember(Value = "DENIED")]
            Denied
        };

                ///
        /// <value>
        /// Type of the `SecurityAction`.
        /// </value>
        ///
        public enum ActionTypeEnum {
            [EnumMember(Value = "EXPLICIT")]
            Explicit,
            [EnumMember(Value = "IMPLICIT")]
            Implicit
        };

        /// <value>
        /// Type of the `SecurityAction`.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionType is required.")]
        [JsonProperty(PropertyName = "actionType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActionTypeEnum> ActionType { get; set; }
        
    }

    public class SecurityActionModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SecurityAction);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SecurityAction);
            var discriminator = jsonObject["action"].Value<string>();
            switch (discriminator)
            {
                case "ALLOWED":
                    obj = new AllowedSecurityAction();
                    break;
                case "DENIED":
                    obj = new DeniedSecurityAction();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under SecurityAction! Returning null value.");
            }
            return obj;
        }
    }
}
