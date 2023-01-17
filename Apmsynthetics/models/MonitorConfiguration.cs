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

namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Details of monitor configuration.
    /// </summary>
    [JsonConverter(typeof(MonitorConfigurationModelConverter))]
    public class MonitorConfiguration 
    {
                ///
        /// <value>
        /// Type of configuration.
        /// </value>
        ///
        public enum ConfigTypeEnum {
            [EnumMember(Value = "BROWSER_CONFIG")]
            BrowserConfig,
            [EnumMember(Value = "SCRIPTED_BROWSER_CONFIG")]
            ScriptedBrowserConfig,
            [EnumMember(Value = "REST_CONFIG")]
            RestConfig,
            [EnumMember(Value = "SCRIPTED_REST_CONFIG")]
            ScriptedRestConfig
        };

        
        /// <value>
        /// If isFailureRetried is enabled, then a failed call will be retried.
        /// </value>
        [JsonProperty(PropertyName = "isFailureRetried")]
        public System.Nullable<bool> IsFailureRetried { get; set; }
        
        [JsonProperty(PropertyName = "dnsConfiguration")]
        public DnsConfiguration DnsConfiguration { get; set; }
        
    }

    public class MonitorConfigurationModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(MonitorConfiguration);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(MonitorConfiguration);
            var discriminator = jsonObject["configType"].Value<string>();
            switch (discriminator)
            {
                case "SCRIPTED_REST_CONFIG":
                    obj = new ScriptedRestMonitorConfiguration();
                    break;
                case "SCRIPTED_BROWSER_CONFIG":
                    obj = new ScriptedBrowserMonitorConfiguration();
                    break;
                case "REST_CONFIG":
                    obj = new RestMonitorConfiguration();
                    break;
                case "BROWSER_CONFIG":
                    obj = new BrowserMonitorConfiguration();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under MonitorConfiguration! Returning null value.");
            }
            return obj;
        }
    }
}
