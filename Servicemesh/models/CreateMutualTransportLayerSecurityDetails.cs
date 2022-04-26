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
    /// The mTLS authentication mode to use when receiving requests from other virtual services or ingress gateways within the mesh.
    /// 
    /// </summary>
    public class CreateMutualTransportLayerSecurityDetails 
    {
        
        /// <value>
        /// The number of days the mTLS certificate is valid.  This value should be less than the Maximum Validity Duration 
        /// for Certificates (Days) setting on the Certificate Authority associated with this Mesh.  The certificate will
        /// be automatically renewed after 2/3 of the validity period, so a certificate with a maximum validity of 45 days
        /// will be renewed every 30 days.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maximumValidity")]
        public System.Nullable<int> MaximumValidity { get; set; }
        
        /// <value>
        /// DISABLED: Connection is not tunneled.
        /// PERMISSIVE: Connection can be either plaintext or an mTLS tunnel.
        /// STRICT: Connection is an mTLS tunnel.  Clients without a valid certificate will be rejected.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Mode is required.")]
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MutualTransportLayerSecurity.ModeEnum> Mode { get; set; }
        
    }
}
