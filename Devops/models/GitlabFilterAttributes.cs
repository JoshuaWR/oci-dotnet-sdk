/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Attributes to filter GitLab events.
    /// </summary>
    public class GitlabFilterAttributes 
    {
        
        /// <value>
        /// Branch for push event; source branch for pull requests.
        /// </value>
        [JsonProperty(PropertyName = "headRef")]
        public string HeadRef { get; set; }
        
        /// <value>
        /// The target branch for pull requests; not applicable for push requests.
        /// </value>
        [JsonProperty(PropertyName = "baseRef")]
        public string BaseRef { get; set; }
        
        [JsonProperty(PropertyName = "fileFilter")]
        public FileFilter FileFilter { get; set; }
        
    }
}
