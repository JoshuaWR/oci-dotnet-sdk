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
    /// This extension defines attributes specific to Apps that represent instances of an Oracle Public Cloud (OPC) service.
    /// </summary>
    public class AppExtensionOpcServiceApp 
    {
        
        /// <value>
        /// This value specifies the unique identifier assigned to an instance of an Oracle Public Cloud service app.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: server
        /// </value>
        [JsonProperty(PropertyName = "serviceInstanceIdentifier")]
        public string ServiceInstanceIdentifier { get; set; }
        
        /// <value>
        /// This value identifies the OPC region in which the service is running.
        /// <br/>
        /// **Added In:** 19.1.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
                ///
        /// <value>
        /// Current Federation Mode
        /// <br/>
        /// **Added In:** 18.2.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        /// </value>
        ///
        public enum CurrentFederationModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "None")]
            None,
            [EnumMember(Value = "AppAsServiceProvider")]
            AppAsServiceProvider,
            [EnumMember(Value = "AppAsIdentityProvider")]
            AppAsIdentityProvider
        };

        /// <value>
        /// Current Federation Mode
        /// <br/>
        /// **Added In:** 18.2.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "currentFederationMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CurrentFederationModeEnum> CurrentFederationMode { get; set; }
                ///
        /// <value>
        /// Current Synchronization Mode
        /// <br/>
        /// **Added In:** 18.2.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        /// </value>
        ///
        public enum CurrentSynchronizationModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "None")]
            None,
            [EnumMember(Value = "AppAsTarget")]
            AppAsTarget,
            [EnumMember(Value = "AppAsSource")]
            AppAsSource
        };

        /// <value>
        /// Current Synchronization Mode
        /// <br/>
        /// **Added In:** 18.2.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "currentSynchronizationMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CurrentSynchronizationModeEnum> CurrentSynchronizationMode { get; set; }
                ///
        /// <value>
        /// Next Federation Mode
        /// <br/>
        /// **Added In:** 18.2.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        /// </value>
        ///
        public enum NextFederationModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "None")]
            None,
            [EnumMember(Value = "AppAsServiceProvider")]
            AppAsServiceProvider,
            [EnumMember(Value = "AppAsIdentityProvider")]
            AppAsIdentityProvider
        };

        /// <value>
        /// Next Federation Mode
        /// <br/>
        /// **Added In:** 18.2.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "nextFederationMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NextFederationModeEnum> NextFederationMode { get; set; }
                ///
        /// <value>
        /// Next Synchronization Mode
        /// <br/>
        /// **Added In:** 18.2.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        /// </value>
        ///
        public enum NextSynchronizationModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "None")]
            None,
            [EnumMember(Value = "AppAsTarget")]
            AppAsTarget,
            [EnumMember(Value = "AppAsSource")]
            AppAsSource
        };

        /// <value>
        /// Next Synchronization Mode
        /// <br/>
        /// **Added In:** 18.2.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "nextSynchronizationMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NextSynchronizationModeEnum> NextSynchronizationMode { get; set; }
        
        /// <value>
        /// If true, indicates that enablement is in progress started but not completed
        /// <br/>
        /// **Added In:** 18.2.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: boolean
        /// </value>
        [JsonProperty(PropertyName = "enablingNextFedSyncModes")]
        public System.Nullable<bool> EnablingNextFedSyncModes { get; set; }
        
    }
}