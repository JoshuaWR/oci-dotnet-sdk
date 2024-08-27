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


namespace Oci.KeymanagementService.Models
{
    /// <summary>
    /// An object which encapsulates the details of a given HSM.
    /// </summary>
    public class HsmPartitionSummary 
    {
        
        /// <value>
        /// The OCID of the HSM resource. Each HSM resource will have a unique OCID identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the HSMCluster that contains a particular HSM resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HsmClusterId is required.")]
        [JsonProperty(PropertyName = "hsmClusterId")]
        public string HsmClusterId { get; set; }
        
        /// <value>
        /// A HSMCluster resource's current lifecycle state.
        /// <br/>
        /// Example: ACTIVE
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<HsmPartition.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains a particular HSM resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Details of a single portInformation item include the PortNumber (an integer used as an identifier) and the PortType (refers to either an enum value of Managementutility,Clientutility, or null)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PortInformation is required.")]
        [JsonProperty(PropertyName = "portInformation")]
        public System.Collections.Generic.List<PortInformation> PortInformation { get; set; }
        
        /// <value>
        /// The date and time an HSM was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// <br/>
        /// Example: 2018-04-03T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time an HSM was updated, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// <br/>
        /// Example: 2018-04-03T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
    }
}
