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
    /// A rule for allowing inbound IP packets.
    /// </summary>
    public class IngressSecurityRule 
    {
        
        [JsonProperty(PropertyName = "icmpOptions")]
        public IcmpOptions IcmpOptions { get; set; }
        
        /// <value>
        /// A stateless rule allows traffic in one direction. Remember to add a corresponding
        /// stateless rule in the other direction if you need to support bidirectional traffic. For
        /// example, if ingress traffic allows TCP destination port 80, there should be an egress
        /// rule to allow TCP source port 80. Defaults to false, which means the rule is stateful
        /// and a corresponding rule is not necessary for bidirectional traffic.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isStateless")]
        public System.Nullable<bool> IsStateless { get; set; }
        
        /// <value>
        /// The transport protocol. Specify either `all` or an IPv4 protocol number as
        /// defined in
        /// [Protocol Numbers](http://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml).
        /// Options are supported only for ICMP (\"1\"), TCP (\"6\"), UDP (\"17\"), and ICMPv6 (\"58\").
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }
        
        /// <value>
        /// Conceptually, this is the range of IP addresses that a packet coming into the instance
        /// can come from.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * IP address range in CIDR notation. For Example: 192.168.1.0/24 or 2001:0db8:0123:45::/56.    IPv6 addressing is supported for all commercial and government regions. See    [IPv6 Addresses](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/ipv6.htm).  * The cidrBlock value for a {@link Service}, if you're    setting up a security list rule for traffic coming from a particular Service through    a service gateway. For
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Source is required.")]
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }
                ///
        /// <value>
        /// Type of source for the rule. The default is `CIDR_BLOCK`.
        /// <br/>
        ///   * `CIDR_BLOCK`: If the rule's `source` is an IP address range in CIDR notation.
        /// <br/>
        ///   * `SERVICE_CIDR_BLOCK`: If the rule's `source` is the `cidrBlock` value for a
        ///     {@link Service} (the rule is for traffic coming from a
        ///     particular `Service` through a service gateway).
        /// 
        /// </value>
        ///
        public enum SourceTypeEnum {
            [EnumMember(Value = "CIDR_BLOCK")]
            CidrBlock,
            [EnumMember(Value = "SERVICE_CIDR_BLOCK")]
            ServiceCidrBlock
        };

        /// <value>
        /// Type of source for the rule. The default is `CIDR_BLOCK`.
        /// <br/>
        ///   * `CIDR_BLOCK`: If the rule's `source` is an IP address range in CIDR notation.
        /// <br/>
        ///   * `SERVICE_CIDR_BLOCK`: If the rule's `source` is the `cidrBlock` value for a
        ///     {@link Service} (the rule is for traffic coming from a
        ///     particular `Service` through a service gateway).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SourceTypeEnum> SourceType { get; set; }
        
        [JsonProperty(PropertyName = "tcpOptions")]
        public TcpOptions TcpOptions { get; set; }
        
        [JsonProperty(PropertyName = "udpOptions")]
        public UdpOptions UdpOptions { get; set; }
        
    }
}
