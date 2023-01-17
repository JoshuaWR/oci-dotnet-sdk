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
    /// As the name suggests, an `DbCredentialSummary` object contains information about an `DbCredential`.
    /// The DB credential is used for DB authentication with
    /// the [DB Service].
    /// 
    /// </summary>
    public class DbCredentialSummary 
    {
        
        /// <value>
        /// The OCID of the DB credential.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the user the DB credential belongs to.
        /// </value>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
        
        /// <value>
        /// The description you assign to the DB credential. Does not have to be unique, and it's changeable.
        /// <br/>
        /// (For tenancies that support identity domains) You can have an empty description.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Date and time the `DbCredential` object was created, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Date and time when this credential will expire, in the format defined by RFC3339.
        /// Null if it never expires.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeExpires")]
        public System.Nullable<System.DateTime> TimeExpires { get; set; }
        
        /// <value>
        /// The credential's current state. After creating a DB credential, make sure its `lifecycleState` changes from
        /// CREATING to ACTIVE before using it.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DbCredential.LifecycleStateEnum> LifecycleState { get; set; }
        
    }
}
