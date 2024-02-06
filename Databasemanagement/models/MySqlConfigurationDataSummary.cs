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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The configuration variables for a MySQL Database.
    /// </summary>
    public class MySqlConfigurationDataSummary 
    {
        
        /// <value>
        /// The name of the configuration variable
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The value of the variable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
                ///
        /// <value>
        /// The source from which the variable was most recently set.
        /// </value>
        ///
        public enum SourceEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "COMPILED")]
            Compiled,
            [EnumMember(Value = "GLOBAL")]
            Global,
            [EnumMember(Value = "SERVER")]
            Server,
            [EnumMember(Value = "EXPLICIT")]
            Explicit,
            [EnumMember(Value = "EXTRA")]
            Extra,
            [EnumMember(Value = "USER")]
            User,
            [EnumMember(Value = "LOGIN")]
            Login,
            [EnumMember(Value = "COMMAND_LINE")]
            CommandLine,
            [EnumMember(Value = "PERSISTED")]
            Persisted,
            [EnumMember(Value = "DYNAMIC")]
            Dynamic
        };

        /// <value>
        /// The source from which the variable was most recently set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Source is required.")]
        [JsonProperty(PropertyName = "source")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SourceEnum> Source { get; set; }
        
        /// <value>
        /// The minimum value of the variable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MinValue is required.")]
        [JsonProperty(PropertyName = "minValue")]
        public System.Nullable<decimal> MinValue { get; set; }
        
        /// <value>
        /// The maximum value of the variable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaxValue is required.")]
        [JsonProperty(PropertyName = "maxValue")]
        public System.Nullable<decimal> MaxValue { get; set; }
        
        /// <value>
        /// The type of variable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// The default value of the variable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefaultValue is required.")]
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }
        
        /// <value>
        /// The time when the value of the variable was set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeSet is required.")]
        [JsonProperty(PropertyName = "timeSet")]
        public System.Nullable<System.DateTime> TimeSet { get; set; }
        
        /// <value>
        /// The host from where the value of the variable was set. This is empty for a MySQL Database System.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostSet is required.")]
        [JsonProperty(PropertyName = "hostSet")]
        public string HostSet { get; set; }
        
        /// <value>
        /// The user who sets the value of the variable. This is empty for a MySQL Database System.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserSet is required.")]
        [JsonProperty(PropertyName = "userSet")]
        public string UserSet { get; set; }
        
        /// <value>
        /// Indicates whether the variable can be set dynamically or not.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsDynamic is required.")]
        [JsonProperty(PropertyName = "isDynamic")]
        public System.Nullable<bool> IsDynamic { get; set; }
        
        /// <value>
        /// Indicates whether the variable is set at server startup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsInit is required.")]
        [JsonProperty(PropertyName = "isInit")]
        public System.Nullable<bool> IsInit { get; set; }
        
        /// <value>
        /// Indicates whether the variable is configurable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsConfigurable is required.")]
        [JsonProperty(PropertyName = "isConfigurable")]
        public System.Nullable<bool> IsConfigurable { get; set; }
        
        /// <value>
        /// The path name of the option file (VARIABLE_PATH), if the variable was set in an option file. If the variable was not set in an
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Path is required.")]
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <value>
        /// The description of the variable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The comma-separated list of possible values for the variable in value:valueDescription format.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PossibleValues is required.")]
        [JsonProperty(PropertyName = "possibleValues")]
        public string PossibleValues { get; set; }
        
        /// <value>
        /// The comma-separated list of MySQL versions that support the variable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SupportedVersions is required.")]
        [JsonProperty(PropertyName = "supportedVersions")]
        public string SupportedVersions { get; set; }
        
    }
}