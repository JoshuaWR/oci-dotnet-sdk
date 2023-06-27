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
    /// The details of the module stream profile to be installed/removed on a managed instance.
    /// </summary>
    public class ModuleStreamProfileDetailsBody 
    {
        
        /// <value>
        /// The name of a module.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModuleName is required.")]
        [JsonProperty(PropertyName = "moduleName")]
        public string ModuleName { get; set; }
        
        /// <value>
        /// The name of a stream of the specified module.
        /// </value>
        [JsonProperty(PropertyName = "streamName")]
        public string StreamName { get; set; }
        
        /// <value>
        /// The name of a profile of the specified module stream.
        /// </value>
        [JsonProperty(PropertyName = "profileName")]
        public string ProfileName { get; set; }
        
        [JsonProperty(PropertyName = "workRequestDetails")]
        public WorkRequestDetails WorkRequestDetails { get; set; }
        
    }
}
