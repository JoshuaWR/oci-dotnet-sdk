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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// The details for associating this DR Protection Group with a peer (remote) DR Protection Group.
    /// </summary>
    public class AssociateDrProtectionGroupDetails 
    {
        
        /// <value>
        /// The OCID of the peer (remote) DR Protection Group.
        /// <br/>
        /// Example: ocid1.drprotectiongroup.oc1.iad.exampleocid2
        /// </value>
        [JsonProperty(PropertyName = "peerId")]
        public string PeerId { get; set; }
        
        /// <value>
        /// The region of the peer (remote) DR Protection Group.
        /// <br/>
        /// Example: us-ashburn-1
        /// </value>
        [JsonProperty(PropertyName = "peerRegion")]
        public string PeerRegion { get; set; }
        
        /// <value>
        /// The role of this DR Protection Group.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Role is required.")]
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DrProtectionGroupRole> Role { get; set; }
        
    }
}
