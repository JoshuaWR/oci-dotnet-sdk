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


namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// An endpoint is an organizational construct to keep multiple data connectivity management solutions and their resources (pe-id, dnsProxyIp, dnsZones, and so on) separate from each other, helping you to stay organized. For example, you could have separate registries for development, testing, and production.
    /// </summary>
    public class Endpoint 
    {
        
        /// <value>
        /// VCN OCID where the subnet resides.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
        /// <value>
        /// Subnet OCID of the customer connected network where, for example, the databases reside.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// List of DNS zones to be used by the data assets to be harvested.
        /// Example: custpvtsubnet.oraclevcn.com for data asset: db.custpvtsubnet.oraclevcn.com
        /// </value>
        [JsonProperty(PropertyName = "dnsZones")]
        public System.Collections.Generic.List<string> DnsZones { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type, or scope. Exists only for cross-compatibility.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Registry description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The Data Connectivity Management Registry display name; registries can be renamed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Compartment Identifier
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Time when the Data Connectivity Management registry was created. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Time when the Data Connectivity Management registry was updated. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
                ///
        /// <value>
        /// Lifecycle states for registries in the Data Connectivity Management Service.
        /// CREATING - The resource is being created and may not be usable until the entire metadata is defined.
        /// UPDATING - The resource is being updated and may not be usable until all changes are commited.
        /// DELETING - The resource is being deleted and might require deep cleanup of children.
        /// ACTIVE   - The resource is valid and available for access.
        /// INACTIVE - The resource might be incomplete in its definition or might have been made unavailable for
        ///          administrative reasons.
        /// DELETED  - The resource has been deleted and isn't available.
        /// FAILED   - The resource is in a failed state due to validation or other errors.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// Lifecycle states for registries in the Data Connectivity Management Service.
        /// CREATING - The resource is being created and may not be usable until the entire metadata is defined.
        /// UPDATING - The resource is being updated and may not be usable until all changes are commited.
        /// DELETING - The resource is being deleted and might require deep cleanup of children.
        /// ACTIVE   - The resource is valid and available for access.
        /// INACTIVE - The resource might be incomplete in its definition or might have been made unavailable for
        ///          administrative reasons.
        /// DELETED  - The resource has been deleted and isn't available.
        /// FAILED   - The resource is in a failed state due to validation or other errors.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "stateMessage")]
        public string StateMessage { get; set; }
        
        /// <value>
        /// A unique identifier that is immutable on creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Endpoint size for reverse connection capacity.
        /// </value>
        [JsonProperty(PropertyName = "endpointSize")]
        public System.Nullable<int> EndpointSize { get; set; }
        
        /// <value>
        /// The list of NSGs to which the private endpoint VNIC must be added.
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
    }
}
