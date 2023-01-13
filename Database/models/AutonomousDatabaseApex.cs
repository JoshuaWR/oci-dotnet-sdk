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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Oracle APEX Application Development is a low-code development platform that enables you to build scalable, secure enterprise apps, with world-class features. Autonomous Database with the APEX workload type is optimized to support APEX development.
    /// 
    /// </summary>
    public class AutonomousDatabaseApex 
    {
        
        /// <value>
        /// The Oracle APEX Application Development version.
        /// </value>
        [JsonProperty(PropertyName = "apexVersion")]
        public string ApexVersion { get; set; }
        
        /// <value>
        /// The Oracle REST Data Services (ORDS) version.
        /// </value>
        [JsonProperty(PropertyName = "ordsVersion")]
        public string OrdsVersion { get; set; }
        
    }
}
