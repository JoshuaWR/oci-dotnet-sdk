/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// Update Request for creating Tunnel Inspection Rule used in the firewall policy rules.
    /// Tunnel Inspection Rule determines whether tunnel inspection is applied on the traffic based on attributes
    /// such as Tunnel Inspect protocol, the source and destination IP address.
    /// 
    /// </summary>
    [JsonConverter(typeof(UpdateTunnelInspectionRuleDetailsModelConverter))]
    public class UpdateTunnelInspectionRuleDetails 
    {
        
        /// <value>
        /// Types of Inspect Action on the Traffic flow.
        /// <br/>
        ///   * INSPECT - Inspect the traffic.
        ///   * INSPECT_AND_CAPTURE_LOG - Inspect and capture logs for the traffic.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InspectActionType> Action { get; set; }
        
        
        [JsonProperty(PropertyName = "position")]
        public RulePosition Position { get; set; }
        
    }

    public class UpdateTunnelInspectionRuleDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateTunnelInspectionRuleDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateTunnelInspectionRuleDetails);
            var discriminator = jsonObject["protocol"].Value<string>();
            switch (discriminator)
            {
                case "VXLAN":
                    obj = new UpdateVxlanInspectionRuleDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}