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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// A summary of the proxy user.
    /// </summary>
    public class ProxyUserSummary 
    {
        
        /// <value>
        /// The name of a proxy user or the name of the client user.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// Indicates whether the proxy is required to supply the client credentials (YES) or not (NO).
        /// </value>
        ///
        public enum AuthenticationEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "YES")]
            Yes,
            [EnumMember(Value = "NO")]
            No
        };

        /// <value>
        /// Indicates whether the proxy is required to supply the client credentials (YES) or not (NO).
        /// </value>
        [JsonProperty(PropertyName = "authentication")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AuthenticationEnum> Authentication { get; set; }
                ///
        /// <value>
        /// The flags associated with the proxy/client pair.
        /// </value>
        ///
        public enum FlagsEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROXY_MAY_ACTIVATE_ALL_CLIENT_ROLES")]
            ProxyMayActivateAllClientRoles,
            [EnumMember(Value = "NO_CLIENT_ROLES_MAY_BE_ACTIVATED")]
            NoClientRolesMayBeActivated,
            [EnumMember(Value = "PROXY_MAY_ACTIVATE_ROLE")]
            ProxyMayActivateRole,
            [EnumMember(Value = "PROXY_MAY_NOT_ACTIVATE_ROLE")]
            ProxyMayNotActivateRole
        };

        /// <value>
        /// The flags associated with the proxy/client pair.
        /// </value>
        [JsonProperty(PropertyName = "flags")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<FlagsEnum> Flags { get; set; }
        
    }
}
