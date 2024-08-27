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


namespace Oci.AidocumentService.Models
{
    /// <summary>
    /// Request payload to add lock to the resource.
    /// </summary>
    public class AddProjectLockDetails 
    {
                ///
        /// <value>
        /// Type of the lock.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "FULL")]
            Full,
            [EnumMember(Value = "DELETE")]
            Delete
        };

        /// <value>
        /// Type of the lock.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The ID of the resource that is locking this resource. Indicates that deleting this resource will remove the lock.
        /// </value>
        [JsonProperty(PropertyName = "relatedResourceId")]
        public string RelatedResourceId { get; set; }
        
        /// <value>
        /// A message added by the creator of the lock. This is typically used to give an indication of why the resource is locked.
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
    }
}
