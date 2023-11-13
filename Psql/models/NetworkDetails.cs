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


namespace Oci.PsqlService.Models
{
    /// <summary>
    /// DbSystem network details.
    /// </summary>
    public class NetworkDetails 
    {
        
        /// <value>
        /// Customer Subnet identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// Private IP in customer subnet. The value is optional.
        /// If the IP is not provided the IP will be chosen among the available IP addresses from the specified subnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "primaryDbEndpointPrivateIp")]
        public string PrimaryDbEndpointPrivateIp { get; set; }
        
        /// <value>
        /// List of customer NetworkSecurityGroup identifiers
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
    }
}
