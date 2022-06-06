/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Metadata of a column in a data object resultset.
    /// </summary>
    public class DataObjectColumnMetadata 
    {
        
        /// <value>
        /// Name of the column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// Category of the column.
        /// </value>
        ///
        public enum CategoryEnum {
            [EnumMember(Value = "DIMENSION")]
            Dimension,
            [EnumMember(Value = "METRIC")]
            Metric,
            [EnumMember(Value = "TIME_DIMENSION")]
            TimeDimension
        };

        /// <value>
        /// Category of the column.
        /// </value>
        [JsonProperty(PropertyName = "category")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CategoryEnum> Category { get; set; }
                ///
        /// <value>
        /// Type of a data object column.
        /// </value>
        ///
        public enum DataTypeNameEnum {
            [EnumMember(Value = "NUMBER")]
            Number,
            [EnumMember(Value = "TIMESTAMP")]
            Timestamp,
            [EnumMember(Value = "VARCHAR2")]
            Varchar2
        };

        /// <value>
        /// Type of a data object column.
        /// </value>
        [JsonProperty(PropertyName = "dataTypeName")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DataTypeNameEnum> DataTypeName { get; set; }
        
        /// <value>
        /// Display name of the column.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the column.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Group name of the column.
        /// </value>
        [JsonProperty(PropertyName = "groupName")]
        public string GroupName { get; set; }
        
        [JsonProperty(PropertyName = "unitDetails")]
        public DataObjectColumnUnit UnitDetails { get; set; }
        
    }
}
