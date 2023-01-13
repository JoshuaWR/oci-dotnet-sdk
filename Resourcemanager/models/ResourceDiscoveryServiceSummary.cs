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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// A service supported for use with [Resource Discovery](https://www.terraform.io/docs/providers/oci/guides/resource_discovery.html#services).
    /// 
    /// </summary>
    public class ResourceDiscoveryServiceSummary 
    {
        
        /// <value>
        /// A supported service. Example: coreFor reference on service names, see the [Terraform provider documentation](https://www.terraform.io/docs/providers/oci/guides/resource_discovery.html#services).
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The scope of the service as used with Resource Discovery.
        /// This property determines the type of compartment OCID required: root compartment (`TENANCY`) or not (`COMPARTMENT`).
        /// For example, `identity` is at the root compartment scope while `database` is at the compartment scope.
        /// 
        /// </value>
        ///
        public enum DiscoveryScopeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "TENANCY")]
            Tenancy,
            [EnumMember(Value = "COMPARTMENT")]
            Compartment
        };

        /// <value>
        /// The scope of the service as used with Resource Discovery.
        /// This property determines the type of compartment OCID required: root compartment (`TENANCY`) or not (`COMPARTMENT`).
        /// For example, `identity` is at the root compartment scope while `database` is at the compartment scope.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "discoveryScope")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DiscoveryScopeEnum> DiscoveryScope { get; set; }
        
    }
}
