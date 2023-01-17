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

namespace Oci.ServicemeshService.Models
{
    /// <summary>
    /// Rule for routing incoming virtual service traffic to a version.
    /// </summary>
    [JsonConverter(typeof(VirtualServiceTrafficRouteRuleModelConverter))]
    public class VirtualServiceTrafficRouteRule 
    {
                ///
        /// <value>
        /// Type of protocol.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "HTTP")]
            Http,
            [EnumMember(Value = "TLS_PASSTHROUGH")]
            TlsPassthrough,
            [EnumMember(Value = "TCP")]
            Tcp
        };

        
        /// <value>
        /// The destination of the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Destinations is required.")]
        [JsonProperty(PropertyName = "destinations")]
        public System.Collections.Generic.List<VirtualDeploymentTrafficRuleTarget> Destinations { get; set; }
        
    }

    public class VirtualServiceTrafficRouteRuleModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(VirtualServiceTrafficRouteRule);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(VirtualServiceTrafficRouteRule);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "TCP":
                    obj = new TcpVirtualServiceTrafficRouteRule();
                    break;
                case "TLS_PASSTHROUGH":
                    obj = new TlsPassthroughVirtualServiceTrafficRouteRule();
                    break;
                case "HTTP":
                    obj = new HttpVirtualServiceTrafficRouteRule();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under VirtualServiceTrafficRouteRule! Returning null value.");
            }
            return obj;
        }
    }
}
