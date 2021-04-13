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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Details of the ssh key that will be used.
    /// 
    /// </summary>
    public class UpdateSshDetails 
    {
        
        /// <value>
        /// Name of the host the sshkey is valid for.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <value>
        /// Private ssh key string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sshkey")]
        public string Sshkey { get; set; }
        
        /// <value>
        /// SSH user
        /// 
        /// </value>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }
        
        /// <value>
        /// Sudo location
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sudoLocation")]
        public string SudoLocation { get; set; }
        
    }
}
