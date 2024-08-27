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


namespace Oci.DelegateaccesscontrolService.Models
{
    /// <summary>
    /// Information about the new Delegation Control.
    /// </summary>
    public class UpdateDelegationControlDetails 
    {
        
        /// <value>
        /// Name of the Delegation Control. The name does not need to be unique.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the Delegation Control.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// number of approvals required.
        /// </value>
        [JsonProperty(PropertyName = "numApprovalsRequired")]
        public System.Nullable<int> NumApprovalsRequired { get; set; }
        
        /// <value>
        /// List of Delegation Subscription OCID that are allowed for this Delegation Control. The allowed subscriptions will determine the available Service Provider Actions. Only support operators for the allowed subscriptions are allowed to create Delegated Resource Access Request.
        /// </value>
        [JsonProperty(PropertyName = "delegationSubscriptionIds")]
        public System.Collections.Generic.List<string> DelegationSubscriptionIds { get; set; }
        
        /// <value>
        /// Set to true to allow all Delegated Resource Access Request to be approved automatically during maintenance.
        /// </value>
        [JsonProperty(PropertyName = "isAutoApproveDuringMaintenance")]
        public System.Nullable<bool> IsAutoApproveDuringMaintenance { get; set; }
        
        /// <value>
        /// The OCID of the selected resources that this Delegation Control is applicable to.
        /// </value>
        [JsonProperty(PropertyName = "resourceIds")]
        public System.Collections.Generic.List<string> ResourceIds { get; set; }
        
        /// <value>
        /// List of pre-approved Service Provider Action names. The list of pre-defined Service Provider Actions can be obtained from the ListServiceProviderActions API. Delegated Resource Access Requests associated with a resource governed by this Delegation Control will be
        /// automatically approved if the Delegated Resource Access Request only contain Service Provider Actions in the pre-approved list.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "preApprovedServiceProviderActionNames")]
        public System.Collections.Generic.List<string> PreApprovedServiceProviderActionNames { get; set; }
        
        /// <value>
        /// The OCID of the OCI Notification topic to publish messages related to this Delegation Control.
        /// </value>
        [JsonProperty(PropertyName = "notificationTopicId")]
        public string NotificationTopicId { get; set; }
        
        /// <value>
        /// The format of the OCI Notification messages for this Delegation Control.
        /// </value>
        [JsonProperty(PropertyName = "notificationMessageFormat")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DelegationControl.NotificationMessageFormatEnum> NotificationMessageFormat { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
