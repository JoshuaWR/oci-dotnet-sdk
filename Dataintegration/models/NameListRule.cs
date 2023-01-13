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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The name list rule which defines how fields are projected. For example, this may be all fields begining with STR.
    /// </summary>
    public class NameListRule : ProjectionRule
    {
        
        /// <value>
        /// Specifies whether to skip remaining rules when a match is found.
        /// </value>
        [JsonProperty(PropertyName = "isSkipRemainingRulesOnMatch")]
        public System.Nullable<bool> IsSkipRemainingRulesOnMatch { get; set; }
        
        /// <value>
        /// Reference to a typed object. This can be either a key value to an object within the document, a shall referenced to a `TypedObject`, or a full `TypedObject` definition.
        /// </value>
        [JsonProperty(PropertyName = "scope")]
        public System.Object Scope { get; set; }
        
        /// <value>
        /// Specifies whether to cascade or not.
        /// </value>
        [JsonProperty(PropertyName = "isCascade")]
        public System.Nullable<bool> IsCascade { get; set; }
                ///
        /// <value>
        /// The pattern matching strategy.
        /// </value>
        ///
        public enum MatchingStrategyEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NAME_OR_TAGS")]
            NameOrTags,
            [EnumMember(Value = "TAGS_ONLY")]
            TagsOnly,
            [EnumMember(Value = "NAME_ONLY")]
            NameOnly
        };

        /// <value>
        /// The pattern matching strategy.
        /// </value>
        [JsonProperty(PropertyName = "matchingStrategy")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MatchingStrategyEnum> MatchingStrategy { get; set; }
        
        /// <value>
        /// Specifies if the rule is case sensitive.
        /// </value>
        [JsonProperty(PropertyName = "isCaseSensitive")]
        public System.Nullable<bool> IsCaseSensitive { get; set; }
                ///
        /// <value>
        /// The rule type.
        /// </value>
        ///
        public enum RuleTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "INCLUDE")]
            Include,
            [EnumMember(Value = "EXCLUDE")]
            Exclude
        };

        /// <value>
        /// The rule type.
        /// </value>
        [JsonProperty(PropertyName = "ruleType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RuleTypeEnum> RuleType { get; set; }
        
        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
        /// </value>
        [JsonProperty(PropertyName = "names")]
        public System.Collections.Generic.List<string> Names { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "NAME_LIST_RULE";
    }
}
