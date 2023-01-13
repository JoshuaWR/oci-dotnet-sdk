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
    /// Details of a role fetched from the database.
    /// </summary>
    public class RoleSummary 
    {
        
        /// <value>
        /// Name of the role.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RoleName is required.")]
        [JsonProperty(PropertyName = "roleName")]
        public string RoleName { get; set; }
        
        /// <value>
        /// Type of authentication.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuthenticationType is required.")]
        [JsonProperty(PropertyName = "authenticationType")]
        public string AuthenticationType { get; set; }
        
        /// <value>
        /// Is password required.
        /// </value>
        [JsonProperty(PropertyName = "isPasswordRequired")]
        public System.Nullable<bool> IsPasswordRequired { get; set; }
        
        /// <value>
        /// Is the role common.
        /// </value>
        [JsonProperty(PropertyName = "isCommon")]
        public System.Nullable<bool> IsCommon { get; set; }
        
        /// <value>
        /// Is the role oracle maintained.
        /// </value>
        [JsonProperty(PropertyName = "isOracleMaintained")]
        public System.Nullable<bool> IsOracleMaintained { get; set; }
        
        /// <value>
        /// Is the role inherited.
        /// </value>
        [JsonProperty(PropertyName = "isInherited")]
        public System.Nullable<bool> IsInherited { get; set; }
        
        /// <value>
        /// Is the role implicit.
        /// </value>
        [JsonProperty(PropertyName = "isImplicit")]
        public System.Nullable<bool> IsImplicit { get; set; }
        
    }
}
