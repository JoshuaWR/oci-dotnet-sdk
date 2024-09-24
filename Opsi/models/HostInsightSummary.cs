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

namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Summary of a host insight resource.
    /// </summary>
    [JsonConverter(typeof(HostInsightSummaryModelConverter))]
    public class HostInsightSummary 
    {
        
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the host insight resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The host name. The host name is unique amongst the hosts managed by the same management agent.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostName is required.")]
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
        
        /// <value>
        /// The user-friendly name for the host. The name does not have to be unique.
        /// </value>
        [JsonProperty(PropertyName = "hostDisplayName")]
        public string HostDisplayName { get; set; }
        
        /// <value>
        /// Ops Insights internal representation of the host type. Possible value is EXTERNAL-HOST.
        /// </value>
        [JsonProperty(PropertyName = "hostType")]
        public string HostType { get; set; }
        
        /// <value>
        /// Processor count. This is the OCPU count for Autonomous Database and CPU core count for other database types.
        /// </value>
        [JsonProperty(PropertyName = "processorCount")]
        public System.Nullable<int> ProcessorCount { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the OPSI private endpoint
        /// </value>
        [JsonProperty(PropertyName = "opsiPrivateEndpointId")]
        public string OpsiPrivateEndpointId { get; set; }
        
        /// <value>
        /// Indicates the status of a host insight in Ops Insights
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceStatus> Status { get; set; }
        
        /// <value>
        /// The time the the host insight was first enabled. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the host insight was updated. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the host.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
    }

    public class HostInsightSummaryModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(HostInsightSummary);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(HostInsightSummary);
            var discriminator = jsonObject["entitySource"].Value<string>();
            switch (discriminator)
            {
                case "MACS_MANAGED_EXTERNAL_HOST":
                    obj = new MacsManagedExternalHostInsightSummary();
                    break;
                case "MACS_MANAGED_CLOUD_DB_HOST":
                    obj = new MacsManagedCloudDatabaseHostInsightSummary();
                    break;
                case "EM_MANAGED_EXTERNAL_HOST":
                    obj = new EmManagedExternalHostInsightSummary();
                    break;
                case "PE_COMANAGED_HOST":
                    obj = new PeComanagedHostInsightSummary();
                    break;
                case "MACS_MANAGED_CLOUD_HOST":
                    obj = new MacsManagedCloudHostInsightSummary();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under HostInsightSummary! Returning null value.");
            }
            return obj;
        }
    }
}
