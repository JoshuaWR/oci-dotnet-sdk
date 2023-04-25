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


namespace Oci.TenantmanagercontrolplaneService.Models
{
    /// <summary>
    /// The information about the organization tenancy.
    /// </summary>
    public class OrganizationTenancy 
    {
        
        /// <value>
        /// OCID of the tenancy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenancyId is required.")]
        [JsonProperty(PropertyName = "tenancyId")]
        public string TenancyId { get; set; }
        
        /// <value>
        /// Name of the tenancy.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Lifecycle state of the organization tenancy.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OrganizationTenancyLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Role of the organization tenancy.
        /// </value>
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OrganizationTenancyRole> Role { get; set; }
        
        /// <value>
        /// Date and time when the tenancy joined the organization.
        /// </value>
        [JsonProperty(PropertyName = "timeJoined")]
        public System.Nullable<System.DateTime> TimeJoined { get; set; }
        
        /// <value>
        /// Date and time when the tenancy left the organization.
        /// </value>
        [JsonProperty(PropertyName = "timeLeft")]
        public System.Nullable<System.DateTime> TimeLeft { get; set; }
        
        /// <value>
        /// Parameter to indicate the tenancy is approved for transfer to another organization.
        /// </value>
        [JsonProperty(PropertyName = "isApprovedForTransfer")]
        public System.Nullable<bool> IsApprovedForTransfer { get; set; }
        
        /// <value>
        /// The governance status of the tenancy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GovernanceStatus is required.")]
        [JsonProperty(PropertyName = "governanceStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<GovernanceStatus> GovernanceStatus { get; set; }
        
    }
}
