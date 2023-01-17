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


namespace Oci.VnmonitoringService.Models
{
    
    public class CreateIpv6Details 
    {
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
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
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// An IPv6 address of your choice. Must be an available IP address within
        /// the subnet's CIDR. If you don't specify a value, Oracle automatically
        /// assigns an IPv6 address from the subnet. The subnet is the one that
        /// contains the VNIC you specify in `vnicId`.
        /// <br/>
        /// Example: 2001:DB8::
        /// </value>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// Whether the IPv6 can be used for internet communication. Allowed by default for an IPv6 in
        /// a public subnet. Never allowed for an IPv6 in a private subnet. If the value is `true`, the
        /// IPv6 uses its public IP address for internet communication.
        /// <br/>
        /// If `isInternetAccessAllowed` is set to `false`, the resulting `publicIpAddress` attribute
        /// for the `Ipv6` is null.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "isInternetAccessAllowed")]
        public System.Nullable<bool> IsInternetAccessAllowed { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VNIC to assign the IPv6 to. The
        /// IPv6 will be in the VNIC's subnet.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VnicId is required.")]
        [JsonProperty(PropertyName = "vnicId")]
        public string VnicId { get; set; }
        
    }
}
