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
    /// A file system and the path that you can use to mount it. Each export
    /// resource belongs to exactly one export set.
    /// <br/>
    /// The export's path attribute is not a path in the
    /// referenced file system, but the value used by clients for the path
    /// component of the remotetarget argument when mounting the file
    /// system.
    /// <br/>
    /// The path must start with a slash (/) followed by a sequence of zero or more
    /// slash-separated path elements. For any two export resources associated with
    /// the same export set, except those in a 'DELETED' state, the path element
    /// sequence for the first export resource can't contain the
    /// complete path element sequence of the second export resource.
    /// <br/>
    /// 
    /// For example, the following are acceptable:
    /// <br/>
    ///   * /example and /path
    ///   * /example1 and /example2
    ///   * /example and /example1
    /// <br/>
    /// The following examples are not acceptable:
    ///   * /example and /example/path
    ///   * / and /example
    /// <br/>
    /// Paths may not end in a slash (/). No path element can be a period (.)
    /// or two periods in sequence (..). All path elements must be 255 bytes or less.
    /// <br/>
    /// No two non-'DELETED' export resources in the same export set can
    /// reference the same file system.
    /// <br/>
    /// Use `exportOptions` to control access to an export. For more information, see
    /// [Export Options](https://docs.cloud.oracle.com/Content/File/Tasks/exportoptions.htm).
    /// 
    /// </summary>
    public class Export 
    {
        
        /// <value>
        /// Policies that apply to NFS requests made through this
        /// export. `exportOptions` contains a sequential list of
        /// `ClientOptions`. Each `ClientOptions` item defines the
        /// export options that are applied to a specified
        /// set of clients.
        /// <br/>
        /// For each NFS request, the first `ClientOptions` option
        /// in the list whose `source` attribute matches the source
        /// IP address of the request is applied.
        /// <br/>
        /// If a client source IP address does not match the `source`
        /// property of any `ClientOptions` in the list, then the
        /// export will be invisible to that client. This export will
        /// not be returned by `MOUNTPROC_EXPORT` calls made by the client
        /// and any attempt to mount or access the file system through
        /// this export will result in an error.
        /// <br/>
        /// **Exports without defined `ClientOptions` are invisible to all clients.**
        /// <br/>
        /// If one export is invisible to a particular client, associated file
        /// systems may still be accessible through other exports on the same
        /// or different mount targets.
        /// To completely deny client access to a file system, be sure that the client
        /// source IP address is not included in any export for any mount target
        /// associated with the file system.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExportOptions is required.")]
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
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of this export.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The current state of this export.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The current state of this export.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Path used to access the associated file system.
        /// <br/>
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: /accounting
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Path is required.")]
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <value>
        /// The date and time the export was created, expressed
        /// in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) timestamp format.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }
}
