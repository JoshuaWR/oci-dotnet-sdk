/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ComputeinstanceagentService.Models
{
    /// <summary>
    /// The command payload.
    /// </summary>
    public class InstanceAgentCommand 
    {
        
        /// <value>
        /// The command OCID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment the command is created in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The user friendly display name of the command.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// the time command was created at.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// the time command was updated at.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Whether the command has been requested to be canceled.
        /// </value>
        [JsonProperty(PropertyName = "isCanceled")]
        public System.Nullable<bool> IsCanceled { get; set; }
        
        /// <value>
        /// Command execution time limit that the instance agent will honor when executing the command inside the instance. This timer starts when the instance agent starts the commond. Zero means no timeout.
        /// </value>
        [JsonProperty(PropertyName = "executionTimeOutInSeconds")]
        public System.Nullable<int> ExecutionTimeOutInSeconds { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Target is required.")]
        [JsonProperty(PropertyName = "target")]
        public InstanceAgentCommandTarget Target { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Content is required.")]
        [JsonProperty(PropertyName = "content")]
        public InstanceAgentCommandContent Content { get; set; }
        
    }
}