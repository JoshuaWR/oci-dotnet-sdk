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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// A supported MySQL Version.
    /// 
    /// </summary>
    public class Version 
    {
        
        /// <value>
        /// The specific version identifier
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string VersionProp { get; set; }
        
        /// <value>
        /// A link to a page describing the version.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
    }
}
