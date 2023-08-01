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


namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Exadata Fleet Update Cycle Summary.
    /// 
    /// </summary>
    public class FsuCycleSummary 
    {
        
        /// <value>
        /// OCID identifier for the Exadata Fleet Update Cycle.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Exadata Fleet Update Cycle display name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Compartment Identifier.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Type of Exadata Fleet Update Cycle.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CycleTypes> Type { get; set; }
        
        /// <value>
        /// OCID identifier for the Collection ID the Exadata Fleet Update Cycle is assigned to.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FsuCollectionId is required.")]
        [JsonProperty(PropertyName = "fsuCollectionId")]
        public string FsuCollectionId { get; set; }
        
        /// <value>
        /// Type of Collection this Exadata Fleet Update Cycle belongs to.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CollectionType is required.")]
        [JsonProperty(PropertyName = "collectionType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CollectionTypes> CollectionType { get; set; }
        
        /// <value>
        /// OCID identifier for the Action that is currently in execution, if applicable.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "executingFsuActionId")]
        public string ExecutingFsuActionId { get; set; }
        
        /// <value>
        /// In this array all the possible actions will be listed. The first element is the suggested Action.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nextActionToExecute")]
        public System.Collections.Generic.List<NextActionToExecuteDetails> NextActionToExecute { get; set; }
        
        /// <value>
        /// The latest Action type that was completed in the Exadata Fleet Update Cycle.
        /// No value would indicate that the Cycle has not completed any Action yet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lastCompletedAction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DetailedActionTypes> LastCompletedAction { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GoalVersionDetails is required.")]
        [JsonProperty(PropertyName = "goalVersionDetails")]
        public FsuGoalVersionDetails GoalVersionDetails { get; set; }
        
        /// <value>
        /// The date and time the Exadata Fleet Update Cycle was created, as described in
        /// [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the Exadata Fleet Update Cycle was updated,
        /// as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339),
        /// section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The date and time the Exadata Fleet Update Cycle was finished,
        /// as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
        /// <value>
        /// The current state of the Exadata Fleet Update Cycle.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CycleLifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail.
        /// For example, can be used to provide actionable information for a resource in Failed state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
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