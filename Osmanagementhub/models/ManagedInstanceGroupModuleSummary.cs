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
    /// Summary information pertaining to a module on a managed instance group.
    /// </summary>
    public class ManagedInstanceGroupModuleSummary 
    {
        
        /// <value>
        /// The name of the module that contains the stream.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The name of the module that contains the stream.
        /// </value>
        [JsonProperty(PropertyName = "enabledStream")]
        public string EnabledStream { get; set; }
        
        /// <value>
        /// The list of installed profiles under the currently enabled module stream.
        /// </value>
        [JsonProperty(PropertyName = "installedProfiles")]
        public System.Collections.Generic.List<string> InstalledProfiles { get; set; }
        
        /// <value>
        /// The OCID of the software source that provides this module stream.
        /// </value>
        [JsonProperty(PropertyName = "softwareSourceId")]
        public string SoftwareSourceId { get; set; }
        
    }
}