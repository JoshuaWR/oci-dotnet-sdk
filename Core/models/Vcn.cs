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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// A virtual cloud network (VCN). For more information, see
    /// [Overview of the Networking Service](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/overview.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/iaas/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class Vcn 
    {
        
        /// <value>
        /// The list of BYOIPv6 CIDR blocks required to create a VCN that uses BYOIPv6 ranges.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "byoipv6CidrBlocks")]
        public System.Collections.Generic.List<string> Byoipv6CidrBlocks { get; set; }
        
        /// <value>
        /// For an IPv6-enabled VCN, this is the list of Private IPv6 CIDR blocks for the VCN's IP address space.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipv6PrivateCidrBlocks")]
        public System.Collections.Generic.List<string> Ipv6PrivateCidrBlocks { get; set; }
        
        /// <value>
        /// Deprecated. The first CIDR IP address from cidrBlocks.
        /// <br/>
        /// Example: 172.16.0.0/16
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CidrBlock is required.")]
        [JsonProperty(PropertyName = "cidrBlock")]
        public string CidrBlock { get; set; }
        
        /// <value>
        /// The list of IPv4 CIDR blocks the VCN will use.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CidrBlocks is required.")]
        [JsonProperty(PropertyName = "cidrBlocks")]
        public System.Collections.Generic.List<string> CidrBlocks { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the VCN.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) for the VCN's default set of DHCP options.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "defaultDhcpOptionsId")]
        public string DefaultDhcpOptionsId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) for the VCN's default route table.
        /// </value>
        [JsonProperty(PropertyName = "defaultRouteTableId")]
        public string DefaultRouteTableId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) for the VCN's default security list.
        /// </value>
        [JsonProperty(PropertyName = "defaultSecurityListId")]
        public string DefaultSecurityListId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A DNS label for the VCN, used in conjunction with the VNIC's hostname and
        /// subnet's DNS label to form a fully qualified domain name (FQDN) for each VNIC
        /// within this subnet (for example, `bminstance-1.subnet123.vcn1.oraclevcn.com`).
        /// Must be an alphanumeric string that begins with a letter.
        /// The value cannot be changed.
        /// <br/>
        /// The absence of this parameter means the Internet and VCN Resolver will
        /// not work for this VCN.
        /// <br/>
        /// For more information, see
        /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/dns.htm).
        /// <br/>
        /// Example: vcn1
        /// </value>
        [JsonProperty(PropertyName = "dnsLabel")]
        public string DnsLabel { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The VCN's Oracle ID ([OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// For an IPv6-enabled VCN, this is the list of IPv6 CIDR blocks for the VCN's IP address space.
        /// The CIDRs are provided by Oracle and the sizes are always /56.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipv6CidrBlocks")]
        public System.Collections.Generic.List<string> Ipv6CidrBlocks { get; set; }
                ///
        /// <value>
        /// The VCN's current state.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "UPDATING")]
            Updating
        };

        /// <value>
        /// The VCN's current state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the VCN was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The VCN's domain name, which consists of the VCN's DNS label, and the
        /// `oraclevcn.com` domain.
        /// <br/>
        /// For more information, see
        /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/dns.htm).
        /// <br/>
        /// Example: vcn1.oraclevcn.com
        /// </value>
        [JsonProperty(PropertyName = "vcnDomainName")]
        public string VcnDomainName { get; set; }
        
    }
}
