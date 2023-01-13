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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Node details associated with a network.
    /// </summary>
    public class NodeDetails 
    {
        
        /// <value>
        /// The node host name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Hostname is required.")]
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// The node IP address.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ip is required.")]
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }
        
        /// <value>
        /// The node virtual IP (VIP) host name.
        /// </value>
        [JsonProperty(PropertyName = "vipHostname")]
        public string VipHostname { get; set; }
        
        /// <value>
        /// The node virtual IP (VIP) address.
        /// </value>
        [JsonProperty(PropertyName = "vip")]
        public string Vip { get; set; }
                ///
        /// <value>
        /// The current state of the VM cluster network nodes.
        /// CREATING - The resource is being created
        /// REQUIRES_VALIDATION - The resource is created and may not be usable until it is validated.
        /// VALIDATING - The resource is being validated and not available to use.
        /// VALIDATED - The resource is validated and is available for consumption by VM cluster.
        /// VALIDATION_FAILED - The resource validation has failed and might require user input to be corrected.
        /// UPDATING - The resource is being updated and not available to use.
        /// ALLOCATED - The resource is currently being used by VM cluster.
        /// TERMINATING - The resource is being deleted and not available to use.
        /// TERMINATED - The resource is deleted and unavailable.
        /// FAILED - The resource is in a failed state due to validation or other errors.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "REQUIRES_VALIDATION")]
            RequiresValidation,
            [EnumMember(Value = "VALIDATING")]
            Validating,
            [EnumMember(Value = "VALIDATED")]
            Validated,
            [EnumMember(Value = "VALIDATION_FAILED")]
            ValidationFailed,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ALLOCATED")]
            Allocated,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the VM cluster network nodes.
        /// CREATING - The resource is being created
        /// REQUIRES_VALIDATION - The resource is created and may not be usable until it is validated.
        /// VALIDATING - The resource is being validated and not available to use.
        /// VALIDATED - The resource is validated and is available for consumption by VM cluster.
        /// VALIDATION_FAILED - The resource validation has failed and might require user input to be corrected.
        /// UPDATING - The resource is being updated and not available to use.
        /// ALLOCATED - The resource is currently being used by VM cluster.
        /// TERMINATING - The resource is being deleted and not available to use.
        /// TERMINATED - The resource is deleted and unavailable.
        /// FAILED - The resource is in a failed state due to validation or other errors.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The Db server associated with the node.
        /// </value>
        [JsonProperty(PropertyName = "dbServerId")]
        public string DbServerId { get; set; }
        
    }
}
