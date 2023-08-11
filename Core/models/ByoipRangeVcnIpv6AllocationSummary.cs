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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// A summary of IPv6 prefix subranges currently allocated to a VCN.
    /// 
    /// </summary>
    public class ByoipRangeVcnIpv6AllocationSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the `ByoipRange` resource to which the CIDR block belongs.
        /// </value>
        [JsonProperty(PropertyName = "byoipRangeId")]
        public string ByoipRangeId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the `ByoipRange`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The BYOIPv6 prefix range or subrange allocated to a VCN. This could be all or part of a BYOIPv6 prefix.
        /// Each VCN allocation must be /64 or larger.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipv6CidrBlock")]
        public string Ipv6CidrBlock { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the `Vcn` resource to which the ByoipRange belongs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
    }
}
