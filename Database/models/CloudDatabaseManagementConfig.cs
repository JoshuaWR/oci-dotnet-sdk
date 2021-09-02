/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// The configuration of the Database Management service.
    /// </summary>
    public class CloudDatabaseManagementConfig 
    {
                ///
        /// <value>
        /// The status of the Database Management service.
        /// </value>
        ///
        public enum ManagementStatusEnum {
            [EnumMember(Value = "ENABLING")]
            Enabling,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLING")]
            Disabling,
            [EnumMember(Value = "DISABLED")]
            Disabled,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "FAILED_ENABLING")]
            FailedEnabling,
            [EnumMember(Value = "FAILED_DISABLING")]
            FailedDisabling,
            [EnumMember(Value = "FAILED_UPDATING")]
            FailedUpdating
        };

        /// <value>
        /// The status of the Database Management service.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagementStatus is required.")]
        [JsonProperty(PropertyName = "managementStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ManagementStatusEnum> ManagementStatus { get; set; }
                ///
        /// <value>
        /// The Database Management type.
        /// </value>
        ///
        public enum ManagementTypeEnum {
            [EnumMember(Value = "BASIC")]
            Basic,
            [EnumMember(Value = "ADVANCED")]
            Advanced
        };

        /// <value>
        /// The Database Management type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagementType is required.")]
        [JsonProperty(PropertyName = "managementType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ManagementTypeEnum> ManagementType { get; set; }
        
    }
}
