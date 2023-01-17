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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The information about the application.
    /// </summary>
    public class SourceApplicationInfo 
    {
        
        /// <value>
        /// The OCID of the workspace containing the application. This allows cross workspace deployment to publish an application from a different workspace into the current workspace specified in this operation.
        /// </value>
        [JsonProperty(PropertyName = "workspaceId")]
        public string WorkspaceId { get; set; }
        
        /// <value>
        /// The source application key to use when creating the application.
        /// </value>
        [JsonProperty(PropertyName = "applicationKey")]
        public string ApplicationKey { get; set; }
        
        /// <value>
        /// The source application version of the application.
        /// </value>
        [JsonProperty(PropertyName = "applicationVersion")]
        public string ApplicationVersion { get; set; }
        
        /// <value>
        /// The last patch key for the application.
        /// </value>
        [JsonProperty(PropertyName = "lastPatchKey")]
        public string LastPatchKey { get; set; }
        
    }
}
