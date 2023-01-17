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


namespace Oci.MediaservicesService.Models
{
    /// <summary>
    /// A MediaWorkflowJob represents a run of a MediaWorkflow for a specific set of parameters and configurations.
    /// 
    /// </summary>
    public class MediaWorkflowJob 
    {
        
        /// <value>
        /// Configurations to be applied to this run of the workflow.
        /// </value>
        [JsonProperty(PropertyName = "mediaWorkflowConfigurationIds")]
        public System.Collections.Generic.List<string> MediaWorkflowConfigurationIds { get; set; }
        
        /// <value>
        /// The workflow to execute.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MediaWorkflowId is required.")]
        [JsonProperty(PropertyName = "mediaWorkflowId")]
        public string MediaWorkflowId { get; set; }
        
        /// <value>
        /// Unique identifier for this run of the workflow.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Compartment Identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Name of the Media Workflow Job. Does not have to be unique. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The current state of the MediaWorkflowJob.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "WAITING")]
            Waiting,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "CANCELING")]
            Canceling,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// The current state of the MediaWorkflowJob.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The lifecyle details.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// Status of each task.
        /// </value>
        [JsonProperty(PropertyName = "taskLifecycleState")]
        public System.Collections.Generic.List<MediaWorkflowTaskState> TaskLifecycleState { get; set; }
        
        /// <value>
        /// Parameters that override parameters specified in MediaWorkflowTaskDeclarations, the MediaWorkflow,
        /// the MediaWorkflow's MediaWorkflowConfigurations and the MediaWorkflowConfigurations of this
        /// MediaWorkflowJob. The parameters are given as JSON.  The top level and 2nd level elements must be
        /// JSON objects (vs arrays, scalars, etc). The top level keys refer to a task's key and the 2nd level
        /// keys refer to a parameter's name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.Dictionary<string, System.Object> Parameters { get; set; }
        
        /// <value>
        /// Creation time of the job. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Updated time of the job. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// A JSON representation of the job as it will be run by the system. All the task declarations, configurations
        /// and parameters are merged. Parameter values are all fully resolved.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "runnable")]
        public System.Collections.Generic.Dictionary<string, System.Object> Runnable { get; set; }
        
        /// <value>
        /// A list of JobOutput for the workflowJob.
        /// </value>
        [JsonProperty(PropertyName = "outputs")]
        public System.Collections.Generic.List<JobOutput> Outputs { get; set; }
        
        /// <value>
        /// Time when the job started to execute. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// Time when the job finished. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
