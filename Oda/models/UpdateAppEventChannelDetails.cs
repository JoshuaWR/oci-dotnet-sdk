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
    /// Properties to update an Application Event channel.
    /// </summary>
    public class UpdateAppEventChannelDetails : UpdateChannelDetails
    {
        
        /// <value>
        /// The URL for sending errors and responses to.
        /// </value>
        [JsonProperty(PropertyName = "outboundUrl")]
        public string OutboundUrl { get; set; }
        
        /// <value>
        /// The IDs of the Skills and Digital Assistants that the Channel is routed to.
        /// </value>
        [JsonProperty(PropertyName = "eventSinkBotIds")]
        public System.Collections.Generic.List<string> EventSinkBotIds { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "APPEVENT";
    }
}
