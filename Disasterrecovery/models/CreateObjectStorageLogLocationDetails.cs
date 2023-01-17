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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// Information about creating an Object Storage log location for a DR Protection Group.
    /// </summary>
    public class CreateObjectStorageLogLocationDetails 
    {
        
        /// <value>
        /// The namespace in Object Storage (Note - this is usually the tenancy name).
        /// <br/>
        /// Example: myocitenancy
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// The bucket name inside the Object Storage namespace.
        /// <br/>
        /// Example: operation_logs
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Bucket is required.")]
        [JsonProperty(PropertyName = "bucket")]
        public string Bucket { get; set; }
        
    }
}
