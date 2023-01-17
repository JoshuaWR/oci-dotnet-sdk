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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// When defined, the parent challenge would be applied only for the requests that matched all the listed conditions.
    /// </summary>
    public class AccessRuleCriteria 
    {
                ///
        /// <value>
        /// The criteria the access rule and JavaScript Challenge uses to determine if action should be taken on a request.
        /// - **URL_IS:** Matches if the concatenation of request URL path and query is identical to the contents of the `value` field. URL must start with a `/`.
        /// - **URL_IS_NOT:** Matches if the concatenation of request URL path and query is not identical to the contents of the `value` field. URL must start with a `/`.
        /// - **URL_STARTS_WITH:** Matches if the concatenation of request URL path and query starts with the contents of the `value` field. URL must start with a `/`.
        /// - **URL_PART_ENDS_WITH:** Matches if the concatenation of request URL path and query ends with the contents of the `value` field.
        /// - **URL_PART_CONTAINS:** Matches if the concatenation of request URL path and query contains the contents of the `value` field.
        /// - **URL_REGEX:** Matches if the concatenation of request URL path and query is described by the regular expression in the value field. The value must be a valid regular expression recognized by the PCRE library in Nginx (https://www.pcre.org).
        /// - **URL_DOES_NOT_MATCH_REGEX:** Matches if the concatenation of request URL path and query is not described by the regular expression in the `value` field. The value must be a valid regular expression recognized by the PCRE library in Nginx (https://www.pcre.org).
        /// - **URL_DOES_NOT_START_WITH:** Matches if the concatenation of request URL path and query does not start with the contents of the `value` field.
        /// - **URL_PART_DOES_NOT_CONTAIN:** Matches if the concatenation of request URL path and query does not contain the contents of the `value` field.
        /// - **URL_PART_DOES_NOT_END_WITH:** Matches if the concatenation of request URL path and query does not end with the contents of the `value` field.
        /// - **IP_IS:** Matches if the request originates from one of the IP addresses contained in the defined address list. The `value` in this case is string with one or multiple IPs or CIDR notations separated by new line symbol \
        /// <br/>
        /// *Example: * &quot;1.1.1.1\1.1.1.2\1.2.2.1/30&quot;- **IP_IS_NOT:** Matches if the request does not originate from any of the IP addresses contained in the defined address list. The value in this case is string with one or multiple IPs or CIDR notations separated by new line symbol \*
        /// </value>
        ///
        public enum ConditionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "URL_IS")]
            UrlIs,
            [EnumMember(Value = "URL_IS_NOT")]
            UrlIsNot,
            [EnumMember(Value = "URL_STARTS_WITH")]
            UrlStartsWith,
            [EnumMember(Value = "URL_PART_ENDS_WITH")]
            UrlPartEndsWith,
            [EnumMember(Value = "URL_PART_CONTAINS")]
            UrlPartContains,
            [EnumMember(Value = "URL_REGEX")]
            UrlRegex,
            [EnumMember(Value = "URL_DOES_NOT_MATCH_REGEX")]
            UrlDoesNotMatchRegex,
            [EnumMember(Value = "URL_DOES_NOT_START_WITH")]
            UrlDoesNotStartWith,
            [EnumMember(Value = "URL_PART_DOES_NOT_CONTAIN")]
            UrlPartDoesNotContain,
            [EnumMember(Value = "URL_PART_DOES_NOT_END_WITH")]
            UrlPartDoesNotEndWith,
            [EnumMember(Value = "IP_IS")]
            IpIs,
            [EnumMember(Value = "IP_IS_NOT")]
            IpIsNot,
            [EnumMember(Value = "IP_IN_LIST")]
            IpInList,
            [EnumMember(Value = "IP_NOT_IN_LIST")]
            IpNotInList,
            [EnumMember(Value = "HTTP_HEADER_CONTAINS")]
            HttpHeaderContains,
            [EnumMember(Value = "HTTP_METHOD_IS")]
            HttpMethodIs,
            [EnumMember(Value = "HTTP_METHOD_IS_NOT")]
            HttpMethodIsNot,
            [EnumMember(Value = "COUNTRY_IS")]
            CountryIs,
            [EnumMember(Value = "COUNTRY_IS_NOT")]
            CountryIsNot,
            [EnumMember(Value = "USER_AGENT_IS")]
            UserAgentIs,
            [EnumMember(Value = "USER_AGENT_IS_NOT")]
            UserAgentIsNot
        };

        /// <value>
        /// The criteria the access rule and JavaScript Challenge uses to determine if action should be taken on a request.
        /// - **URL_IS:** Matches if the concatenation of request URL path and query is identical to the contents of the `value` field. URL must start with a `/`.
        /// - **URL_IS_NOT:** Matches if the concatenation of request URL path and query is not identical to the contents of the `value` field. URL must start with a `/`.
        /// - **URL_STARTS_WITH:** Matches if the concatenation of request URL path and query starts with the contents of the `value` field. URL must start with a `/`.
        /// - **URL_PART_ENDS_WITH:** Matches if the concatenation of request URL path and query ends with the contents of the `value` field.
        /// - **URL_PART_CONTAINS:** Matches if the concatenation of request URL path and query contains the contents of the `value` field.
        /// - **URL_REGEX:** Matches if the concatenation of request URL path and query is described by the regular expression in the value field. The value must be a valid regular expression recognized by the PCRE library in Nginx (https://www.pcre.org).
        /// - **URL_DOES_NOT_MATCH_REGEX:** Matches if the concatenation of request URL path and query is not described by the regular expression in the `value` field. The value must be a valid regular expression recognized by the PCRE library in Nginx (https://www.pcre.org).
        /// - **URL_DOES_NOT_START_WITH:** Matches if the concatenation of request URL path and query does not start with the contents of the `value` field.
        /// - **URL_PART_DOES_NOT_CONTAIN:** Matches if the concatenation of request URL path and query does not contain the contents of the `value` field.
        /// - **URL_PART_DOES_NOT_END_WITH:** Matches if the concatenation of request URL path and query does not end with the contents of the `value` field.
        /// - **IP_IS:** Matches if the request originates from one of the IP addresses contained in the defined address list. The `value` in this case is string with one or multiple IPs or CIDR notations separated by new line symbol \
        /// <br/>
        /// *Example: * &quot;1.1.1.1\1.1.1.2\1.2.2.1/30&quot;- **IP_IS_NOT:** Matches if the request does not originate from any of the IP addresses contained in the defined address list. The value in this case is string with one or multiple IPs or CIDR notations separated by new line symbol \*
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Condition is required.")]
        [JsonProperty(PropertyName = "condition")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ConditionEnum> Condition { get; set; }
        
        /// <value>
        /// The criteria value.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// When enabled, the condition will be matched with case-sensitive rules.
        /// </value>
        [JsonProperty(PropertyName = "isCaseSensitive")]
        public System.Nullable<bool> IsCaseSensitive { get; set; }
        
    }
}
