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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// The parameters required by Object Storage to process a request to copy an object to another bucket.
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you are not authorized,
    /// talk to an administrator. If you are an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class CopyObjectDetails 
    {
        
        /// <value>
        /// The name of the object to be copied.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceObjectName is required.")]
        [JsonProperty(PropertyName = "sourceObjectName")]
        public string SourceObjectName { get; set; }
        
        /// <value>
        /// The entity tag (ETag) to match against that of the source object. Used to confirm that the source object
        /// with a given name is the version of that object storing a specified ETag.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceObjectIfMatchETag")]
        public string SourceObjectIfMatchETag { get; set; }
        
        /// <value>
        /// VersionId of the object to copy. If not provided then current version is copied by default.
        /// </value>
        [JsonProperty(PropertyName = "sourceVersionId")]
        public string SourceVersionId { get; set; }
        
        /// <value>
        /// The destination region the object will be copied to, for example \"us-ashburn-1\".
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationRegion is required.")]
        [JsonProperty(PropertyName = "destinationRegion")]
        public string DestinationRegion { get; set; }
        
        /// <value>
        /// The destination Object Storage namespace the object will be copied to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationNamespace is required.")]
        [JsonProperty(PropertyName = "destinationNamespace")]
        public string DestinationNamespace { get; set; }
        
        /// <value>
        /// The destination bucket the object will be copied to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationBucket is required.")]
        [JsonProperty(PropertyName = "destinationBucket")]
        public string DestinationBucket { get; set; }
        
        /// <value>
        /// The name of the destination object resulting from the copy operation. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationObjectName is required.")]
        [JsonProperty(PropertyName = "destinationObjectName")]
        public string DestinationObjectName { get; set; }
        
        /// <value>
        /// The entity tag (ETag) to match against that of the destination object (an object intended to be overwritten).
        /// Used to confirm that the destination object stored under a given name is the version of that object
        /// storing a specified entity tag.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "destinationObjectIfMatchETag")]
        public string DestinationObjectIfMatchETag { get; set; }
        
        /// <value>
        /// The entity tag (ETag) to avoid matching. The only valid value is '*', which indicates that the request should fail
        /// if the object already exists in the destination bucket.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "destinationObjectIfNoneMatchETag")]
        public string DestinationObjectIfNoneMatchETag { get; set; }
        
        /// <value>
        /// Arbitrary string keys and values for the user-defined metadata for the object. Keys must be in
        /// \"opc-meta-*\" format. Avoid entering confidential information. Metadata key-value pairs entered
        /// in this field are assigned to the destination object. If you enter no metadata values, the destination
        /// object will inherit any existing metadata values associated with the source object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "destinationObjectMetadata")]
        public System.Collections.Generic.Dictionary<string, string> DestinationObjectMetadata { get; set; }
        
        /// <value>
        /// The storage tier that the object should be stored in. If not specified, the object will be stored in
        /// the same storage tier as the bucket.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "destinationObjectStorageTier")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StorageTier> DestinationObjectStorageTier { get; set; }
        
    }
}
