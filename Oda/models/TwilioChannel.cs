/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    /// The configuration for a Twilio channel.
    /// </summary>
    public class TwilioChannel : Channel
    {
        
        /// <value>
        /// The Account SID for the Twilio number.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AccountSID is required.")]
        [JsonProperty(PropertyName = "accountSID")]
        public string AccountSID { get; set; }
        
        /// <value>
        /// The Twilio phone number.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PhoneNumber is required.")]
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }
        
        /// <value>
        /// Whether MMS is enabled for this channel or not.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsMmsEnabled is required.")]
        [JsonProperty(PropertyName = "isMmsEnabled")]
        public System.Nullable<bool> IsMmsEnabled { get; set; }
        
        /// <value>
        /// The original connectors URL (used for backward compatibility).
        /// </value>
        [JsonProperty(PropertyName = "originalConnectorsUrl")]
        public string OriginalConnectorsUrl { get; set; }
        
        /// <value>
        /// The ID of the Skill or Digital Assistant that the Channel is routed to.
        /// </value>
        [JsonProperty(PropertyName = "botId")]
        public string BotId { get; set; }
        
        /// <value>
        /// The URL to use to send messages to this channel.
        /// This will be generally be used to configure a webhook in a 3rd party messaging system to send messages to this channel.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WebhookUrl is required.")]
        [JsonProperty(PropertyName = "webhookUrl")]
        public string WebhookUrl { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "TWILIO";
    }
}