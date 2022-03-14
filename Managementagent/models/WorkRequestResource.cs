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


namespace Oci.ManagementagentService.Models
{
    /// <summary>
    /// A resource created or operated on by a work request.
    /// </summary>
    public class WorkRequestResource 
    {
        
        /// <value>
        /// The resource type the work request affects.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityType is required.")]
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }
        
        /// <value>
        /// The way in which this resource is affected by the work tracked in the work request.
        /// A resource being created, updated, or deleted will remain in the IN_PROGRESS state until
        /// work is complete for that resource at which point it will transition to CREATED, UPDATED,
        /// or DELETED, respectively.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionType is required.")]
        [JsonProperty(PropertyName = "actionType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionTypes> ActionType { get; set; }
        
        /// <value>
        /// The identifier of the resource the work request affects.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Identifier is required.")]
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// The URI path that the user can do a GET on to access the resource metadata
        /// </value>
        [JsonProperty(PropertyName = "entityUri")]
        public string EntityUri { get; set; }
        
        /// <value>
        /// The date and time the request was created, as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339),
        /// section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
        
        /// <value>
        /// The date and time the request was started, as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339),
        /// section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time the request was finished, as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339),
        /// section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
        /// <value>
        /// Additional metadata about the resource that has been operated upon by
        /// this work request. For WorkRequests operationType WORK_DELIVERY the metadata will contain: workDeliveryStatus
        /// indicating the status of the work delivery item as a WorkDeliveryStatus value, workSubmissionKey the WorkSubmission request id,
        ///  and workSubmissionDetails containing any details of result
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Object Metadata { get; set; }
        
    }
}
