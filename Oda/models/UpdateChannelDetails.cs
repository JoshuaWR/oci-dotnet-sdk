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

namespace Oci.OdaService.Models
{
    /// <summary>
    /// Properties to update a Channel.
    /// </summary>
    [JsonConverter(typeof(UpdateChannelDetailsModelConverter))]
    public class UpdateChannelDetails 
    {
        
        /// <value>
        /// A short description of the Channel.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        
        /// <value>
        /// The number of milliseconds before a session expires.
        /// </value>
        [JsonProperty(PropertyName = "sessionExpiryDurationInMilliseconds")]
        public System.Nullable<long> SessionExpiryDurationInMilliseconds { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type, or scope.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }

    public class UpdateChannelDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateChannelDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateChannelDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "OSVC":
                    obj = new UpdateOsvcChannelDetails();
                    break;
                case "OSS":
                    obj = new UpdateOSSChannelDetails();
                    break;
                case "ANDROID":
                    obj = new UpdateAndroidChannelDetails();
                    break;
                case "MSTEAMS":
                    obj = new UpdateMSTeamsChannelDetails();
                    break;
                case "APPEVENT":
                    obj = new UpdateAppEventChannelDetails();
                    break;
                case "WEB":
                    obj = new UpdateWebChannelDetails();
                    break;
                case "IOS":
                    obj = new UpdateIosChannelDetails();
                    break;
                case "SLACK":
                    obj = new UpdateSlackChannelDetails();
                    break;
                case "SERVICECLOUD":
                    obj = new UpdateServiceCloudChannelDetails();
                    break;
                case "TWILIO":
                    obj = new UpdateTwilioChannelDetails();
                    break;
                case "WEBHOOK":
                    obj = new UpdateWebhookChannelDetails();
                    break;
                case "APPLICATION":
                    obj = new UpdateApplicationChannelDetails();
                    break;
                case "FACEBOOK":
                    obj = new UpdateFacebookChannelDetails();
                    break;
                case "CORTANA":
                    obj = new UpdateCortanaChannelDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
