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


namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// Subscription information for compartmentId. Only root compartments are allowed.
    /// </summary>
    public class Subscription 
    {
        
        /// <value>
        /// OCID of the subscription details for particular root compartment or tenancy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Subscription id.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClassicSubscriptionId is required.")]
        [JsonProperty(PropertyName = "classicSubscriptionId")]
        public string ClassicSubscriptionId { get; set; }
        
        /// <value>
        /// The type of subscription, such as 'CLOUDCM'/'SAAS'/'CRM', etc.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceName is required.")]
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }
        
        /// <value>
        /// Stock keeping unit.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Skus is required.")]
        [JsonProperty(PropertyName = "skus")]
        public System.Collections.Generic.List<SubscriptionSku> Skus { get; set; }
        
    }
}
