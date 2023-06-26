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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// An automatic capture filter that enables you to capture only those SQL statements
    /// that you want, and exclude noncritical statements.
    /// 
    /// </summary>
    public class AutomaticCaptureFilter 
    {
                ///
        /// <value>
        /// The name of the automatic capture filter.
        /// <br/>
        /// - AUTO_CAPTURE_SQL_TEXT: Search pattern to apply to SQL text.
        /// - AUTO_CAPTURE_PARSING_SCHEMA_NAME: Parsing schema to include or exclude for SQL plan management auto capture.
        /// - AUTO_CAPTURE_MODULE: Module to include or exclude for SQL plan management auto capture.
        /// - AUTO_CAPTURE_ACTION: Action to include or exclude for SQL plan management automatic capture.
        /// 
        /// </value>
        ///
        public enum NameEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AUTO_CAPTURE_SQL_TEXT")]
            AutoCaptureSqlText,
            [EnumMember(Value = "AUTO_CAPTURE_PARSING_SCHEMA_NAME")]
            AutoCaptureParsingSchemaName,
            [EnumMember(Value = "AUTO_CAPTURE_MODULE")]
            AutoCaptureModule,
            [EnumMember(Value = "AUTO_CAPTURE_ACTION")]
            AutoCaptureAction
        };

        /// <value>
        /// The name of the automatic capture filter.
        /// <br/>
        /// - AUTO_CAPTURE_SQL_TEXT: Search pattern to apply to SQL text.
        /// - AUTO_CAPTURE_PARSING_SCHEMA_NAME: Parsing schema to include or exclude for SQL plan management auto capture.
        /// - AUTO_CAPTURE_MODULE: Module to include or exclude for SQL plan management auto capture.
        /// - AUTO_CAPTURE_ACTION: Action to include or exclude for SQL plan management automatic capture.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "name")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NameEnum> Name { get; set; }
        
        /// <value>
        /// A list of filter values to include.
        /// </value>
        [JsonProperty(PropertyName = "valuesToInclude")]
        public System.Collections.Generic.List<string> ValuesToInclude { get; set; }
        
        /// <value>
        /// A list of filter values to exclude.
        /// </value>
        [JsonProperty(PropertyName = "valuesToExclude")]
        public System.Collections.Generic.List<string> ValuesToExclude { get; set; }
        
        /// <value>
        /// The time the filter value was last updated.
        /// </value>
        [JsonProperty(PropertyName = "timeLastModified")]
        public System.Nullable<System.DateTime> TimeLastModified { get; set; }
        
        /// <value>
        /// The database user who last updated the filter value.
        /// </value>
        [JsonProperty(PropertyName = "modifiedBy")]
        public string ModifiedBy { get; set; }
        
    }
}
