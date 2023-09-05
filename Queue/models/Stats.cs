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


namespace Oci.QueueService.Models
{
    /// <summary>
    /// The stats for a queue or a dead letter queue.
    /// </summary>
    public class Stats 
    {
        
        /// <value>
        /// The approximate number of visible messages (available for delivery) currently in the queue.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VisibleMessages is required.")]
        [JsonProperty(PropertyName = "visibleMessages")]
        public System.Nullable<long> VisibleMessages { get; set; }
        
        /// <value>
        /// The approximate number of messages delivered to a consumer but not yet deleted and so unavailable for re-delivery.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InFlightMessages is required.")]
        [JsonProperty(PropertyName = "inFlightMessages")]
        public System.Nullable<long> InFlightMessages { get; set; }
        
        /// <value>
        /// The approximate size of the queue in bytes. Sum of the size of visible and in-flight messages.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SizeInBytes is required.")]
        [JsonProperty(PropertyName = "sizeInBytes")]
        public System.Nullable<long> SizeInBytes { get; set; }
        
    }
}
