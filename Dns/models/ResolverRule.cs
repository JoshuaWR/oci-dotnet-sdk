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

namespace Oci.DnsService.Models
{
    /// <summary>
    /// A rule for a resolver. Specifying both qnameCoverConditions and clientAddressConditions is not allowed.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    [JsonConverter(typeof(ResolverRuleModelConverter))]
    public class ResolverRule 
    {
        
        /// <value>
        /// A list of CIDR blocks. The query must come from a client within one of the blocks in order for the rule action
        /// to apply.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClientAddressConditions is required.")]
        [JsonProperty(PropertyName = "clientAddressConditions")]
        public System.Collections.Generic.List<string> ClientAddressConditions { get; set; }
        
        /// <value>
        /// A list of domain names. The query must be covered by one of the domains in order for the rule action to apply.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "QnameCoverConditions is required.")]
        [JsonProperty(PropertyName = "qnameCoverConditions")]
        public System.Collections.Generic.List<string> QnameCoverConditions { get; set; }
                ///
        /// <value>
        /// The action determines the behavior of the rule. If a query matches a supplied condition, the action will
        /// apply. If there are no conditions on the rule, all queries are subject to the specified action.
        /// * `FORWARD` - Matching requests will be forwarded from the source interface to the destination address.
        /// 
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "FORWARD")]
            Forward
        };

        
    }

    public class ResolverRuleModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ResolverRule);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ResolverRule);
            var discriminator = jsonObject["action"].Value<string>();
            switch (discriminator)
            {
                case "FORWARD":
                    obj = new ResolverForwardRule();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ResolverRule! Returning null value.");
            }
            return obj;
        }
    }
}
