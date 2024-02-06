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
    /// The mapping between a file system export in the primary region and a mount target in the standby region.
    /// </summary>
    public class FileSystemExportMappingDetails 
    {
        
        /// <value>
        /// The OCID of the export path in the primary region used to mount or unmount the file system.
        /// <br/>
        /// Example: ocid1.export.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExportId is required.")]
        [JsonProperty(PropertyName = "exportId")]
        public string ExportId { get; set; }
        
        /// <value>
        /// The OCID of the destination mount target in the destination region which is used to export the file system.
        /// <br/>
        /// Example: ocid1.mounttarget.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationMountTargetId is required.")]
        [JsonProperty(PropertyName = "destinationMountTargetId")]
        public string DestinationMountTargetId { get; set; }
        
    }
}