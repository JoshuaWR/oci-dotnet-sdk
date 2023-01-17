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


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Network node
    /// </summary>
    public class Node 
    {
        
        /// <value>
        /// id of node
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// ip address of node
        /// </value>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// display name of node
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// geo info
        /// </value>
        [JsonProperty(PropertyName = "geoInfo")]
        public string GeoInfo { get; set; }
        
        /// <value>
        /// links outgoing from this node
        /// </value>
        [JsonProperty(PropertyName = "outgoingLinks")]
        public System.Collections.Generic.List<string> OutgoingLinks { get; set; }
        
        /// <value>
        /// consecutive anonymous node count
        /// </value>
        [JsonProperty(PropertyName = "consecutiveAnonymousCount")]
        public System.Nullable<int> ConsecutiveAnonymousCount { get; set; }
        
        /// <value>
        /// level of this node
        /// </value>
        [JsonProperty(PropertyName = "level")]
        public System.Nullable<int> Level { get; set; }
        
        /// <value>
        /// average packet response time in milli seconds
        /// </value>
        [JsonProperty(PropertyName = "avgPacketResponseTimeInMs")]
        public System.Double AvgPacketResponseTimeInMs { get; set; }
        
        /// <value>
        /// average packet loss percentage
        /// </value>
        [JsonProperty(PropertyName = "avgPacketLossPercent")]
        public System.Double AvgPacketLossPercent { get; set; }
                ///
        /// <value>
        /// type of node
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SOURCE")]
            Source,
            [EnumMember(Value = "DESTINATION")]
            Destination,
            [EnumMember(Value = "ANONYMOUS")]
            Anonymous,
            [EnumMember(Value = "INTERNAL")]
            Internal,
            [EnumMember(Value = "DANGLING")]
            Dangling
        };

        /// <value>
        /// type of node
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
    }
}
