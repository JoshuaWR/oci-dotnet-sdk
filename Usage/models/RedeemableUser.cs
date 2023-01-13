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


namespace Oci.UsageService.Models
{
    /// <summary>
    /// The summary of a user that can redeem rewards.
    /// </summary>
    public class RedeemableUser 
    {
        
        /// <value>
        /// The email ID for a user that can redeem rewards.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EmailId is required.")]
        [JsonProperty(PropertyName = "emailId")]
        public string EmailId { get; set; }
        
        /// <value>
        /// The first name of the user that can redeem rewards.
        /// </value>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        
        /// <value>
        /// The last name of the user that can redeem rewards.
        /// </value>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }
        
    }
}
