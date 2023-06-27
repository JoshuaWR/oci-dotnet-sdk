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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// A dependency for a software package.
    /// </summary>
    public class SoftwarePackageDependency 
    {
        
        /// <value>
        /// The software package's dependency.
        /// </value>
        [JsonProperty(PropertyName = "dependency")]
        public string Dependency { get; set; }
        
        /// <value>
        /// The type of the dependency.
        /// </value>
        [JsonProperty(PropertyName = "dependencyType")]
        public string DependencyType { get; set; }
        
        /// <value>
        /// The modifier for the dependency.
        /// </value>
        [JsonProperty(PropertyName = "dependencyModifier")]
        public string DependencyModifier { get; set; }
        
    }
}