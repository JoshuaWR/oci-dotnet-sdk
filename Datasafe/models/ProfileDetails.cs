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
    /// The details of a particular profile
    /// 
    /// </summary>
    public class ProfileDetails 
    {
        
        /// <value>
        /// The number of users using this profile.
        /// </value>
        [JsonProperty(PropertyName = "numUsers")]
        public System.Nullable<int> NumUsers { get; set; }
        
        /// <value>
        /// The value of the CONNECT_TIME resource parameter.
        /// </value>
        [JsonProperty(PropertyName = "connectTime")]
        public string ConnectTime { get; set; }
        
        /// <value>
        /// The value of the FAILED_LOGIN_ATTEMPTS password parameter.
        /// </value>
        [JsonProperty(PropertyName = "failedLoginAttempts")]
        public string FailedLoginAttempts { get; set; }
        
        /// <value>
        /// The value of the IDLE_TIME resource parameter.
        /// </value>
        [JsonProperty(PropertyName = "idleTime")]
        public string IdleTime { get; set; }
        
        /// <value>
        /// The value of the INACTIVE_ACCOUNT_TIME password parameter.
        /// </value>
        [JsonProperty(PropertyName = "inactiveAccountTime")]
        public string InactiveAccountTime { get; set; }
        
        /// <value>
        /// The value of the PASSWORD_GRACE_TIME password parameter.
        /// </value>
        [JsonProperty(PropertyName = "passwordGraceTime")]
        public string PasswordGraceTime { get; set; }
        
        /// <value>
        /// The value of the PASSWORD_LIFE_TIME password parameter.
        /// </value>
        [JsonProperty(PropertyName = "passwordLifeTime")]
        public string PasswordLifeTime { get; set; }
        
        /// <value>
        /// The value of the PASSWORD_LOCK_TIME password parameter.
        /// </value>
        [JsonProperty(PropertyName = "passwordLockTime")]
        public string PasswordLockTime { get; set; }
        
        /// <value>
        /// The value of the PASSWORD_REUSE_TIME password parameter.
        /// </value>
        [JsonProperty(PropertyName = "passwordReuseTime")]
        public string PasswordReuseTime { get; set; }
        
        /// <value>
        /// The value of the PASSWORD_REUSE_MAX resource parameter.
        /// </value>
        [JsonProperty(PropertyName = "passwordReuseMax")]
        public string PasswordReuseMax { get; set; }
        
        /// <value>
        /// The value of the PASSWORD_VERIFY_FUNCTION resource.
        /// </value>
        [JsonProperty(PropertyName = "passwordVerifyFunction")]
        public string PasswordVerifyFunction { get; set; }
        
    }
}
