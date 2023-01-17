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
    /// To use any of the API operations, you must be authorized in an IAM policy. If you are not authorized,
    /// talk to an administrator. If you are an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class RenameObjectDetails 
    {
        
        /// <value>
        /// The name of the source object to be renamed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceName is required.")]
        [JsonProperty(PropertyName = "sourceName")]
        public string SourceName { get; set; }
        
        /// <value>
        /// The new name of the source object. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NewName is required.")]
        [JsonProperty(PropertyName = "newName")]
        public string NewName { get; set; }
        
        /// <value>
        /// The if-match entity tag (ETag) of the source object.
        /// </value>
        [JsonProperty(PropertyName = "srcObjIfMatchETag")]
        public string SrcObjIfMatchETag { get; set; }
        
        /// <value>
        /// The if-match entity tag (ETag) of the new object.
        /// </value>
        [JsonProperty(PropertyName = "newObjIfMatchETag")]
        public string NewObjIfMatchETag { get; set; }
        
        /// <value>
        /// The if-none-match entity tag (ETag) of the new object. The only valid value is '*', which indicates
        /// request should fail if the new object already exists.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "newObjIfNoneMatchETag")]
        public string NewObjIfNoneMatchETag { get; set; }
        
    }
}
