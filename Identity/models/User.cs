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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// An individual employee or system that needs to manage or use your company's Oracle Cloud Infrastructure
    /// resources. Users might need to launch instances, manage remote disks, work with your cloud network, etc. Users
    /// have one or more IAM Service credentials ({@link ApiKey},
    /// {@link UIPassword}, {@link SwiftPassword} and
    /// {@link AuthToken}).
    /// For more information, see [User Credentials](https://docs.cloud.oracle.com/Content/Identity/Concepts/usercredentials.htm)). End users of your
    /// application are not typically IAM Service users. For conceptual information about users and other IAM Service
    /// components, see [Overview of the IAM Service](https://docs.cloud.oracle.com/Content/Identity/Concepts/overview.htm).
    /// <br/>
    /// These users are created directly within the Oracle Cloud Infrastructure system, via the IAM service.
    /// They are different from *federated users*, who authenticate themselves to the Oracle Cloud Infrastructure
    /// Console via an identity provider. For more information, see
    /// [Identity Providers and Federation](https://docs.cloud.oracle.com/Content/Identity/Concepts/federation.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access,
    /// see [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values
    /// using the API.
    /// 
    /// </summary>
    public class User 
    {
        
        /// <value>
        /// The OCID of the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <value>
        /// The OCID of the tenancy containing the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The name you assign to the user during creation. This is the user's login for the Console.
        /// The name must be unique across all users in the tenancy and cannot be changed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// The description you assign to the user. Does not have to be unique, and it's changeable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// The email address you assign to the user.
        /// The email address must be unique across all users in the tenancy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <value>
        /// Whether the email address has been validated.
        /// </value>
        [JsonProperty(PropertyName = "emailVerified")]
        public System.Nullable<bool> EmailVerified { get; set; }

        /// <value>
        /// The OCID of the `IdentityProvider` this user belongs to.
        /// </value>
        [JsonProperty(PropertyName = "identityProviderId")]
        public string IdentityProviderId { get; set; }

        /// <value>
        /// Identifier of the user in the identity provider
        /// </value>
        [JsonProperty(PropertyName = "externalIdentifier")]
        public string ExternalIdentifier { get; set; }

        /// <value>
        /// Date and time the user was created, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        ///
        /// <value>
        /// The user's current state. After creating a user, make sure its `lifecycleState` changes from CREATING to
        /// ACTIVE before using it.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The user's current state. After creating a user, make sure its `lifecycleState` changes from CREATING to
        /// ACTIVE before using it.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }

        /// <value>
        /// Returned only if the user's `lifecycleState` is INACTIVE. A 16-bit value showing the reason why the user
        /// is inactive:
        /// <br/>
        /// - bit 0: SUSPENDED (reserved for future use)
        /// - bit 1: DISABLED (reserved for future use)
        /// - bit 2: BLOCKED (the user has exceeded the maximum number of failed login attempts for the Console)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "inactiveStatus")]
        public System.Nullable<long> InactiveStatus { get; set; }

        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }

        [JsonProperty(PropertyName = "capabilities")]
        public UserCapabilities Capabilities { get; set; }

        /// <value>
        /// Flag indicates if MFA has been activated for the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsMfaActivated is required.")]
        [JsonProperty(PropertyName = "isMfaActivated")]
        public System.Nullable<bool> IsMfaActivated { get; set; }
    }
}
