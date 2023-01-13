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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The properties that define a request to create a cluster kubeconfig.
    /// </summary>
    public class CreateClusterKubeconfigContentDetails 
    {
        
        /// <value>
        /// The version of the kubeconfig token. Supported value 2.0.0
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tokenVersion")]
        public string TokenVersion { get; set; }
        
        /// <value>
        /// Deprecated. This field is no longer used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "expiration")]
        public System.Nullable<int> Expiration { get; set; }
                ///
        /// <value>
        /// The endpoint to target. A cluster may have multiple endpoints exposed but the kubeconfig can only target one at a time.
        /// </value>
        ///
        public enum EndpointEnum {
            [EnumMember(Value = "LEGACY_KUBERNETES")]
            LegacyKubernetes,
            [EnumMember(Value = "PUBLIC_ENDPOINT")]
            PublicEndpoint,
            [EnumMember(Value = "PRIVATE_ENDPOINT")]
            PrivateEndpoint,
            [EnumMember(Value = "VCN_HOSTNAME")]
            VcnHostname
        };

        /// <value>
        /// The endpoint to target. A cluster may have multiple endpoints exposed but the kubeconfig can only target one at a time.
        /// </value>
        [JsonProperty(PropertyName = "endpoint")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<EndpointEnum> Endpoint { get; set; }
        
    }
}
