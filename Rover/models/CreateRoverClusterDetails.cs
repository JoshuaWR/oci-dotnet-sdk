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


namespace Oci.RoverService.Models
{
    /// <summary>
    /// The information required to create a RoverCluster.
    /// </summary>
    public class CreateRoverClusterDetails 
    {
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the RoverCluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Number of nodes desired in the cluster, in standalone clusters, between 5 and 15 inclusive. In station clusters, between 15 and 30 inclusive.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterSize is required.")]
        [JsonProperty(PropertyName = "clusterSize")]
        public System.Nullable<int> ClusterSize { get; set; }
        
        [JsonProperty(PropertyName = "customerShippingAddress")]
        public ShippingAddress CustomerShippingAddress { get; set; }
        
        /// <value>
        /// List of existing workloads that should be provisioned on the nodes.
        /// </value>
        [JsonProperty(PropertyName = "clusterWorkloads")]
        public System.Collections.Generic.List<RoverWorkload> ClusterWorkloads { get; set; }
        
        /// <value>
        /// Type of cluster.
        /// </value>
        [JsonProperty(PropertyName = "clusterType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ClusterType> ClusterType { get; set; }
        
        /// <value>
        /// Root password for the rover cluster.
        /// </value>
        [JsonProperty(PropertyName = "superUserPassword")]
        public string SuperUserPassword { get; set; }
        
        /// <value>
        /// The type of enclosure rover nodes in this cluster are shipped in.
        /// </value>
        [JsonProperty(PropertyName = "enclosureType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<EnclosureType> EnclosureType { get; set; }
        
        /// <value>
        /// Password to unlock the rover cluster.
        /// </value>
        [JsonProperty(PropertyName = "unlockPassphrase")]
        public string UnlockPassphrase { get; set; }
        
        /// <value>
        /// Name of point of contact for this order if customer is picking up.
        /// </value>
        [JsonProperty(PropertyName = "pointOfContact")]
        public string PointOfContact { get; set; }
        
        /// <value>
        /// Phone number of point of contact for this order if customer is picking up.
        /// </value>
        [JsonProperty(PropertyName = "pointOfContactPhoneNumber")]
        public string PointOfContactPhoneNumber { get; set; }
                ///
        /// <value>
        /// Preference for device delivery.
        /// </value>
        ///
        public enum ShippingPreferenceEnum {
            [EnumMember(Value = "ORACLE_SHIPPED")]
            OracleShipped,
            [EnumMember(Value = "CUSTOMER_PICKUP")]
            CustomerPickup
        };

        /// <value>
        /// Preference for device delivery.
        /// </value>
        [JsonProperty(PropertyName = "shippingPreference")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ShippingPreferenceEnum> ShippingPreference { get; set; }
        
        /// <value>
        /// Shipping vendor of choice for orace to customer shipping.
        /// </value>
        [JsonProperty(PropertyName = "shippingVendor")]
        public string ShippingVendor { get; set; }
        
        /// <value>
        /// Expected date when customer wants to pickup the cluster if they chose customer pickup.
        /// </value>
        [JsonProperty(PropertyName = "timePickupExpected")]
        public System.Nullable<System.DateTime> TimePickupExpected { get; set; }
        
        /// <value>
        /// Tracking Url for the shipped Rover Cluster.
        /// </value>
        [JsonProperty(PropertyName = "oracleShippingTrackingUrl")]
        public string OracleShippingTrackingUrl { get; set; }
        
        /// <value>
        /// ID provided to customer after successful subscription to Rover Stations.
        /// </value>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }
        
        /// <value>
        /// The current state of the RoverCluster.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A property that can contain details on the lifecycle.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleStateDetails")]
        public string LifecycleStateDetails { get; set; }
        
        /// <value>
        /// The flag indicating that customer requests data to be imported to OCI upon Rover cluster return.
        /// </value>
        [JsonProperty(PropertyName = "isImportRequested")]
        public System.Nullable<bool> IsImportRequested { get; set; }
        
        /// <value>
        /// An OCID of a compartment where data will be imported to upon Rover cluster return.
        /// </value>
        [JsonProperty(PropertyName = "importCompartmentId")]
        public string ImportCompartmentId { get; set; }
        
        /// <value>
        /// Name of a bucket where files from NFS share will be imported to upon Rover cluster return.
        /// </value>
        [JsonProperty(PropertyName = "importFileBucket")]
        public string ImportFileBucket { get; set; }
        
        /// <value>
        /// Validation code returned by data validation tool. Required for return shipping label generation if data import was requested.
        /// </value>
        [JsonProperty(PropertyName = "dataValidationCode")]
        public string DataValidationCode { get; set; }
        
        /// <value>
        /// Customer provided master key ID to encrypt secret information. If not provided, Rover's master key will be used for encryption.
        /// </value>
        [JsonProperty(PropertyName = "masterKeyId")]
        public string MasterKeyId { get; set; }
        
        /// <value>
        /// The freeform tags associated with this resource, if any. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The defined tags associated with this resource, if any. Each key is predefined and scoped to namespaces.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The system tags associated with this resource, if any. The system tags are set by Oracle cloud infrastructure services. Each key is predefined and scoped to namespaces.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {orcl-cloud: {free-tier-retain: true}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
