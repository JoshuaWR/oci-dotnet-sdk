/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details of the action parameter and its possible values that is used in listParamsForActionType.
    /// 
    /// </summary>
    public class ActionParamValuesSummary 
    {
        
        /// <value>
        /// The name of this parameter.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParameterName is required.")]
        [JsonProperty(PropertyName = "parameterName")]
        public string ParameterName { get; set; }
                ///
        /// <value>
        /// The type of the parameter.
        /// </value>
        ///
        public enum ParameterTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "BOOLEAN")]
            Boolean,
            [EnumMember(Value = "STRING")]
            String,
            [EnumMember(Value = "INTEGER")]
            Integer
        };

        /// <value>
        /// The type of the parameter.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParameterType is required.")]
        [JsonProperty(PropertyName = "parameterType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ParameterTypeEnum> ParameterType { get; set; }
        
        /// <value>
        /// Possible values for this parameter. In case of integer it's min and max values.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParameterValues is required.")]
        [JsonProperty(PropertyName = "parameterValues")]
        public System.Collections.Generic.List<string> ParameterValues { get; set; }
        
        /// <value>
        /// The default value for this parameter.
        /// </value>
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }
        
        /// <value>
        /// Whether this parameter is required or not for this action type.\u3001
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsRequired is required.")]
        [JsonProperty(PropertyName = "isRequired")]
        public System.Nullable<bool> IsRequired { get; set; }
        
    }
}