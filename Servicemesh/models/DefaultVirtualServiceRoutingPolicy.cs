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


namespace Oci.ServicemeshService.Models
{
    /// <summary>
    /// Routing policy for the virtual service.
    /// </summary>
    public class DefaultVirtualServiceRoutingPolicy 
    {
                ///
        /// <value>
        /// Type of the virtual service routing policy.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "UNIFORM")]
            Uniform,
            [EnumMember(Value = "DENY")]
            Deny
        };

        /// <value>
        /// Type of the virtual service routing policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
    }
}
