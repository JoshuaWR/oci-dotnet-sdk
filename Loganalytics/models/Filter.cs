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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Query builder filter action to apply edit to queryString.
    /// 
    /// </summary>
    public class Filter 
    {
        
        /// <value>
        /// Field filter references when inserting filter into the query string. Field must be a valid logging analytics out-of-the-box field, virtual field calculated in the query or a user defined field.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fieldName")]
        public string FieldName { get; set; }
        
        /// <value>
        /// Field values that will be inserted into the query string for the specified fieldName. Please note all values should reflect the fields data type otherwise the insert is subject to fail.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "values")]
        public System.Collections.Generic.List<System.Object> Values { get; set; }
                ///
        /// <value>
        /// Operator to apply when editing the query string.
        /// 
        /// </value>
        ///
        public enum OperatorEnum {
            [EnumMember(Value = "CLEAR")]
            Clear,
            [EnumMember(Value = "REPLACE")]
            Replace,
            [EnumMember(Value = "EQUALS")]
            Equals,
            [EnumMember(Value = "NOT_EQUALS")]
            NotEquals,
            [EnumMember(Value = "STARTS_WITH")]
            StartsWith,
            [EnumMember(Value = "DOES_NOT_START_WITH")]
            DoesNotStartWith,
            [EnumMember(Value = "ENDS_WITH")]
            EndsWith,
            [EnumMember(Value = "DOES_NOT_END_WITH")]
            DoesNotEndWith,
            [EnumMember(Value = "CONTAINS")]
            Contains,
            [EnumMember(Value = "DOES_NOT_CONTAIN")]
            DoesNotContain,
            [EnumMember(Value = "IS_LESS_THAN")]
            IsLessThan,
            [EnumMember(Value = "IS_LESS_THAN_OR_EQUAL_TO")]
            IsLessThanOrEqualTo,
            [EnumMember(Value = "IS_GREATER_THAN")]
            IsGreaterThan,
            [EnumMember(Value = "IS_GREATER_THAN_OR_EQUAL_TO")]
            IsGreaterThanOrEqualTo,
            [EnumMember(Value = "IS_BETWEEN")]
            IsBetween,
            [EnumMember(Value = "IS_NOT_BETWEEN")]
            IsNotBetween,
            [EnumMember(Value = "ADD_SUBQUERY")]
            AddSubquery,
            [EnumMember(Value = "CLEAR_SUBQUERY")]
            ClearSubquery
        };

        /// <value>
        /// Operator to apply when editing the query string.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Operator is required.")]
        [JsonProperty(PropertyName = "operator")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperatorEnum> Operator { get; set; }
        
    }
}
