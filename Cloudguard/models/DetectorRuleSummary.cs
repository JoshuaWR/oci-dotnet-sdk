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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Summary of the Detector Rules.
    /// </summary>
    public class DetectorRuleSummary 
    {
        
        /// <value>
        /// The unique identifier of the detector rule
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// DetectorTemplate Identifier, can be renamed
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description for detector rule
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Recommendation for detector rule
        /// </value>
        [JsonProperty(PropertyName = "recommendation")]
        public string Recommendation { get; set; }
        
        /// <value>
        /// possible type of detectors
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Detector is required.")]
        [JsonProperty(PropertyName = "detector")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DetectorEnum> Detector { get; set; }
        
        /// <value>
        /// service type of the configuration to which the rule is applied
        /// </value>
        [JsonProperty(PropertyName = "serviceType")]
        public string ServiceType { get; set; }
        
        /// <value>
        /// resource type of the configuration to which the rule is applied
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
                ///
        ///
        public enum ManagedListTypesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CIDR_BLOCK")]
            CidrBlock,
            [EnumMember(Value = "USERS")]
            Users,
            [EnumMember(Value = "GROUPS")]
            Groups,
            [EnumMember(Value = "IPV4ADDRESS")]
            Ipv4Address,
            [EnumMember(Value = "IPV6ADDRESS")]
            Ipv6Address,
            [EnumMember(Value = "RESOURCE_OCID")]
            ResourceOcid,
            [EnumMember(Value = "REGION")]
            Region,
            [EnumMember(Value = "COUNTRY")]
            Country,
            [EnumMember(Value = "STATE")]
            State,
            [EnumMember(Value = "CITY")]
            City,
            [EnumMember(Value = "TAGS")]
            Tags,
            [EnumMember(Value = "GENERIC")]
            Generic
        };

        /// <value>
        /// List of cloudguard managed list types related to this rule
        /// </value>
        [JsonProperty(PropertyName = "managedListTypes", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<ManagedListTypesEnum> ManagedListTypes { get; set; }
        
        /// <value>
        /// List of CandidateResponderRule related to this rule
        /// </value>
        [JsonProperty(PropertyName = "candidateResponderRules")]
        public System.Collections.Generic.List<CandidateResponderRule> CandidateResponderRules { get; set; }
        
        [JsonProperty(PropertyName = "detectorDetails")]
        public DetectorDetails DetectorDetails { get; set; }
        
        /// <value>
        /// The date and time the detector rule was created. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the detector rule was updated. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the detector rule
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
    }
}
