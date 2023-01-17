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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The integration task published object.
    /// </summary>
    public class PublishedObjectFromIntegrationTask : PublishedObject
    {
        
        /// <value>
        /// An array of input ports.
        /// </value>
        [JsonProperty(PropertyName = "inputPorts")]
        public System.Collections.Generic.List<InputPort> InputPorts { get; set; }
        
        /// <value>
        /// An array of output ports.
        /// </value>
        [JsonProperty(PropertyName = "outputPorts")]
        public System.Collections.Generic.List<OutputPort> OutputPorts { get; set; }
        
        /// <value>
        /// An array of parameters.
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<Parameter> Parameters { get; set; }
        
        [JsonProperty(PropertyName = "opConfigValues")]
        public ConfigValues OpConfigValues { get; set; }
        
        [JsonProperty(PropertyName = "configProviderDelegate")]
        public ConfigProvider ConfigProviderDelegate { get; set; }
        
        [JsonProperty(PropertyName = "dataFlow")]
        public DataFlow DataFlow { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "INTEGRATION_TASK";
    }
}
