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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// The configuration for an Oracle Streaming Service (OSS) channel.
    /// </summary>
    public class CreateOSSChannelResult : CreateChannelResult
    {
        
        /// <value>
        /// The IDs of the Skills and Digital Assistants that the Channel is routed to.
        /// </value>
        [JsonProperty(PropertyName = "eventSinkBotIds")]
        public System.Collections.Generic.List<string> EventSinkBotIds { get; set; }
        
        /// <value>
        /// The topic inbound messages are received on.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InboundMessageTopic is required.")]
        [JsonProperty(PropertyName = "inboundMessageTopic")]
        public string InboundMessageTopic { get; set; }
        
        /// <value>
        /// The topic outbound messages are sent on.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OutboundMessageTopic is required.")]
        [JsonProperty(PropertyName = "outboundMessageTopic")]
        public string OutboundMessageTopic { get; set; }
        
        /// <value>
        /// The Oracle Streaming Service bootstrap servers.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BootstrapServers is required.")]
        [JsonProperty(PropertyName = "bootstrapServers")]
        public string BootstrapServers { get; set; }
        
        /// <value>
        /// The security protocol to use when conecting to the Oracle Streaming Service. See Oracle Streaming Service documentation for a list of valid values.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityProtocol is required.")]
        [JsonProperty(PropertyName = "securityProtocol")]
        public string SecurityProtocol { get; set; }
        
        /// <value>
        /// The SASL mechanmism to use when conecting to the Oracle Streaming Service. See Oracle Streaming Service documentation for a list of valid values.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SaslMechanism is required.")]
        [JsonProperty(PropertyName = "saslMechanism")]
        public string SaslMechanism { get; set; }
        
        /// <value>
        /// The tenancy to use when connecting to the Oracle Streaming Service.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenancyName is required.")]
        [JsonProperty(PropertyName = "tenancyName")]
        public string TenancyName { get; set; }
        
        /// <value>
        /// The user name to use when connecting to the Oracle Streaming Service.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserName is required.")]
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        
        /// <value>
        /// The stream pool OCI to use when connecting to the Oracle Streaming Service.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StreamPoolId is required.")]
        [JsonProperty(PropertyName = "streamPoolId")]
        public string StreamPoolId { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "OSS";
    }
}
