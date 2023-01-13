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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// Properties indicating how the user is allowed to authenticate.
    /// </summary>
    public class UserCapabilities 
    {
        
        /// <value>
        /// Indicates if the user can log in to the console.
        /// </value>
        [JsonProperty(PropertyName = "canUseConsolePassword")]
        public System.Nullable<bool> CanUseConsolePassword { get; set; }
        
        /// <value>
        /// Indicates if the user can use API keys.
        /// </value>
        [JsonProperty(PropertyName = "canUseApiKeys")]
        public System.Nullable<bool> CanUseApiKeys { get; set; }
        
        /// <value>
        /// Indicates if the user can use SWIFT passwords / auth tokens.
        /// </value>
        [JsonProperty(PropertyName = "canUseAuthTokens")]
        public System.Nullable<bool> CanUseAuthTokens { get; set; }
        
        /// <value>
        /// Indicates if the user can use SMTP passwords.
        /// </value>
        [JsonProperty(PropertyName = "canUseSmtpCredentials")]
        public System.Nullable<bool> CanUseSmtpCredentials { get; set; }
        
        /// <value>
        /// Indicates if the user can use DB passwords.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "canUseDbCredentials")]
        public System.Nullable<bool> CanUseDbCredentials { get; set; }
        
        /// <value>
        /// Indicates if the user can use SigV4 symmetric keys.
        /// </value>
        [JsonProperty(PropertyName = "canUseCustomerSecretKeys")]
        public System.Nullable<bool> CanUseCustomerSecretKeys { get; set; }
        
        /// <value>
        /// Indicates if the user can use OAuth2 credentials and tokens.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "canUseOAuth2ClientCredentials")]
        public System.Nullable<bool> CanUseOAuth2ClientCredentials { get; set; }
        
    }
}
