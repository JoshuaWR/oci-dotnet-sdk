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


namespace Oci.DataflowService.Models
{
    /// <summary>
    /// Single Client Access Name (SCAN) is the object with a fully-qualified domain name and a port number.
    /// 
    /// </summary>
    public class Scan 
    {
        
        /// <value>
        /// A fully-qualified domain name (FQDN).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; set; }
        
        /// <value>
        /// The port number of the FQDN
        /// 
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }
        
    }
}
