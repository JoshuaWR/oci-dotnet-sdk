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


namespace Oci.ResourcesearchService.Models
{
    /// <summary>
    /// An individual field that can be used as part of a query filter.
    /// </summary>
    public class QueryableFieldDescription 
    {
                ///
        /// <value>
        /// The type of the field, which dictates what semantics and query constraints you can use when searching or querying.
        /// 
        /// </value>
        ///
        public enum FieldTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "IDENTIFIER")]
            Identifier,
            [EnumMember(Value = "STRING")]
            String,
            [EnumMember(Value = "INTEGER")]
            Integer,
            [EnumMember(Value = "RATIONAL")]
            Rational,
            [EnumMember(Value = "BOOLEAN")]
            Boolean,
            [EnumMember(Value = "DATETIME")]
            Datetime,
            [EnumMember(Value = "IP")]
            Ip,
            [EnumMember(Value = "OBJECT")]
            Object
        };

        /// <value>
        /// The type of the field, which dictates what semantics and query constraints you can use when searching or querying.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FieldType is required.")]
        [JsonProperty(PropertyName = "fieldType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<FieldTypeEnum> FieldType { get; set; }
        
        /// <value>
        /// The name of the field to use when constructing the query. Field names are present for all types except `OBJECT`.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FieldName is required.")]
        [JsonProperty(PropertyName = "fieldName")]
        public string FieldName { get; set; }
        
        /// <value>
        /// Indicates that this field is actually an array of the specified field type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isArray")]
        public System.Nullable<bool> IsArray { get; set; }
        
        /// <value>
        /// If the field type is `OBJECT`, then this property will provide all the individual properties of the object that can
        /// be queried.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "objectProperties")]
        public System.Collections.Generic.List<QueryableFieldDescription> ObjectProperties { get; set; }
        
    }
}
