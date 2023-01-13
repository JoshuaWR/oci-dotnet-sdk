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
    /// DHCP option for specifying how DNS (hostname resolution) is handled in the subnets in the VCN.
    /// For more information, see
    /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/dns.htm).
    /// 
    /// </summary>
    public class DhcpDnsOption : DhcpOption
    {
        
        /// <value>
        /// If you set `serverType` to `CustomDnsServer`, specify the
        /// IP address of at least one DNS server of your choice (three maximum).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customDnsServers")]
        public System.Collections.Generic.List<string> CustomDnsServers { get; set; }
                ///
        /// <value>
        /// * **VcnLocal:** Reserved for future use.
        /// <br/>
        /// * **VcnLocalPlusInternet:** Also referred to as \"Internet and VCN Resolver\".
        /// Instances can resolve internet hostnames (no internet gateway is required),
        /// and can resolve hostnames of instances in the VCN. This is the default
        /// value in the default set of DHCP options in the VCN. For the Internet and
        /// VCN Resolver to work across the VCN, there must also be a DNS label set for
        /// the VCN, a DNS label set for each subnet, and a hostname for each instance.
        /// The Internet and VCN Resolver also enables reverse DNS lookup, which lets
        /// you determine the hostname corresponding to the private IP address. For more
        /// information, see
        /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/dns.htm).
        /// <br/>
        /// * **CustomDnsServer:** Instances use a DNS server of your choice (three
        /// maximum).
        /// 
        /// </value>
        ///
        public enum ServerTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "VcnLocal")]
            VcnLocal,
            [EnumMember(Value = "VcnLocalPlusInternet")]
            VcnLocalPlusInternet,
            [EnumMember(Value = "CustomDnsServer")]
            CustomDnsServer
        };

        /// <value>
        /// * **VcnLocal:** Reserved for future use.
        /// <br/>
        /// * **VcnLocalPlusInternet:** Also referred to as \"Internet and VCN Resolver\".
        /// Instances can resolve internet hostnames (no internet gateway is required),
        /// and can resolve hostnames of instances in the VCN. This is the default
        /// value in the default set of DHCP options in the VCN. For the Internet and
        /// VCN Resolver to work across the VCN, there must also be a DNS label set for
        /// the VCN, a DNS label set for each subnet, and a hostname for each instance.
        /// The Internet and VCN Resolver also enables reverse DNS lookup, which lets
        /// you determine the hostname corresponding to the private IP address. For more
        /// information, see
        /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/dns.htm).
        /// <br/>
        /// * **CustomDnsServer:** Instances use a DNS server of your choice (three
        /// maximum).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServerType is required.")]
        [JsonProperty(PropertyName = "serverType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ServerTypeEnum> ServerType { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "DomainNameServer";
    }
}
