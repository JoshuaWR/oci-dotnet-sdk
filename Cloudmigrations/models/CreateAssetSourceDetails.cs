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

namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Asset source creation request.
    /// </summary>
    [JsonConverter(typeof(CreateAssetSourceDetailsModelConverter))]
    public class CreateAssetSourceDetails 
    {
        
        
        /// <value>
        /// A user-friendly name for the asset source. Does not have to be unique, and it's mutable.
        /// Avoid entering confidential information. The name is generated by the service if it is not
        /// explicitly provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment for the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the environment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EnvironmentId is required.")]
        [JsonProperty(PropertyName = "environmentId")]
        public string EnvironmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the inventory that will contain created assets.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InventoryId is required.")]
        [JsonProperty(PropertyName = "inventoryId")]
        public string InventoryId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that is going to be used to create assets.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AssetsCompartmentId is required.")]
        [JsonProperty(PropertyName = "assetsCompartmentId")]
        public string AssetsCompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the discovery schedule that is going to be attached to the created asset.
        /// </value>
        [JsonProperty(PropertyName = "discoveryScheduleId")]
        public string DiscoveryScheduleId { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. It exists only for cross-compatibility.
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
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }

    public class CreateAssetSourceDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateAssetSourceDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateAssetSourceDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "VMWARE":
                    obj = new CreateVmWareAssetSourceDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
