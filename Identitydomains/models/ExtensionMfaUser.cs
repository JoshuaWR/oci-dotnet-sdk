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


namespace Oci.IdentitydomainsService.Models
{
    /// <summary>
    /// This extension defines attributes used to manage Multi-Factor Authentication within a service provider. The extension is typically applied to a User resource, but MAY be applied to other resources that use MFA.
    /// </summary>
    public class ExtensionMfaUser 
    {
                ///
        /// <value>
        /// Preferred Authentication Factor Type
        /// <br/>
        /// **Added In:** 18.3.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum PreferredAuthenticationFactorEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EMAIL")]
            Email,
            [EnumMember(Value = "SMS")]
            Sms,
            [EnumMember(Value = "TOTP")]
            Totp,
            [EnumMember(Value = "PUSH")]
            Push,
            [EnumMember(Value = "OFFLINETOTP")]
            Offlinetotp,
            [EnumMember(Value = "USERNAME_PASSWORD")]
            UsernamePassword,
            [EnumMember(Value = "SECURITY_QUESTIONS")]
            SecurityQuestions,
            [EnumMember(Value = "VOICE")]
            Voice,
            [EnumMember(Value = "PHONE_CALL")]
            PhoneCall,
            [EnumMember(Value = "THIRDPARTY")]
            Thirdparty,
            [EnumMember(Value = "FIDO_AUTHENTICATOR")]
            FidoAuthenticator,
            [EnumMember(Value = "YUBICO_OTP")]
            YubicoOtp
        };

        /// <value>
        /// Preferred Authentication Factor Type
        /// <br/>
        /// **Added In:** 18.3.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "preferredAuthenticationFactor")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PreferredAuthenticationFactorEnum> PreferredAuthenticationFactor { get; set; }
                ///
        /// <value>
        /// User Opted for MFA
        /// <br/>
        /// **Added In:** 18.3.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum MfaStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ENROLLED")]
            Enrolled,
            [EnumMember(Value = "IGNORED")]
            Ignored,
            [EnumMember(Value = "UN_ENROLLED")]
            UnEnrolled,
            [EnumMember(Value = "DISABLED")]
            Disabled
        };

        /// <value>
        /// User Opted for MFA
        /// <br/>
        /// **Added In:** 18.3.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "mfaStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MfaStatusEnum> MfaStatus { get; set; }
        
        /// <value>
        /// Preferred Third party vendor name
        /// <br/>
        /// **Added In:** 19.2.1
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "preferredThirdPartyVendor")]
        public string PreferredThirdPartyVendor { get; set; }
        
        /// <value>
        /// Preferred Authentication method
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "preferredAuthenticationMethod")]
        public string PreferredAuthenticationMethod { get; set; }
        
        /// <value>
        /// Number of incorrect Multi Factor Authentication login attempts made by this user. The user gets locked, if this reaches the threshold specified in the maxIncorrectAttempts attribute in AuthenticationFactorSettings
        /// <br/>
        /// **Added In:** 18.3.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "loginAttempts")]
        public System.Nullable<int> LoginAttempts { get; set; }
        
        /// <value>
        /// This represents the date when the user enrolled for multi factor authentication. This will be set to null, when the user resets his factors.
        /// <br/>
        /// **Added In:** 18.3.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: request
        ///  - type: dateTime
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "mfaEnabledOn")]
        public string MfaEnabledOn { get; set; }
        
        /// <value>
        /// User MFA Ignored Apps Identifiers
        /// <br/>
        /// **Added In:** 19.2.1
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "mfaIgnoredApps")]
        public System.Collections.Generic.List<string> MfaIgnoredApps { get; set; }
        
        [JsonProperty(PropertyName = "preferredDevice")]
        public UserExtPreferredDevice PreferredDevice { get; set; }
        
        /// <value>
        /// A list of devices enrolled by the user.
        /// <br/>
        /// **Added In:** 18.3.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value]
        ///  - multiValued: true
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "devices")]
        public System.Collections.Generic.List<UserExtDevices> Devices { get; set; }
        
        /// <value>
        /// A list of bypass codes belongs to user
        /// <br/>
        /// **Added In:** 18.3.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value]
        ///  - multiValued: true
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "bypassCodes")]
        public System.Collections.Generic.List<UserExtBypassCodes> BypassCodes { get; set; }
        
        /// <value>
        /// A list of trusted User Agents owned by this user. Multi-Factored Authentication uses Trusted User Agents to authenticate users.  A User Agent is software application that a user uses to issue requests. For example, a User Agent could be a particular browser (possibly one of several executing on a desktop or laptop) or a particular mobile application (again, oneof several executing on a particular mobile device). A User Agent is trusted once the Multi-Factor Authentication has verified it in some way.
        /// <br/>
        /// **Added In:** 18.3.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value]
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: request
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "trustedUserAgents")]
        public System.Collections.Generic.List<UserExtTrustedUserAgents> TrustedUserAgents { get; set; }
        
    }
}