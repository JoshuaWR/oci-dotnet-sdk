/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// The details of operations performed on a file system.
    /// 
    /// </summary>
    public class ComputeInstanceMovableFileSystemOperation 
    {
        
        /// <value>
        /// The export path of the file system.
        /// <br/>
        /// Example: /fs-export-path
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExportPath is required.")]
        [JsonProperty(PropertyName = "exportPath")]
        public string ExportPath { get; set; }
        
        /// <value>
        /// The physical mount point of the file system on a host.
        /// <br/>
        /// Example: /mnt/yourmountpoint
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MountPoint is required.")]
        [JsonProperty(PropertyName = "mountPoint")]
        public string MountPoint { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MountDetails is required.")]
        [JsonProperty(PropertyName = "mountDetails")]
        public FileSystemMountDetails MountDetails { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UnmountDetails is required.")]
        [JsonProperty(PropertyName = "unmountDetails")]
        public FileSystemUnmountDetails UnmountDetails { get; set; }
        
    }
}