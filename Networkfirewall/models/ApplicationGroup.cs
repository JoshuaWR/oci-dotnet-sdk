/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// A group of applications.
    /// 
    /// </summary>
    public class ApplicationGroup 
    {
        
        /// <value>
        /// Name of the application Group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// List of apps in the group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Apps is required.")]
        [JsonProperty(PropertyName = "apps")]
        public System.Collections.Generic.List<string> Apps { get; set; }
        
        /// <value>
        /// Count of total applications in the given application group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalApps is required.")]
        [JsonProperty(PropertyName = "totalApps")]
        public System.Nullable<int> TotalApps { get; set; }
        
        /// <value>
        /// OCID of the Network Firewall Policy this application group belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParentResourceId is required.")]
        [JsonProperty(PropertyName = "parentResourceId")]
        public string ParentResourceId { get; set; }
        
    }
}