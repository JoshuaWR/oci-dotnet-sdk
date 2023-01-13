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
    /// Information about an instance that belongs to an instance pool.
    /// </summary>
    public class InstancePoolInstance 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the instance pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstancePoolId is required.")]
        [JsonProperty(PropertyName = "instancePoolId")]
        public string InstancePoolId { get; set; }
        
        /// <value>
        /// The availability domain the instance is running in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
                ///
        /// <value>
        /// The attachment state of the instance in relation to the instance pool.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ATTACHING")]
            Attaching,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DETACHING")]
            Detaching
        };

        /// <value>
        /// The attachment state of the instance in relation to the instance pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment that contains the
        /// instance.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The fault domain the instance is running in.
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the instance configuration
        /// used to create the instance.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceConfigurationId is required.")]
        [JsonProperty(PropertyName = "instanceConfigurationId")]
        public string InstanceConfigurationId { get; set; }
        
        /// <value>
        /// The region that contains the availability domain the instance is running in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Region is required.")]
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <value>
        /// The shape of the instance. The shape determines the number of CPUs, amount of memory,
        /// and other resources allocated to the instance.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The lifecycle state of the instance. Refer to `lifecycleState` in the {@link Instance} resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "State is required.")]
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
        
        /// <value>
        /// The date and time the instance pool instance was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The load balancer backends that are configured for the instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "loadBalancerBackends")]
        public System.Collections.Generic.List<InstancePoolInstanceLoadBalancerBackend> LoadBalancerBackends { get; set; }
        
    }
}
