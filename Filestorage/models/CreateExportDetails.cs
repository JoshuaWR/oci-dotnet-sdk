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


namespace Oci.FilestorageService.Models
{
    /// <summary>
    /// Details for creating the export.
    /// </summary>
    public class CreateExportDetails 
    {
        
        /// <value>
        /// Export options for the new export. If left unspecified,
        /// defaults to:
        /// <br/>
        ///        [
        ///          {
        ///             \"source\" : \"0.0.0.0/0\",
        ///             \"requirePrivilegedSourcePort\" : false,
        ///             \"access\": \"READ_WRITE\",
        ///             \"identitySquash\": \"NONE\",
        ///             \"anonymousUid\": 65534,
        ///             \"anonymousGid\": 65534,
        ///             \"isAnonymousAccessAllowed\": false,
        ///             \"allowedAuth\": [\"SYS\"]
        ///           }
        ///        ]
        /// <br/>
        ///   **Note:** Mount targets do not have Internet-routable IP
        ///   addresses.  Therefore they will not be reachable from the
        ///   Internet, even if an associated `ClientOptions` item has
        ///   a source of `0.0.0.0/0`.
        /// <br/>
        ///   **If set to the empty array then the export will not be
        ///   visible to any clients.**
        /// <br/>
        ///   The export's `exportOptions` can be changed after creation
        ///   using the `UpdateExport` operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "exportOptions")]
        public System.Collections.Generic.List<ClientOptions> ExportOptions { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of this export's export set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExportSetId is required.")]
        [JsonProperty(PropertyName = "exportSetId")]
        public string ExportSetId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of this export's file system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FileSystemId is required.")]
        [JsonProperty(PropertyName = "fileSystemId")]
        public string FileSystemId { get; set; }
        
        /// <value>
        /// Path used to access the associated file system.
        /// <br/>
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: /mediafiles
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Path is required.")]
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
    }
}
