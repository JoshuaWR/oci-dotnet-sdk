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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Details to update a sensitive column in a sensitive data model.
    /// </summary>
    public class UpdateSensitiveColumnDetails 
    {
        
        /// <value>
        /// The data type of the sensitive column.
        /// </value>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }
                ///
        /// <value>
        /// The status of the sensitive column. VALID means the column is considered sensitive. INVALID means the column
        /// is not considered sensitive. Tracking invalid columns in a sensitive data model helps ensure that an incremental
        /// data discovery job does not identify these columns as sensitive.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "VALID")]
            Valid,
            [EnumMember(Value = "INVALID")]
            Invalid
        };

        /// <value>
        /// The status of the sensitive column. VALID means the column is considered sensitive. INVALID means the column
        /// is not considered sensitive. Tracking invalid columns in a sensitive data model helps ensure that an incremental
        /// data discovery job does not identify these columns as sensitive.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The OCID of the sensitive type to be associated with the sensitive column.
        /// </value>
        [JsonProperty(PropertyName = "sensitiveTypeId")]
        public string SensitiveTypeId { get; set; }
        
        /// <value>
        /// Unique keys identifying the columns that are parents of the sensitive column. At present, it accepts only one
        /// parent column key. This attribute can be used to establish relationship between columns in a sensitive data model.
        /// Note that the parent column must be added to the sensitive data model before its key can be specified here.
        /// If this attribute is provided, the appDefinedChildColumnKeys or dbDefinedChildColumnKeys attribute of the
        /// parent column is automatically updated to reflect the relationship.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "parentColumnKeys")]
        public System.Collections.Generic.List<string> ParentColumnKeys { get; set; }
                ///
        /// <value>
        /// The type of referential relationship the sensitive column has with its parent. NONE indicates that the sensitive
        /// column does not have a parent. DB_DEFINED indicates that the relationship is defined in the database dictionary.
        /// APP_DEFINED indicates that the relationship is defined at the application level and not in the database dictionary.
        /// 
        /// </value>
        ///
        public enum RelationTypeEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "APP_DEFINED")]
            AppDefined,
            [EnumMember(Value = "DB_DEFINED")]
            DbDefined
        };

        /// <value>
        /// The type of referential relationship the sensitive column has with its parent. NONE indicates that the sensitive
        /// column does not have a parent. DB_DEFINED indicates that the relationship is defined in the database dictionary.
        /// APP_DEFINED indicates that the relationship is defined at the application level and not in the database dictionary.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "relationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RelationTypeEnum> RelationType { get; set; }
        
        /// <value>
        /// Unique keys identifying the columns that are application-level (non-dictionary) children of the sensitive column.
        /// This attribute can be used to establish relationship between columns in a sensitive data model. Note that the
        /// child columns must be added to the sensitive data model before their keys can be specified here. If this attribute
        /// is provided, the parentColumnKeys and relationType attributes of the child columns are automatically updated to reflect the relationship.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "appDefinedChildColumnKeys")]
        public System.Collections.Generic.List<string> AppDefinedChildColumnKeys { get; set; }
        
        /// <value>
        /// Unique keys identifying the columns that are database-level (dictionary-defined) children of the sensitive column.
        /// This attribute can be used to establish relationship between columns in a sensitive data model. Note that the
        /// child columns must be added to the sensitive data model before their keys can be specified here. If this attribute
        /// is provided, the parentColumnKeys and relationType attributes of the child columns are automatically updated to reflect the relationship.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbDefinedChildColumnKeys")]
        public System.Collections.Generic.List<string> DbDefinedChildColumnKeys { get; set; }
        
    }
}
