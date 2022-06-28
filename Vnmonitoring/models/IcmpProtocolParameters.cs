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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Defines the configuration for the [ICMP](https://www.iana.org/assignments/icmp-parameters/icmp-parameters.xhtml) protocol parameters.
    /// 
    /// </summary>
    public class IcmpProtocolParameters : ProtocolParameters
    {
        
        /// <value>
        /// The [ICMP](https://www.iana.org/assignments/icmp-parameters/icmp-parameters.xhtml) code.
        /// </value>
        [JsonProperty(PropertyName = "icmpCode")]
        public System.Nullable<int> IcmpCode { get; set; }
        
        /// <value>
        /// The [ICMP](https://www.iana.org/assignments/icmp-parameters/icmp-parameters.xhtml) type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IcmpType is required.")]
        [JsonProperty(PropertyName = "icmpType")]
        public System.Nullable<int> IcmpType { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "ICMP";
    }
}
