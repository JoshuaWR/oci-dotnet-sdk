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

namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details required to enable the specified Database Management feature.
    /// </summary>
    [JsonConverter(typeof(ExternalPluggableDatabaseFeatureDetailsModelConverter))]
    public class ExternalPluggableDatabaseFeatureDetails 
    {
        
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectorDetails is required.")]
        [JsonProperty(PropertyName = "connectorDetails")]
        public ConnectorDetails ConnectorDetails { get; set; }
        
    }

    public class ExternalPluggableDatabaseFeatureDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ExternalPluggableDatabaseFeatureDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ExternalPluggableDatabaseFeatureDetails);
            var discriminator = jsonObject["feature"].Value<string>();
            switch (discriminator)
            {
                case "DIAGNOSTICS_AND_MANAGEMENT":
                    obj = new ExternalPluggableDatabaseDiagnosticsAndManagementFeatureDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}