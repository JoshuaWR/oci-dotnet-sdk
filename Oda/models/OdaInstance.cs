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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// Description of `OdaServiceInstance` object.
    /// </summary>
    public class OdaInstance 
    {
        
        /// <value>
        /// Unique immutable identifier that was assigned when the instance was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// User-defined name for the Digital Assistant instance. Avoid entering confidential information.
        /// You can change this value.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the Digital Assistant instance.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Identifier of the compartment that the instance belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// Shape or size of the instance.
        /// </value>
        ///
        public enum ShapeNameEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DEVELOPMENT")]
            Development,
            [EnumMember(Value = "PRODUCTION")]
            Production
        };

        /// <value>
        /// Shape or size of the instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeName is required.")]
        [JsonProperty(PropertyName = "shapeName")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ShapeNameEnum> ShapeName { get; set; }
        
        /// <value>
        /// URL for the Digital Assistant web application that's associated with the instance.
        /// </value>
        [JsonProperty(PropertyName = "webAppUrl")]
        public string WebAppUrl { get; set; }
        
        /// <value>
        /// URL for the connector's endpoint.
        /// </value>
        [JsonProperty(PropertyName = "connectorUrl")]
        public string ConnectorUrl { get; set; }
        
        /// <value>
        /// When the Digital Assistant instance was created. A date-time string as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// When the Digital Assistance instance was last updated. A date-time string as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
                ///
        /// <value>
        /// The current state of the Digital Assistant instance.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the Digital Assistant instance.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
                ///
        /// <value>
        /// The current sub-state of the Digital Assistant instance.
        /// </value>
        ///
        public enum LifecycleSubStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "STARTING")]
            Starting,
            [EnumMember(Value = "STOPPING")]
            Stopping,
            [EnumMember(Value = "CHANGING_COMPARTMENT")]
            ChangingCompartment,
            [EnumMember(Value = "ACTIVATING_CUSTOMER_ENCRYPTION_KEY")]
            ActivatingCustomerEncryptionKey,
            [EnumMember(Value = "UPDATING_CUSTOMER_ENCRYPTION_KEY")]
            UpdatingCustomerEncryptionKey,
            [EnumMember(Value = "DEACTIVATING_CUSTOMER_ENCRYPTION_KEY")]
            DeactivatingCustomerEncryptionKey,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETE_PENDING")]
            DeletePending,
            [EnumMember(Value = "RECOVERING")]
            Recovering,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "PURGING")]
            Purging,
            [EnumMember(Value = "QUEUED")]
            Queued
        };

        /// <value>
        /// The current sub-state of the Digital Assistant instance.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleSubState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleSubStateEnum> LifecycleSubState { get; set; }
        
        /// <value>
        /// A message that describes the current state in more detail.
        /// For example, actionable information about an instance that's in the `FAILED` state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "stateMessage")]
        public string StateMessage { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type, or scope.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Should this Digital Assistant instance use role-based authorization via an identity domain (true) or use the default policy-based authorization via IAM policies (false)
        /// </value>
        [JsonProperty(PropertyName = "isRoleBasedAccess")]
        public System.Nullable<bool> IsRoleBasedAccess { get; set; }
        
        /// <value>
        /// If isRoleBasedAccess is set to true, this property specifies the identity domain that is to be used to implement this type of authorzation. Digital Assistant will create an Identity Application instance and Application Roles within this identity domain. The caller may then perform and user roll mappings they like to grant access to users within the identity domain.
        /// </value>
        [JsonProperty(PropertyName = "identityDomain")]
        public string IdentityDomain { get; set; }
        
        /// <value>
        /// If isRoleBasedAccess is set to true, this property specifies the GUID of the Identity Application instance Digital Assistant has created inside the user-specified identity domain. This identity application instance may be used to host user roll mappings to grant access to this Digital Assistant instance for users within the identity domain.
        /// </value>
        [JsonProperty(PropertyName = "identityAppGuid")]
        public string IdentityAppGuid { get; set; }
        
        /// <value>
        /// If isRoleBasedAccess is set to true, this property specifies the URL for the administration console used to manage the Identity Application instance Digital Assistant has created inside the user-specified identity domain.
        /// </value>
        [JsonProperty(PropertyName = "identityAppConsoleUrl")]
        public string IdentityAppConsoleUrl { get; set; }
        
        /// <value>
        /// A list of package names imported into this instance (if any). Use importedPackageIds field to get the details of the imported packages.
        /// </value>
        [JsonProperty(PropertyName = "importedPackageNames")]
        public System.Collections.Generic.List<string> ImportedPackageNames { get; set; }
        
        /// <value>
        /// A list of package ids imported into this instance (if any). Use GetImportedPackage to get the details of the imported packages.
        /// </value>
        [JsonProperty(PropertyName = "importedPackageIds")]
        public System.Collections.Generic.List<string> ImportedPackageIds { get; set; }
        
        /// <value>
        /// A list of attachment types for this instance (if any). Use attachmentIds to get the details of the attachments.
        /// </value>
        [JsonProperty(PropertyName = "attachmentTypes")]
        public System.Collections.Generic.List<string> AttachmentTypes { get; set; }
        
        /// <value>
        /// A list of attachment identifiers for this instance (if any). Use GetOdaInstanceAttachment to get the details of the attachments.
        /// </value>
        [JsonProperty(PropertyName = "attachmentIds")]
        public System.Collections.Generic.List<string> AttachmentIds { get; set; }
        
        /// <value>
        /// A list of restricted operations (across all attachments) for this instance (if any). Use GetOdaInstanceAttachment to get the details of the attachments.
        /// </value>
        [JsonProperty(PropertyName = "restrictedOperations")]
        public System.Collections.Generic.List<RestrictedOperation> RestrictedOperations { get; set; }
        
    }
}
